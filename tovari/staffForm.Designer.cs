namespace tovari
{
    partial class staffForm
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
            this.grid_staff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_poisk = new System.Windows.Forms.Button();
            this.poiskFie = new System.Windows.Forms.TextBox();
            this.but_staffDel = new System.Windows.Forms.Button();
            this.but_staffEdit = new System.Windows.Forms.Button();
            this.but_staffAdd = new System.Windows.Forms.Button();
            this.addFie = new System.Windows.Forms.TextBox();
            this.editFie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_staff
            // 
            this.grid_staff.AllowUserToAddRows = false;
            this.grid_staff.AllowUserToDeleteRows = false;
            this.grid_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grid_staff.Location = new System.Drawing.Point(12, 12);
            this.grid_staff.MultiSelect = false;
            this.grid_staff.Name = "grid_staff";
            this.grid_staff.ReadOnly = true;
            this.grid_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_staff.Size = new System.Drawing.Size(295, 386);
            this.grid_staff.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // but_poisk
            // 
            this.but_poisk.Location = new System.Drawing.Point(232, 414);
            this.but_poisk.Name = "but_poisk";
            this.but_poisk.Size = new System.Drawing.Size(75, 23);
            this.but_poisk.TabIndex = 4;
            this.but_poisk.Text = "Найти";
            this.but_poisk.UseVisualStyleBackColor = true;
            this.but_poisk.Click += new System.EventHandler(this.but_poisk_Click);
            // 
            // poiskFie
            // 
            this.poiskFie.Location = new System.Drawing.Point(12, 417);
            this.poiskFie.Name = "poiskFie";
            this.poiskFie.Size = new System.Drawing.Size(214, 20);
            this.poiskFie.TabIndex = 3;
            // 
            // but_staffDel
            // 
            this.but_staffDel.Location = new System.Drawing.Point(232, 501);
            this.but_staffDel.Name = "but_staffDel";
            this.but_staffDel.Size = new System.Drawing.Size(75, 23);
            this.but_staffDel.TabIndex = 8;
            this.but_staffDel.Text = "Удалить";
            this.but_staffDel.UseVisualStyleBackColor = true;
            this.but_staffDel.Click += new System.EventHandler(this.but_staffDel_Click);
            // 
            // but_staffEdit
            // 
            this.but_staffEdit.Location = new System.Drawing.Point(232, 472);
            this.but_staffEdit.Name = "but_staffEdit";
            this.but_staffEdit.Size = new System.Drawing.Size(75, 23);
            this.but_staffEdit.TabIndex = 7;
            this.but_staffEdit.Text = "Изменить";
            this.but_staffEdit.UseVisualStyleBackColor = true;
            this.but_staffEdit.Click += new System.EventHandler(this.but_staffEdit_Click);
            // 
            // but_staffAdd
            // 
            this.but_staffAdd.Location = new System.Drawing.Point(232, 443);
            this.but_staffAdd.Name = "but_staffAdd";
            this.but_staffAdd.Size = new System.Drawing.Size(75, 23);
            this.but_staffAdd.TabIndex = 6;
            this.but_staffAdd.Text = "Добавить";
            this.but_staffAdd.UseVisualStyleBackColor = true;
            this.but_staffAdd.Click += new System.EventHandler(this.but_staffAdd_Click);
            // 
            // addFie
            // 
            this.addFie.Location = new System.Drawing.Point(12, 447);
            this.addFie.Name = "addFie";
            this.addFie.Size = new System.Drawing.Size(214, 20);
            this.addFie.TabIndex = 9;
            // 
            // editFie
            // 
            this.editFie.Location = new System.Drawing.Point(12, 476);
            this.editFie.Name = "editFie";
            this.editFie.Size = new System.Drawing.Size(214, 20);
            this.editFie.TabIndex = 10;
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 546);
            this.Controls.Add(this.editFie);
            this.Controls.Add(this.addFie);
            this.Controls.Add(this.but_staffDel);
            this.Controls.Add(this.but_staffEdit);
            this.Controls.Add(this.but_staffAdd);
            this.Controls.Add(this.but_poisk);
            this.Controls.Add(this.poiskFie);
            this.Controls.Add(this.grid_staff);
            this.Name = "staffForm";
            this.Text = "staffForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button but_poisk;
        private System.Windows.Forms.TextBox poiskFie;
        private System.Windows.Forms.Button but_staffDel;
        private System.Windows.Forms.Button but_staffEdit;
        private System.Windows.Forms.Button but_staffAdd;
        private System.Windows.Forms.TextBox addFie;
        private System.Windows.Forms.TextBox editFie;
    }
}