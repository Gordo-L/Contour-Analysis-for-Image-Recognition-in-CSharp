namespace ContourAnalysisDemo
{
    partial class HelpForm2
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btclose2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(776, 520);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // btclose2
            // 
            this.btclose2.Location = new System.Drawing.Point(353, 551);
            this.btclose2.Name = "btclose2";
            this.btclose2.Size = new System.Drawing.Size(93, 43);
            this.btclose2.TabIndex = 2;
            this.btclose2.Text = "关闭";
            this.btclose2.UseVisualStyleBackColor = true;
            this.btclose2.Click += new System.EventHandler(this.btclose2_Click);
            // 
            // HelpForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.btclose2);
            this.Controls.Add(this.richTextBox2);
            this.Name = "HelpForm2";
            this.Text = "HelpForm2";
            this.Load += new System.EventHandler(this.HelpForm2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btclose2;
    }
}