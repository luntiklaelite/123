namespace tovari
{
    partial class sotrForm
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
            this.grid_sotr = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_infoUser = new System.Windows.Forms.Button();
            this.but_infoComp = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sotr)).BeginInit();
            this.SuspendLayout();
            // 
            // but_poisk
            // 
            this.but_poisk.Location = new System.Drawing.Point(232, 414);
            this.but_poisk.Name = "but_poisk";
            this.but_poisk.Size = new System.Drawing.Size(75, 23);
            this.but_poisk.TabIndex = 7;
            this.but_poisk.Text = "Найти";
            this.but_poisk.UseVisualStyleBackColor = true;
            this.but_poisk.Click += new System.EventHandler(this.but_poisk_Click);
            // 
            // poiskFie
            // 
            this.poiskFie.Location = new System.Drawing.Point(12, 417);
            this.poiskFie.Name = "poiskFie";
            this.poiskFie.Size = new System.Drawing.Size(214, 20);
            this.poiskFie.TabIndex = 6;
            // 
            // grid_sotr
            // 
            this.grid_sotr.AllowUserToAddRows = false;
            this.grid_sotr.AllowUserToDeleteRows = false;
            this.grid_sotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sotr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.grid_sotr.Location = new System.Drawing.Point(12, 12);
            this.grid_sotr.MultiSelect = false;
            this.grid_sotr.Name = "grid_sotr";
            this.grid_sotr.ReadOnly = true;
            this.grid_sotr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_sotr.Size = new System.Drawing.Size(446, 386);
            this.grid_sotr.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Логин";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ФИО";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название компании";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // but_infoUser
            // 
            this.but_infoUser.Location = new System.Drawing.Point(313, 414);
            this.but_infoUser.Name = "but_infoUser";
            this.but_infoUser.Size = new System.Drawing.Size(143, 44);
            this.but_infoUser.TabIndex = 8;
            this.but_infoUser.Text = "Информация о пользователе";
            this.but_infoUser.UseVisualStyleBackColor = true;
            this.but_infoUser.Click += new System.EventHandler(this.but_infoUser_Click);
            // 
            // but_infoComp
            // 
            this.but_infoComp.Location = new System.Drawing.Point(315, 464);
            this.but_infoComp.Name = "but_infoComp";
            this.but_infoComp.Size = new System.Drawing.Size(143, 44);
            this.but_infoComp.TabIndex = 9;
            this.but_infoComp.Text = "Информация о компании";
            this.but_infoComp.UseVisualStyleBackColor = true;
            this.but_infoComp.Click += new System.EventHandler(this.but_infoComp_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(12, 464);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 10;
            this.but_add.Text = "Добавить";
            this.but_add.UseVisualStyleBackColor = true;
            // 
            // but_edit
            // 
            this.but_edit.Location = new System.Drawing.Point(93, 464);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(75, 23);
            this.but_edit.TabIndex = 11;
            this.but_edit.Text = "Изменить";
            this.but_edit.UseVisualStyleBackColor = true;
            // 
            // but_del
            // 
            this.but_del.Location = new System.Drawing.Point(174, 464);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(75, 23);
            this.but_del.TabIndex = 12;
            this.but_del.Text = "Удалить";
            this.but_del.UseVisualStyleBackColor = true;
            // 
            // sotrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 517);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_infoComp);
            this.Controls.Add(this.but_infoUser);
            this.Controls.Add(this.but_poisk);
            this.Controls.Add(this.poiskFie);
            this.Controls.Add(this.grid_sotr);
            this.Name = "sotrForm";
            this.Text = "sotrForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_sotr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_poisk;
        private System.Windows.Forms.TextBox poiskFie;
        private System.Windows.Forms.DataGridView grid_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button but_infoUser;
        private System.Windows.Forms.Button but_infoComp;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_del;
    }
}