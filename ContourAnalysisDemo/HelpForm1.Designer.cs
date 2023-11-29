namespace ContourAnalysisDemo
{
    partial class HelpForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btclose1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 520);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btclose1
            // 
            this.btclose1.Location = new System.Drawing.Point(353, 551);
            this.btclose1.Name = "btclose1";
            this.btclose1.Size = new System.Drawing.Size(93, 43);
            this.btclose1.TabIndex = 1;
            this.btclose1.Text = "关闭";
            this.btclose1.UseVisualStyleBackColor = true;
            this.btclose1.Click += new System.EventHandler(this.btclose1_Click);
            // 
            // HelpForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.btclose1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "HelpForm1";
            this.Text = "使用说明书";
            this.Load += new System.EventHandler(this.HelpForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btclose1;
    }
}