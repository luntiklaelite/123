namespace tovari
{
    partial class usersForm
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
            this.grid_users = new System.Windows.Forms.DataGridView();
            this.but_poisk = new System.Windows.Forms.Button();
            this.poiskFie = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_delUser = new System.Windows.Forms.Button();
            this.but_editUser = new System.Windows.Forms.Button();
            this.but_addUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_users
            // 
            this.grid_users.AllowUserToAddRows = false;
            this.grid_users.AllowUserToDeleteRows = false;
            this.grid_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grid_users.Location = new System.Drawing.Point(12, 12);
            this.grid_users.MultiSelect = false;
            this.grid_users.Name = "grid_users";
            this.grid_users.ReadOnly = true;
            this.grid_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_users.Size = new System.Drawing.Size(520, 427);
            this.grid_users.TabIndex = 0;
            // 
            // but_poisk
            // 
            this.but_poisk.Location = new System.Drawing.Point(178, 448);
            this.but_poisk.Name = "but_poisk";
            this.but_poisk.Size = new System.Drawing.Size(75, 25);
            this.but_poisk.TabIndex = 4;
            this.but_poisk.Text = "Найти";
            this.but_poisk.UseVisualStyleBackColor = true;
            this.but_poisk.Click += new System.EventHandler(this.but_poisk_Click);
            // 
            // poiskFie
            // 
            this.poiskFie.Location = new System.Drawing.Point(12, 450);
            this.poiskFie.Name = "poiskFie";
            this.poiskFie.Size = new System.Drawing.Size(160, 20);
            this.poiskFie.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Логин";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Роль";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // but_delUser
            // 
            this.but_delUser.Location = new System.Drawing.Point(457, 448);
            this.but_delUser.Name = "but_delUser";
            this.but_delUser.Size = new System.Drawing.Size(75, 25);
            this.but_delUser.TabIndex = 5;
            this.but_delUser.Text = "Удалить";
            this.but_delUser.UseVisualStyleBackColor = true;
            this.but_delUser.Click += new System.EventHandler(this.but_delUser_Click);
            // 
            // but_editUser
            // 
            this.but_editUser.Location = new System.Drawing.Point(358, 448);
            this.but_editUser.Name = "but_editUser";
            this.but_editUser.Size = new System.Drawing.Size(93, 25);
            this.but_editUser.TabIndex = 6;
            this.but_editUser.Text = "Редактировать";
            this.but_editUser.UseVisualStyleBackColor = true;
            this.but_editUser.Click += new System.EventHandler(this.but_editUser_Click);
            // 
            // but_addUser
            // 
            this.but_addUser.Location = new System.Drawing.Point(259, 448);
            this.but_addUser.Name = "but_addUser";
            this.but_addUser.Size = new System.Drawing.Size(93, 25);
            this.but_addUser.TabIndex = 7;
            this.but_addUser.Text = "Добавить";
            this.but_addUser.UseVisualStyleBackColor = true;
            this.but_addUser.Click += new System.EventHandler(this.but_addUser_Click);
            // 
            // usersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 482);
            this.Controls.Add(this.but_addUser);
            this.Controls.Add(this.but_editUser);
            this.Controls.Add(this.but_delUser);
            this.Controls.Add(this.but_poisk);
            this.Controls.Add(this.poiskFie);
            this.Controls.Add(this.grid_users);
            this.Name = "usersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление пользователями";
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_users;
        private System.Windows.Forms.Button but_poisk;
        private System.Windows.Forms.TextBox poiskFie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button but_delUser;
        private System.Windows.Forms.Button but_editUser;
        private System.Windows.Forms.Button but_addUser;
    }
}