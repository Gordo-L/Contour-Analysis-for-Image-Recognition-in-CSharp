namespace ContourAnalysisDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lbFPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbContoursCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbRecognized = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmUpdateState = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNewTemplates = new System.Windows.Forms.ToolStripButton();
            this.btOpenTemplates = new System.Windows.Forms.ToolStripButton();
            this.btSaveTemplates = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btCreateTemplate = new System.Windows.Forms.ToolStripButton();
            this.btAutoGenerate = new System.Windows.Forms.ToolStripButton();
            this.btTemplateEditor = new System.Windows.Forms.ToolStripButton();
            this.ibMain = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAdaptiveNoiseFilter = new System.Windows.Forms.CheckBox();
            this.nudAdaptiveThBlockSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBlur = new System.Windows.Forms.CheckBox();
            this.cbAutoContrast = new System.Windows.Forms.CheckBox();
            this.btLoadImage = new System.Windows.Forms.Button();
            this.cbCamResolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCaptureFromCam = new System.Windows.Forms.CheckBox();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbAllowAngleMore45 = new System.Windows.Forms.CheckBox();
            this.nudMinICF = new System.Windows.Forms.NumericUpDown();
            this.nudMaxACFdesc = new System.Windows.Forms.NumericUpDown();
            this.nudMinACF = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNoiseFilter = new System.Windows.Forms.CheckBox();
            this.nudMinDefinition = new System.Windows.Forms.NumericUpDown();
            this.nudMinContourArea = new System.Windows.Forms.NumericUpDown();
            this.nudMinContourLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShowBinarized = new System.Windows.Forms.CheckBox();
            this.cbShowContours = new System.Windows.Forms.CheckBox();
            this.cbShowAngle = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.模板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.创建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看使用说明书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看使用说明书ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看原理说明书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdaptiveThBlockSize)).BeginInit();
            this.pnSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinICF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxACFdesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinACF)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDefinition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourLength)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbFPS,
            this.lbContoursCount,
            this.lbRecognized});
            this.ssMain.Location = new System.Drawing.Point(0, 663);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1070, 28);
            this.ssMain.TabIndex = 4;
            this.ssMain.Text = "statusStrip1";
            // 
            // lbFPS
            // 
            this.lbFPS.AutoSize = false;
            this.lbFPS.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbFPS.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lbFPS.Name = "lbFPS";
            this.lbFPS.Size = new System.Drawing.Size(77, 23);
            this.lbFPS.Text = "0帧/秒";
            // 
            // lbContoursCount
            // 
            this.lbContoursCount.AutoSize = false;
            this.lbContoursCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbContoursCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lbContoursCount.Name = "lbContoursCount";
            this.lbContoursCount.Size = new System.Drawing.Size(120, 23);
            this.lbContoursCount.Text = "总轮廓数：";
            this.lbContoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRecognized
            // 
            this.lbRecognized.AutoSize = false;
            this.lbRecognized.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbRecognized.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lbRecognized.Name = "lbRecognized";
            this.lbRecognized.Size = new System.Drawing.Size(150, 23);
            this.lbRecognized.Text = "已识别轮廓数：";
            this.lbRecognized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmUpdateState
            // 
            this.tmUpdateState.Enabled = true;
            this.tmUpdateState.Interval = 1000;
            this.tmUpdateState.Tick += new System.EventHandler(this.tmUpdateState_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNewTemplates,
            this.btOpenTemplates,
            this.btSaveTemplates,
            this.toolStripSeparator1,
            this.btCreateTemplate,
            this.btAutoGenerate,
            this.btTemplateEditor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1070, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btNewTemplates
            // 
            this.btNewTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNewTemplates.Image = ((System.Drawing.Image)(resources.GetObject("btNewTemplates.Image")));
            this.btNewTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNewTemplates.Name = "btNewTemplates";
            this.btNewTemplates.Size = new System.Drawing.Size(28, 28);
            this.btNewTemplates.Text = "新建模板";
            this.btNewTemplates.Click += new System.EventHandler(this.btNewTemplates_Click);
            // 
            // btOpenTemplates
            // 
            this.btOpenTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOpenTemplates.Image = ((System.Drawing.Image)(resources.GetObject("btOpenTemplates.Image")));
            this.btOpenTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOpenTemplates.Name = "btOpenTemplates";
            this.btOpenTemplates.Size = new System.Drawing.Size(28, 28);
            this.btOpenTemplates.Text = "打开模板";
            this.btOpenTemplates.Click += new System.EventHandler(this.btOpenTemplates_Click);
            // 
            // btSaveTemplates
            // 
            this.btSaveTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSaveTemplates.Image = ((System.Drawing.Image)(resources.GetObject("btSaveTemplates.Image")));
            this.btSaveTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSaveTemplates.Name = "btSaveTemplates";
            this.btSaveTemplates.Size = new System.Drawing.Size(28, 28);
            this.btSaveTemplates.Text = "保存模板";
            this.btSaveTemplates.Click += new System.EventHandler(this.btSaveTemplates_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btCreateTemplate
            // 
            this.btCreateTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCreateTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btCreateTemplate.Image")));
            this.btCreateTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCreateTemplate.Name = "btCreateTemplate";
            this.btCreateTemplate.Size = new System.Drawing.Size(28, 28);
            this.btCreateTemplate.Text = "创建模板";
            this.btCreateTemplate.Click += new System.EventHandler(this.btCreateTemplate_Click);
            // 
            // btAutoGenerate
            // 
            this.btAutoGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAutoGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btAutoGenerate.Image")));
            this.btAutoGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAutoGenerate.Name = "btAutoGenerate";
            this.btAutoGenerate.Size = new System.Drawing.Size(28, 28);
            this.btAutoGenerate.Text = "自动生成模板";
            this.btAutoGenerate.Click += new System.EventHandler(this.btAutoGenerate_Click);
            // 
            // btTemplateEditor
            // 
            this.btTemplateEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btTemplateEditor.Image = ((System.Drawing.Image)(resources.GetObject("btTemplateEditor.Image")));
            this.btTemplateEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTemplateEditor.Name = "btTemplateEditor";
            this.btTemplateEditor.Size = new System.Drawing.Size(28, 28);
            this.btTemplateEditor.Text = "查看模板";
            this.btTemplateEditor.Click += new System.EventHandler(this.btTemplateEditor_Click);
            // 
            // ibMain
            // 
            this.ibMain.Location = new System.Drawing.Point(13, 89);
            this.ibMain.Margin = new System.Windows.Forms.Padding(4);
            this.ibMain.Name = "ibMain";
            this.ibMain.Size = new System.Drawing.Size(735, 560);
            this.ibMain.TabIndex = 2;
            this.ibMain.TabStop = false;
            this.ibMain.Paint += new System.Windows.Forms.PaintEventHandler(this.ibMain_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAdaptiveNoiseFilter);
            this.groupBox1.Controls.Add(this.nudAdaptiveThBlockSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbBlur);
            this.groupBox1.Controls.Add(this.cbAutoContrast);
            this.groupBox1.Controls.Add(this.btLoadImage);
            this.groupBox1.Controls.Add(this.cbCamResolution);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCaptureFromCam);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(276, 202);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "来源";
            // 
            // cbAdaptiveNoiseFilter
            // 
            this.cbAdaptiveNoiseFilter.AutoSize = true;
            this.cbAdaptiveNoiseFilter.Checked = true;
            this.cbAdaptiveNoiseFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAdaptiveNoiseFilter.Location = new System.Drawing.Point(158, 170);
            this.cbAdaptiveNoiseFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbAdaptiveNoiseFilter.Name = "cbAdaptiveNoiseFilter";
            this.cbAdaptiveNoiseFilter.Size = new System.Drawing.Size(106, 22);
            this.cbAdaptiveNoiseFilter.TabIndex = 13;
            this.cbAdaptiveNoiseFilter.Text = "噪点过滤";
            this.cbAdaptiveNoiseFilter.UseVisualStyleBackColor = true;
            this.cbAdaptiveNoiseFilter.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudAdaptiveThBlockSize
            // 
            this.nudAdaptiveThBlockSize.Location = new System.Drawing.Point(16, 169);
            this.nudAdaptiveThBlockSize.Margin = new System.Windows.Forms.Padding(4);
            this.nudAdaptiveThBlockSize.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudAdaptiveThBlockSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdaptiveThBlockSize.Name = "nudAdaptiveThBlockSize";
            this.nudAdaptiveThBlockSize.Size = new System.Drawing.Size(117, 28);
            this.nudAdaptiveThBlockSize.TabIndex = 11;
            this.nudAdaptiveThBlockSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudAdaptiveThBlockSize.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "自适应阈值块大小：";
            // 
            // cbBlur
            // 
            this.cbBlur.AutoSize = true;
            this.cbBlur.Checked = true;
            this.cbBlur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBlur.Location = new System.Drawing.Point(159, 116);
            this.cbBlur.Margin = new System.Windows.Forms.Padding(4);
            this.cbBlur.Name = "cbBlur";
            this.cbBlur.Size = new System.Drawing.Size(88, 22);
            this.cbBlur.TabIndex = 6;
            this.cbBlur.Text = "模糊化";
            this.cbBlur.UseVisualStyleBackColor = true;
            this.cbBlur.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // cbAutoContrast
            // 
            this.cbAutoContrast.AutoSize = true;
            this.cbAutoContrast.Location = new System.Drawing.Point(16, 116);
            this.cbAutoContrast.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutoContrast.Name = "cbAutoContrast";
            this.cbAutoContrast.Size = new System.Drawing.Size(124, 22);
            this.cbAutoContrast.TabIndex = 1;
            this.cbAutoContrast.Text = "自动对比度";
            this.cbAutoContrast.UseVisualStyleBackColor = true;
            this.cbAutoContrast.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // btLoadImage
            // 
            this.btLoadImage.Enabled = false;
            this.btLoadImage.Location = new System.Drawing.Point(158, 53);
            this.btLoadImage.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadImage.Name = "btLoadImage";
            this.btLoadImage.Size = new System.Drawing.Size(102, 48);
            this.btLoadImage.TabIndex = 5;
            this.btLoadImage.Text = "识别图像\r\n…";
            this.btLoadImage.UseVisualStyleBackColor = true;
            this.btLoadImage.Click += new System.EventHandler(this.btLoadImage_Click);
            // 
            // cbCamResolution
            // 
            this.cbCamResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamResolution.FormattingEnabled = true;
            this.cbCamResolution.Items.AddRange(new object[] {
            "800x600",
            "640x480",
            "320x240"});
            this.cbCamResolution.Location = new System.Drawing.Point(16, 71);
            this.cbCamResolution.Margin = new System.Windows.Forms.Padding(4);
            this.cbCamResolution.Name = "cbCamResolution";
            this.cbCamResolution.Size = new System.Drawing.Size(132, 26);
            this.cbCamResolution.TabIndex = 3;
            this.cbCamResolution.TextChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "凸轮分辨率：";
            // 
            // cbCaptureFromCam
            // 
            this.cbCaptureFromCam.AutoSize = true;
            this.cbCaptureFromCam.Checked = true;
            this.cbCaptureFromCam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCaptureFromCam.Location = new System.Drawing.Point(16, 22);
            this.cbCaptureFromCam.Margin = new System.Windows.Forms.Padding(4);
            this.cbCaptureFromCam.Name = "cbCaptureFromCam";
            this.cbCaptureFromCam.Size = new System.Drawing.Size(160, 22);
            this.cbCaptureFromCam.TabIndex = 2;
            this.cbCaptureFromCam.Text = "从摄像头中捕获";
            this.cbCaptureFromCam.UseVisualStyleBackColor = true;
            this.cbCaptureFromCam.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // pnSettings
            // 
            this.pnSettings.AutoScroll = true;
            this.pnSettings.Controls.Add(this.groupBox3);
            this.pnSettings.Controls.Add(this.groupBox2);
            this.pnSettings.Controls.Add(this.cbShowBinarized);
            this.pnSettings.Controls.Add(this.cbShowContours);
            this.pnSettings.Controls.Add(this.cbShowAngle);
            this.pnSettings.Controls.Add(this.groupBox1);
            this.pnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSettings.Location = new System.Drawing.Point(756, 63);
            this.pnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(314, 600);
            this.pnSettings.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAllowAngleMore45);
            this.groupBox3.Controls.Add(this.nudMinICF);
            this.groupBox3.Controls.Add(this.nudMaxACFdesc);
            this.groupBox3.Controls.Add(this.nudMinACF);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(9, 409);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(273, 177);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "识别参数";
            // 
            // cbAllowAngleMore45
            // 
            this.cbAllowAngleMore45.AutoSize = true;
            this.cbAllowAngleMore45.Location = new System.Drawing.Point(10, 145);
            this.cbAllowAngleMore45.Margin = new System.Windows.Forms.Padding(4);
            this.cbAllowAngleMore45.Name = "cbAllowAngleMore45";
            this.cbAllowAngleMore45.Size = new System.Drawing.Size(151, 22);
            this.cbAllowAngleMore45.TabIndex = 6;
            this.cbAllowAngleMore45.Text = "允许角度 > 45";
            this.cbAllowAngleMore45.UseVisualStyleBackColor = true;
            this.cbAllowAngleMore45.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinICF
            // 
            this.nudMinICF.DecimalPlaces = 2;
            this.nudMinICF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMinICF.Location = new System.Drawing.Point(152, 104);
            this.nudMinICF.Margin = new System.Windows.Forms.Padding(4);
            this.nudMinICF.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinICF.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudMinICF.Name = "nudMinICF";
            this.nudMinICF.Size = new System.Drawing.Size(117, 28);
            this.nudMinICF.TabIndex = 13;
            this.nudMinICF.Value = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            this.nudMinICF.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMaxACFdesc
            // 
            this.nudMaxACFdesc.Location = new System.Drawing.Point(9, 50);
            this.nudMaxACFdesc.Margin = new System.Windows.Forms.Padding(4);
            this.nudMaxACFdesc.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMaxACFdesc.Name = "nudMaxACFdesc";
            this.nudMaxACFdesc.Size = new System.Drawing.Size(117, 28);
            this.nudMaxACFdesc.TabIndex = 15;
            this.nudMaxACFdesc.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMaxACFdesc.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinACF
            // 
            this.nudMinACF.DecimalPlaces = 2;
            this.nudMinACF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMinACF.Location = new System.Drawing.Point(9, 104);
            this.nudMinACF.Margin = new System.Windows.Forms.Padding(4);
            this.nudMinACF.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinACF.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudMinACF.Name = "nudMinACF";
            this.nudMinACF.Size = new System.Drawing.Size(117, 28);
            this.nudMinACF.TabIndex = 11;
            this.nudMinACF.Value = new decimal(new int[] {
            96,
            0,
            0,
            131072});
            this.nudMinACF.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Min. ICF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Min. ACF：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Max.ACF描述符的偏差：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNoiseFilter);
            this.groupBox2.Controls.Add(this.nudMinDefinition);
            this.groupBox2.Controls.Add(this.nudMinContourArea);
            this.groupBox2.Controls.Add(this.nudMinContourLength);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(9, 275);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(275, 126);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "轮廓过滤";
            // 
            // cbNoiseFilter
            // 
            this.cbNoiseFilter.AutoSize = true;
            this.cbNoiseFilter.Location = new System.Drawing.Point(9, 89);
            this.cbNoiseFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbNoiseFilter.Name = "cbNoiseFilter";
            this.cbNoiseFilter.Size = new System.Drawing.Size(106, 22);
            this.cbNoiseFilter.TabIndex = 11;
            this.cbNoiseFilter.Text = "噪点过滤";
            this.cbNoiseFilter.UseVisualStyleBackColor = true;
            this.cbNoiseFilter.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinDefinition
            // 
            this.nudMinDefinition.Enabled = false;
            this.nudMinDefinition.Location = new System.Drawing.Point(150, 87);
            this.nudMinDefinition.Margin = new System.Windows.Forms.Padding(4);
            this.nudMinDefinition.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMinDefinition.Name = "nudMinDefinition";
            this.nudMinDefinition.Size = new System.Drawing.Size(117, 28);
            this.nudMinDefinition.TabIndex = 12;
            this.nudMinDefinition.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMinDefinition.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinContourArea
            // 
            this.nudMinContourArea.Location = new System.Drawing.Point(150, 47);
            this.nudMinContourArea.Margin = new System.Windows.Forms.Padding(4);
            this.nudMinContourArea.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudMinContourArea.Name = "nudMinContourArea";
            this.nudMinContourArea.Size = new System.Drawing.Size(117, 28);
            this.nudMinContourArea.TabIndex = 9;
            this.nudMinContourArea.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinContourArea.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinContourLength
            // 
            this.nudMinContourLength.Location = new System.Drawing.Point(8, 47);
            this.nudMinContourLength.Margin = new System.Windows.Forms.Padding(4);
            this.nudMinContourLength.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudMinContourLength.Name = "nudMinContourLength";
            this.nudMinContourLength.Size = new System.Drawing.Size(117, 28);
            this.nudMinContourLength.TabIndex = 7;
            this.nudMinContourLength.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinContourLength.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "最小轮廓面积：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "最小轮廓长度： ";
            // 
            // cbShowBinarized
            // 
            this.cbShowBinarized.AutoSize = true;
            this.cbShowBinarized.Location = new System.Drawing.Point(9, 245);
            this.cbShowBinarized.Margin = new System.Windows.Forms.Padding(4);
            this.cbShowBinarized.Name = "cbShowBinarized";
            this.cbShowBinarized.Size = new System.Drawing.Size(124, 22);
            this.cbShowBinarized.TabIndex = 21;
            this.cbShowBinarized.Text = "显示二值化";
            this.cbShowBinarized.UseVisualStyleBackColor = true;
            // 
            // cbShowContours
            // 
            this.cbShowContours.AutoSize = true;
            this.cbShowContours.Location = new System.Drawing.Point(142, 214);
            this.cbShowContours.Margin = new System.Windows.Forms.Padding(4);
            this.cbShowContours.Name = "cbShowContours";
            this.cbShowContours.Size = new System.Drawing.Size(106, 22);
            this.cbShowContours.TabIndex = 20;
            this.cbShowContours.Text = "显示轮廓";
            this.cbShowContours.UseVisualStyleBackColor = true;
            // 
            // cbShowAngle
            // 
            this.cbShowAngle.AutoSize = true;
            this.cbShowAngle.Location = new System.Drawing.Point(9, 214);
            this.cbShowAngle.Margin = new System.Windows.Forms.Padding(4);
            this.cbShowAngle.Name = "cbShowAngle";
            this.cbShowAngle.Size = new System.Drawing.Size(106, 22);
            this.cbShowAngle.TabIndex = 0;
            this.cbShowAngle.Text = "显示角度";
            this.cbShowAngle.UseVisualStyleBackColor = true;
            this.cbShowAngle.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模板ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 32);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 模板ToolStripMenuItem
            // 
            this.模板ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator2,
            this.创建ToolStripMenuItem,
            this.自动生成ToolStripMenuItem,
            this.查看ToolStripMenuItem});
            this.模板ToolStripMenuItem.Name = "模板ToolStripMenuItem";
            this.模板ToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.模板ToolStripMenuItem.Text = "模板(&F)";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.新建ToolStripMenuItem.Text = "新建(&N)";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.打开ToolStripMenuItem.Text = "打开(&O)";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.保存ToolStripMenuItem.Text = "保存(&L)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(273, 6);
            // 
            // 创建ToolStripMenuItem
            // 
            this.创建ToolStripMenuItem.Name = "创建ToolStripMenuItem";
            this.创建ToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.创建ToolStripMenuItem.Text = "创建(&D)";
            this.创建ToolStripMenuItem.Click += new System.EventHandler(this.创建ToolStripMenuItem_Click);
            // 
            // 自动生成ToolStripMenuItem
            // 
            this.自动生成ToolStripMenuItem.Name = "自动生成ToolStripMenuItem";
            this.自动生成ToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.自动生成ToolStripMenuItem.Text = "自动生成(&G)";
            this.自动生成ToolStripMenuItem.Click += new System.EventHandler(this.自动生成ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.查看ToolStripMenuItem.Text = "查看(&E)";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看使用说明书ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(108, 28);
            this.帮助HToolStripMenuItem.Text = "帮助（&H）";
            // 
            // 查看使用说明书ToolStripMenuItem
            // 
            this.查看使用说明书ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看使用说明书ToolStripMenuItem1,
            this.查看原理说明书ToolStripMenuItem});
            this.查看使用说明书ToolStripMenuItem.Name = "查看使用说明书ToolStripMenuItem";
            this.查看使用说明书ToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.查看使用说明书ToolStripMenuItem.Text = "查看说明书";
            // 
            // 查看使用说明书ToolStripMenuItem1
            // 
            this.查看使用说明书ToolStripMenuItem1.Name = "查看使用说明书ToolStripMenuItem1";
            this.查看使用说明书ToolStripMenuItem1.Size = new System.Drawing.Size(218, 30);
            this.查看使用说明书ToolStripMenuItem1.Text = "查看使用说明书";
            this.查看使用说明书ToolStripMenuItem1.Click += new System.EventHandler(this.查看使用说明书ToolStripMenuItem1_Click);
            // 
            // 查看原理说明书ToolStripMenuItem
            // 
            this.查看原理说明书ToolStripMenuItem.Name = "查看原理说明书ToolStripMenuItem";
            this.查看原理说明书ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.查看原理说明书ToolStripMenuItem.Text = "查看原理说明书";
            this.查看原理说明书ToolStripMenuItem.Click += new System.EventHandler(this.查看原理说明书ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 691);
            this.Controls.Add(this.pnSettings);
            this.Controls.Add(this.ibMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "轮廓分析示例";
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdaptiveThBlockSize)).EndInit();
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinICF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxACFdesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinACF)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDefinition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourLength)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lbFPS;
        private System.Windows.Forms.ToolStripStatusLabel lbContoursCount;
        private System.Windows.Forms.ToolStripStatusLabel lbRecognized;
        private System.Windows.Forms.Timer tmUpdateState;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btNewTemplates;
        private System.Windows.Forms.ToolStripButton btOpenTemplates;
        private System.Windows.Forms.ToolStripButton btSaveTemplates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btCreateTemplate;
        private System.Windows.Forms.ToolStripButton btAutoGenerate;
        private System.Windows.Forms.ToolStripButton btTemplateEditor;
        private Emgu.CV.UI.ImageBox ibMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLoadImage;
        private System.Windows.Forms.ComboBox cbCamResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCaptureFromCam;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.CheckBox cbAdaptiveNoiseFilter;
        private System.Windows.Forms.NumericUpDown nudAdaptiveThBlockSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbBlur;
        private System.Windows.Forms.CheckBox cbAutoContrast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbNoiseFilter;
        private System.Windows.Forms.NumericUpDown nudMinDefinition;
        private System.Windows.Forms.NumericUpDown nudMinContourArea;
        private System.Windows.Forms.NumericUpDown nudMinContourLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbShowBinarized;
        private System.Windows.Forms.CheckBox cbShowContours;
        private System.Windows.Forms.CheckBox cbShowAngle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbAllowAngleMore45;
        private System.Windows.Forms.NumericUpDown nudMinICF;
        private System.Windows.Forms.NumericUpDown nudMaxACFdesc;
        private System.Windows.Forms.NumericUpDown nudMinACF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 模板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 创建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看使用说明书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看使用说明书ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看原理说明书ToolStripMenuItem;
    }
}

