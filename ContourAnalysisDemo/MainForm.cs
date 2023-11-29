using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using ContourAnalysis;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ContourAnalysisDemo
{
    public partial class MainForm : Form
    {
        private Capture _capture;
        Image<Bgr, Byte> frame;
        ImageProcessor processor;
        Dictionary<string, Image> AugmentedRealityImages = new Dictionary<string, Image>();

        bool captureFromCam = true;
        int frameCount = 0;
        int oldFrameCount = 0;
        bool showAngle;
        int camWidth = 640;
        int camHeight = 480;
        string templateFile;

        public MainForm()
        {
            InitializeComponent();
            //create image preocessor
            processor = new ImageProcessor();
            //load default templates
            templateFile = AppDomain.CurrentDomain.BaseDirectory + "\\Tahoma.bin";
            LoadTemplates(templateFile);
            //start capture from cam
            StartCapture();
            //apply settings
            ApplySettings();
            //
            Application.Idle += new EventHandler(Application_Idle);
        }

        private void LoadTemplates(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                    processor.templates = (Templates)new BinaryFormatter().Deserialize(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveTemplates(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                    new BinaryFormatter().Serialize(fs, processor.templates);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StartCapture()
        {
            try
            {
                _capture = new Capture();
                ApplyCamSettings();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ApplyCamSettings()
        {
            try
            {
                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, camWidth);
                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, camHeight);
                cbCamResolution.Text = camWidth + "x" + camHeight;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Application_Idle(object sender, EventArgs e)
        {
            ProcessFrame();
        }

        private void ProcessFrame()
        {
            try
            {
                if (captureFromCam)
                    frame = _capture.QueryFrame();
                frameCount++;
                //
                processor.ProcessImage(frame);
                //
                if (cbShowBinarized.Checked)
                    ibMain.Image = processor.binarizedFrame;
                else
                    ibMain.Image = frame;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void tmUpdateState_Tick(object sender, EventArgs e)
        {
            lbFPS.Text = (frameCount - oldFrameCount) + " 帧/秒";
            oldFrameCount = frameCount;
            if (processor.contours != null)
                lbContoursCount.Text = "总轮廓数： " + processor.contours.Count;
            if (processor.foundTemplates != null)
                lbRecognized.Text = "已识别轮廓数： " + processor.foundTemplates.Count;
        }

        private void ibMain_Paint(object sender, PaintEventArgs e)
        {
            if (frame == null) return;

            Font font = new Font(Font.FontFamily, 24);//16

            e.Graphics.DrawString(lbFPS.Text, new Font(Font.FontFamily, 16), Brushes.Yellow, new PointF(1, 1));

            Brush bgBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
            Brush foreBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            Pen borderPen = new Pen(Color.FromArgb(150, 0, 255, 0));
            //
            if (cbShowContours.Checked)
                foreach (var contour in processor.contours)
                    if (contour.Total > 1)
                        e.Graphics.DrawLines(Pens.Red, contour.ToArray());
            //
            lock (processor.foundTemplates)
                foreach (FoundTemplateDesc found in processor.foundTemplates)
                {
                    if (found.template.name.EndsWith(".png") || found.template.name.EndsWith(".jpg"))
                    {
                        DrawAugmentedReality(found, e.Graphics);
                        continue;
                    }

                    Rectangle foundRect = found.sample.contour.SourceBoundingRect;
                    Point p1 = new Point((foundRect.Left + foundRect.Right) / 2, foundRect.Top);
                    string text = found.template.name;
                    if (showAngle)
                    {
                        int a=640, b=480;
                        switch(cbCamResolution.SelectedIndex)
                        {
                            case 0:a = 800;b = 600;break;
                            case 1:a = 640;b = 480;break;
                            case 2:a = 320;b = 240;break;
                        }
                        var mouse = new Point(MousePosition.X - Location.X - ibMain.Location.X - foundRect.Size.Width,
                                              MousePosition.Y - Location.Y - ibMain.Location.Y - 32);
                        var t = new Point((int)(1.0 * mouse.X / ibMain.Width * a),
                                           (int)(1.0 * mouse.Y / ibMain.Height * b));
                        var recPos = foundRect.Location;
                        var recPosB = foundRect.Location + foundRect.Size;
                        var fRect = new Rectangle(mouse, foundRect.Size);
                        //e.Graphics.DrawString(t.ToString() + recPos, font, foreBrush, t);
                        //e.Graphics.DrawRectangle(borderPen, fRect);   

                        if (t.X >= recPos.X && t.X <= recPosB.X &&
                            t.Y >= recPos.Y && t.Y <= recPosB.Y && showAngle)
                        //if (showAngle)
                        {
                            //text += string.Format("\r\nangle={0:000}°\r\nscale={1:0.0}", 180 * found.angle / Math.PI, found.scale);
                            e.Graphics.DrawString(string.Format("\r\n偏角={0:000}°\r\n缩放={1:0.0}", 180 * found.angle / Math.PI, found.scale), font, foreBrush, t);
                        }
                    }
                    e.Graphics.DrawRectangle(borderPen, foundRect);
                    e.Graphics.DrawString(text, font, bgBrush, new PointF(p1.X + 1 - font.Height / 3, p1.Y + 1 - font.Height));
                    e.Graphics.DrawString(text, font, foreBrush, new PointF(p1.X - font.Height / 3, p1.Y - font.Height));

                }
        }

        private void DrawAugmentedReality(FoundTemplateDesc found, Graphics gr)
        {
            string fileName = Path.GetDirectoryName(templateFile) + "\\" + found.template.name;
            if (!AugmentedRealityImages.ContainsKey(fileName))
            {
                if (!File.Exists(fileName)) return;
                AugmentedRealityImages[fileName] = Image.FromFile(fileName);
            }
            Image img = AugmentedRealityImages[fileName];
            Point p = found.sample.contour.SourceBoundingRect.Center();
            var state = gr.Save();
            gr.TranslateTransform(p.X, p.Y);
            gr.RotateTransform((float)(180f * found.angle / Math.PI));
            gr.ScaleTransform((float)(found.scale), (float)(found.scale));
            gr.DrawImage(img, new Point(-img.Width / 2, -img.Height / 2));
            gr.Restore(state);
        }

        private void cbAutoContrast_CheckedChanged(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void ApplySettings()
        {
            try
            {
                processor.equalizeHist = cbAutoContrast.Checked;
                showAngle = cbShowAngle.Checked;
                captureFromCam = cbCaptureFromCam.Checked;
                btLoadImage.Enabled = !captureFromCam;
                cbCamResolution.Enabled = captureFromCam;
                processor.finder.maxRotateAngle = cbAllowAngleMore45.Checked ? Math.PI : Math.PI / 4;
                processor.minContourArea = (int)nudMinContourArea.Value;
                processor.minContourLength = (int)nudMinContourLength.Value;
                processor.finder.maxACFDescriptorDeviation = (int)nudMaxACFdesc.Value;
                processor.finder.minACF = (double)nudMinACF.Value;
                processor.finder.minICF = (double)nudMinICF.Value;
                processor.blur = cbBlur.Checked;
                processor.noiseFilter = cbNoiseFilter.Checked;
                processor.cannyThreshold = (int)nudMinDefinition.Value;
                nudMinDefinition.Enabled = processor.noiseFilter;
                processor.adaptiveThresholdBlockSize = (int)nudAdaptiveThBlockSize.Value;
                processor.adaptiveThresholdParameter = cbAdaptiveNoiseFilter.Checked ? 1.5 : 0.5;
                //cam resolution
                string[] parts = cbCamResolution.Text.ToLower().Split('x');
                if (parts.Length == 2)
                {
                    int camWidth = int.Parse(parts[0]);
                    int camHeight = int.Parse(parts[1]);
                    if (this.camHeight != camHeight || this.camWidth != camWidth)
                    {
                        this.camWidth = camWidth;
                        this.camHeight = camHeight;
                        ApplyCamSettings();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                try
                {
                    frame = new Image<Bgr, byte>((Bitmap)Bitmap.FromFile(ofd.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btCreateTemplate_Click(object sender, EventArgs e)
        {
            if (frame != null)
                new ShowContoursForm(processor.templates, processor.samples, frame).ShowDialog();
        }

        private void btNewTemplates_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要新建模板数据库？", "新建模板数据库", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                processor.templates.Clear();
        }

        private void btOpenTemplates_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Templates(*.bin)|*.bin";
            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                templateFile = ofd.FileName;
                LoadTemplates(templateFile);
            }
        }

        private void btSaveTemplates_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Templates(*.bin)|*.bin";
            if (sfd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                templateFile = sfd.FileName;
                SaveTemplates(templateFile);
            }
        }

        private void btTemplateEditor_Click(object sender, EventArgs e)
        {
            new TemplateEditor(processor.templates).Show();
        }

        private void btAutoGenerate_Click(object sender, EventArgs e)
        {
            new AutoGenerateForm(processor).ShowDialog();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要新建模板数据库？", "新建模板数据库", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                processor.templates.Clear();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Templates(*.bin)|*.bin";
            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                templateFile = ofd.FileName;
                LoadTemplates(templateFile);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Templates(*.bin)|*.bin";
            if (sfd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                templateFile = sfd.FileName;
                SaveTemplates(templateFile);
            }
        }

        private void 创建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frame != null)
                new ShowContoursForm(processor.templates, processor.samples, frame).ShowDialog();
        }

        private void 自动生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AutoGenerateForm(processor).ShowDialog();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TemplateEditor(processor.templates).Show();
        }

        private void 查看使用说明书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new HelpForm1();
            f.Show();
        }

        private void 查看原理说明书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new HelpForm2();
            f.Show();
        }
    }
}