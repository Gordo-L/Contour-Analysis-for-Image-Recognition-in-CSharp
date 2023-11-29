namespace ContourAnalysisDemo
{
    partial class ShowContoursForm
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
            this.dgvContours = new System.Windows.Forms.DataGridView();
            this.Contour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTemplateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContours)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContours
            // 
            this.dgvContours.AllowUserToAddRows = false;
            this.dgvContours.AllowUserToDeleteRows = false;
            this.dgvContours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContours.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contour});
            this.dgvContours.Location = new System.Drawing.Point(18, 17);
            this.dgvContours.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContours.Name = "dgvContours";
            this.dgvContours.ReadOnly = true;
            this.dgvContours.RowTemplate.Height = 30;
            this.dgvContours.Size = new System.Drawing.Size(760, 566);
            this.dgvContours.TabIndex = 0;
            this.dgvContours.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvContours_CellPainting);
            // 
            // Contour
            // 
            this.Contour.HeaderText = "Contour";
            this.Contour.Name = "Contour";
            this.Contour.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(27, 594);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "将所选轮廓添加为模板： ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTemplateName
            // 
            this.tbTemplateName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTemplateName.ForeColor = System.Drawing.Color.Gray;
            this.tbTemplateName.Location = new System.Drawing.Point(308, 597);
            this.tbTemplateName.Margin = new System.Windows.Forms.Padding(4);
            this.tbTemplateName.Name = "tbTemplateName";
            this.tbTemplateName.Size = new System.Drawing.Size(169, 28);
            this.tbTemplateName.TabIndex = 1;
            this.tbTemplateName.Text = "<模板名称>";
            this.tbTemplateName.Enter += new System.EventHandler(this.tbTemplateName_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(489, 597);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入模板名称或图像文件名称(*.png, *.jpg)";
            // 
            // ShowContoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTemplateName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvContours);
            this.Name = "ShowContoursForm";
            this.Text = "模板创建器";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTemplateName;
        private System.Windows.Forms.Label label2;
    }
}