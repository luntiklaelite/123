namespace tovari
{
    partial class compForm
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
            this.but_poisk = new System.Windows.Forms.Button();
            this.poiskFie = new System.Windows.Forms.TextBox();
            this.grid_comps = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_compDel = new System.Windows.Forms.Button();
            this.but_compEdit = new System.Windows.Forms.Button();
            this.but_compAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_comps)).BeginInit();
            this.SuspendLayout();
            // 
            // but_poisk
            // 
            this.but_poisk.Location = new System.Drawing.Point(178, 420);
            this.but_poisk.Name = "but_poisk";
            this.but_poisk.Size = new System.Drawing.Size(75, 23);
            this.but_poisk.TabIndex = 5;
            this.but_poisk.Text = "Найти";
            this.but_poisk.UseVisualStyleBackColor = true;
            this.but_poisk.Click += new System.EventHandler(this.but_poisk_Click);
            // 
            // poiskFie
            // 
            this.poiskFie.Location = new System.Drawing.Point(12, 422);
            this.poiskFie.Name = "poiskFie";
            this.poiskFie.Size = new System.Drawing.Size(160, 20);
            this.poiskFie.TabIndex = 4;
            // 
            // grid_comps
            // 
            this.grid_comps.AllowUserToAddRows = false;
            this.grid_comps.AllowUserToDeleteRows = false;
            this.grid_comps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_comps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.grid_comps.Location = new System.Drawing.Point(12, 12);
            this.grid_comps.MultiSelect = false;
            this.grid_comps.Name = "grid_comps";
            this.grid_comps.ReadOnly = true;
            this.grid_comps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_comps.Size = new System.Drawing.Size(475, 402);
            this.grid_comps.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Компания";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Тип";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // but_compDel
            // 
            this.but_compDel.Location = new System.Drawing.Point(421, 420);
            this.but_compDel.Name = "but_compDel";
            this.but_compDel.Size = new System.Drawing.Size(75, 23);
            this.but_compDel.TabIndex = 8;
            this.but_compDel.Text = "Удалить";
            this.but_compDel.UseVisualStyleBackColor = true;
            this.but_compDel.Click += new System.EventHandler(this.but_compDel_Click);
            // 
            // but_compEdit
            // 
            this.but_compEdit.Location = new System.Drawing.Point(340, 420);
            this.but_compEdit.Name = "but_compEdit";
            this.but_compEdit.Size = new System.Drawing.Size(75, 23);
            this.but_compEdit.TabIndex = 7;
            this.but_compEdit.Text = "Изменить";
            this.but_compEdit.UseVisualStyleBackColor = true;
            this.but_compEdit.Click += new System.EventHandler(this.but_compEdit_Click);
            // 
            // but_compAdd
            // 
            this.but_compAdd.Location = new System.Drawing.Point(259, 420);
            this.but_compAdd.Name = "but_compAdd";
            this.but_compAdd.Size = new System.Drawing.Size(75, 23);
            this.but_compAdd.TabIndex = 6;
            this.but_compAdd.Text = "Добавить";
            this.but_compAdd.UseVisualStyleBackColor = true;
            this.but_compAdd.Click += new System.EventHandler(this.but_compAdd_Click);
            // 
            // compForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 448);
            this.Controls.Add(this.but_compDel);
            this.Controls.Add(this.but_compEdit);
            this.Controls.Add(this.but_compAdd);
            this.Controls.Add(this.but_poisk);
            this.Controls.Add(this.poiskFie);
            this.Controls.Add(this.grid_comps);
            this.Name = "compForm";
            this.Text = "Компании";
            ((System.ComponentModel.ISupportInitialize)(this.grid_comps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_poisk;
        private System.Windows.Forms.TextBox poiskFie;
        private System.Windows.Forms.DataGridView grid_comps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button but_compDel;
        private System.Windows.Forms.Button but_compEdit;
        private System.Windows.Forms.Button but_compAdd;
    }
}