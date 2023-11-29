namespace ContourAnalysisDemo
{
    partial class AutoGenerateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btFont = new System.Windows.Forms.Button();
            this.tbFont = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbChars = new System.Windows.Forms.TextBox();
            this.cbAntipattern = new System.Windows.Forms.CheckBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "字体";
            // 
            // btFont
            // 
            this.btFont.Location = new System.Drawing.Point(332, 32);
            this.btFont.Margin = new System.Windows.Forms.Padding(4);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(76, 32);
            this.btFont.TabIndex = 3;
            this.btFont.Text = "字体…";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // tbFont
            // 
            this.tbFont.Location = new System.Drawing.Point(16, 36);
            this.tbFont.Margin = new System.Windows.Forms.Padding(4);
            this.tbFont.Name = "tbFont";
            this.tbFont.ReadOnly = true;
            this.tbFont.Size = new System.Drawing.Size(304, 28);
            this.tbFont.TabIndex = 0;
            this.tbFont.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "字符";
            // 
            // tbChars
            // 
            this.tbChars.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbChars.Location = new System.Drawing.Point(16, 98);
            this.tbChars.Margin = new System.Windows.Forms.Padding(4);
            this.tbChars.Multiline = true;
            this.tbChars.Name = "tbChars";
            this.tbChars.Size = new System.Drawing.Size(384, 111);
            this.tbChars.TabIndex = 2;
            this.tbChars.Text = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // cbAntipattern
            // 
            this.cbAntipattern.AutoSize = true;
            this.cbAntipattern.Location = new System.Drawing.Point(18, 219);
            this.cbAntipattern.Margin = new System.Windows.Forms.Padding(4);
            this.cbAntipattern.Name = "cbAntipattern";
            this.cbAntipattern.Size = new System.Drawing.Size(160, 22);
            this.cbAntipattern.TabIndex = 6;
            this.cbAntipattern.Text = "同时生成反模式";
            this.cbAntipattern.UseVisualStyleBackColor = true;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(170, 251);
            this.btGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(232, 32);
            this.btGenerate.TabIndex = 5;
            this.btGenerate.Text = "生成模板";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // AutoGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 300);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.cbAntipattern);
            this.Controls.Add(this.tbChars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFont);
            this.Controls.Add(this.btFont);
            this.Controls.Add(this.label1);
            this.Name = "AutoGenerateForm";
            this.Text = "模板自动生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.TextBox tbFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbChars;
        private System.Windows.Forms.CheckBox cbAntipattern;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}