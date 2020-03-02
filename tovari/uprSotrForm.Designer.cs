namespace tovari
{
    partial class uprSotrForm
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
            this.grid_sotr = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sotr)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_sotr
            // 
            this.grid_sotr.AllowUserToAddRows = false;
            this.grid_sotr.AllowUserToDeleteRows = false;
            this.grid_sotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sotr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grid_sotr.Location = new System.Drawing.Point(12, 12);
            this.grid_sotr.MultiSelect = false;
            this.grid_sotr.Name = "grid_sotr";
            this.grid_sotr.ReadOnly = true;
            this.grid_sotr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_sotr.Size = new System.Drawing.Size(446, 386);
            this.grid_sotr.TabIndex = 6;
            this.grid_sotr.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_sotr_CellMouseDown);
            this.grid_sotr.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_sotr_CellMouseUp);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Логин";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // uprSotrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 444);
            this.Controls.Add(this.grid_sotr);
            this.Name = "uprSotrForm";
            this.Text = "uprSotrForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_sotr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}