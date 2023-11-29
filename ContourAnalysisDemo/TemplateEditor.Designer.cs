namespace ContourAnalysisDemo
{
    partial class TemplateEditor
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
            this.dgvTemplates = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPreferredAngle = new System.Windows.Forms.CheckBox();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "模板";
            // 
            // dgvTemplates
            // 
            this.dgvTemplates.AllowUserToAddRows = false;
            this.dgvTemplates.AllowUserToDeleteRows = false;
            this.dgvTemplates.AllowUserToResizeRows = false;
            this.dgvTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTemplates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name1});
            this.dgvTemplates.Location = new System.Drawing.Point(18, 32);
            this.dgvTemplates.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTemplates.Name = "dgvTemplates";
            this.dgvTemplates.RowHeadersVisible = false;
            this.dgvTemplates.RowTemplate.Height = 30;
            this.dgvTemplates.Size = new System.Drawing.Size(390, 339);
            this.dgvTemplates.TabIndex = 0;
            this.dgvTemplates.VirtualMode = true;
            this.dgvTemplates.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvTemplates_CellValueNeeded);
            this.dgvTemplates.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvTemplates_CellValuePushed);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.FillWeight = 1F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Name1
            // 
            this.Name1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            // 
            // cbPreferredAngle
            // 
            this.cbPreferredAngle.AutoSize = true;
            this.cbPreferredAngle.Location = new System.Drawing.Point(434, 348);
            this.cbPreferredAngle.Margin = new System.Windows.Forms.Padding(4);
            this.cbPreferredAngle.Name = "cbPreferredAngle";
            this.cbPreferredAngle.Size = new System.Drawing.Size(187, 22);
            this.cbPreferredAngle.TabIndex = 3;
            this.cbPreferredAngle.Text = "首选角度不超过90 ";
            this.cbPreferredAngle.UseVisualStyleBackColor = true;
            this.cbPreferredAngle.CheckedChanged += new System.EventHandler(this.cbPreferredAngle_CheckedChanged);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(718, 339);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(148, 32);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "删除模板";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // TemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 388);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.cbPreferredAngle);
            this.Controls.Add(this.dgvTemplates);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(898, 419);
            this.Name = "TemplateEditor";
            this.Text = "模板编辑器";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTemplates;
        private System.Windows.Forms.CheckBox cbPreferredAngle;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
    }
}