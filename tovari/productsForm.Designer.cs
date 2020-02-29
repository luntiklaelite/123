namespace tovari
{
    partial class productsForm
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
            this.grid_products = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poiskFie = new System.Windows.Forms.TextBox();
            this.but_poisk = new System.Windows.Forms.Button();
            this.but_prodAdd = new System.Windows.Forms.Button();
            this.but_prodEdit = new System.Windows.Forms.Button();
            this.but_prodDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_products
            // 
            this.grid_products.AllowUserToAddRows = false;
            this.grid_products.AllowUserToDeleteRows = false;
            this.grid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grid_products.Location = new System.Drawing.Point(12, 12);
            this.grid_products.MultiSelect = false;
            this.grid_products.Name = "grid_products";
            this.grid_products.ReadOnly = true;
            this.grid_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_products.Size = new System.Drawing.Size(484, 423);
            this.grid_products.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Товар";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Компания";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // poiskFie
            // 
            this.poiskFie.Location = new System.Drawing.Point(12, 443);
            this.poiskFie.Name = "poiskFie";
            this.poiskFie.Size = new System.Drawing.Size(160, 20);
            this.poiskFie.TabIndex = 1;
            // 
            // but_poisk
            // 
            this.but_poisk.Location = new System.Drawing.Point(178, 441);
            this.but_poisk.Name = "but_poisk";
            this.but_poisk.Size = new System.Drawing.Size(75, 23);
            this.but_poisk.TabIndex = 2;
            this.but_poisk.Text = "Найти";
            this.but_poisk.UseVisualStyleBackColor = true;
            this.but_poisk.Click += new System.EventHandler(this.but_poisk_Click);
            // 
            // but_prodAdd
            // 
            this.but_prodAdd.Location = new System.Drawing.Point(259, 441);
            this.but_prodAdd.Name = "but_prodAdd";
            this.but_prodAdd.Size = new System.Drawing.Size(75, 23);
            this.but_prodAdd.TabIndex = 3;
            this.but_prodAdd.Text = "Добавить";
            this.but_prodAdd.UseVisualStyleBackColor = true;
            this.but_prodAdd.Click += new System.EventHandler(this.but_prodAdd_Click);
            // 
            // but_prodEdit
            // 
            this.but_prodEdit.Location = new System.Drawing.Point(340, 441);
            this.but_prodEdit.Name = "but_prodEdit";
            this.but_prodEdit.Size = new System.Drawing.Size(75, 23);
            this.but_prodEdit.TabIndex = 4;
            this.but_prodEdit.Text = "Изменить";
            this.but_prodEdit.UseVisualStyleBackColor = true;
            this.but_prodEdit.Click += new System.EventHandler(this.but_prodEdit_Click);
            // 
            // but_prodDel
            // 
            this.but_prodDel.Location = new System.Drawing.Point(421, 441);
            this.but_prodDel.Name = "but_prodDel";
            this.but_prodDel.Size = new System.Drawing.Size(75, 23);
            this.but_prodDel.TabIndex = 5;
            this.but_prodDel.Text = "Удалить";
            this.but_prodDel.UseVisualStyleBackColor = true;
            this.but_prodDel.Click += new System.EventHandler(this.but_prodDel_Click);
            // 
            // productsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 472);
            this.Controls.Add(this.but_prodDel);
            this.Controls.Add(this.but_prodEdit);
            this.Controls.Add(this.but_prodAdd);
            this.Controls.Add(this.but_poisk);
            this.Controls.Add(this.poiskFie);
            this.Controls.Add(this.grid_products);
            this.Name = "productsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productsForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox poiskFie;
        private System.Windows.Forms.Button but_poisk;
        private System.Windows.Forms.Button but_prodAdd;
        private System.Windows.Forms.Button but_prodEdit;
        private System.Windows.Forms.Button but_prodDel;
    }
}