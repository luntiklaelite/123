namespace tovari
{
    partial class mainForm
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
            this.label_priv = new System.Windows.Forms.Label();
            this.but_logout = new System.Windows.Forms.Button();
            this.but_goProducts = new System.Windows.Forms.Button();
            this.but_goCompanies = new System.Windows.Forms.Button();
            this.but_goUsers = new System.Windows.Forms.Button();
            this.but_goStaff = new System.Windows.Forms.Button();
            this.but_goSotr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_priv
            // 
            this.label_priv.AutoSize = true;
            this.label_priv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_priv.Location = new System.Drawing.Point(12, 9);
            this.label_priv.Name = "label_priv";
            this.label_priv.Size = new System.Drawing.Size(211, 72);
            this.label_priv.TabIndex = 0;
            this.label_priv.Text = "Здравствуйте,\r\n\r\nВаша роль в системе: ";
            // 
            // but_logout
            // 
            this.but_logout.Location = new System.Drawing.Point(391, 0);
            this.but_logout.Name = "but_logout";
            this.but_logout.Size = new System.Drawing.Size(75, 38);
            this.but_logout.TabIndex = 1;
            this.but_logout.Text = "Выйти из аккаунта";
            this.but_logout.UseVisualStyleBackColor = true;
            this.but_logout.Click += new System.EventHandler(this.but_logout_Click);
            // 
            // but_goProducts
            // 
            this.but_goProducts.Location = new System.Drawing.Point(19, 96);
            this.but_goProducts.Name = "but_goProducts";
            this.but_goProducts.Size = new System.Drawing.Size(435, 23);
            this.but_goProducts.TabIndex = 2;
            this.but_goProducts.Text = "Список товаров";
            this.but_goProducts.UseVisualStyleBackColor = true;
            this.but_goProducts.Click += new System.EventHandler(this.but_goProducts_Click);
            // 
            // but_goCompanies
            // 
            this.but_goCompanies.Location = new System.Drawing.Point(19, 125);
            this.but_goCompanies.Name = "but_goCompanies";
            this.but_goCompanies.Size = new System.Drawing.Size(435, 23);
            this.but_goCompanies.TabIndex = 3;
            this.but_goCompanies.Text = "Список компаний";
            this.but_goCompanies.UseVisualStyleBackColor = true;
            this.but_goCompanies.Click += new System.EventHandler(this.but_goCompanies_Click);
            // 
            // but_goUsers
            // 
            this.but_goUsers.Location = new System.Drawing.Point(19, 212);
            this.but_goUsers.Name = "but_goUsers";
            this.but_goUsers.Size = new System.Drawing.Size(435, 23);
            this.but_goUsers.TabIndex = 4;
            this.but_goUsers.Text = "Список пользователей";
            this.but_goUsers.UseVisualStyleBackColor = true;
            this.but_goUsers.Click += new System.EventHandler(this.but_goUsers_Click);
            // 
            // but_goStaff
            // 
            this.but_goStaff.Location = new System.Drawing.Point(19, 183);
            this.but_goStaff.Name = "but_goStaff";
            this.but_goStaff.Size = new System.Drawing.Size(435, 23);
            this.but_goStaff.TabIndex = 5;
            this.but_goStaff.Text = "Список названий товаров";
            this.but_goStaff.UseVisualStyleBackColor = true;
            this.but_goStaff.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_goSotr
            // 
            this.but_goSotr.Location = new System.Drawing.Point(19, 154);
            this.but_goSotr.Name = "but_goSotr";
            this.but_goSotr.Size = new System.Drawing.Size(435, 23);
            this.but_goSotr.TabIndex = 6;
            this.but_goSotr.Text = "Список сотрудников";
            this.but_goSotr.UseVisualStyleBackColor = true;
            this.but_goSotr.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(435, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Управление сотрудниками";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_goSotr);
            this.Controls.Add(this.but_goStaff);
            this.Controls.Add(this.but_goUsers);
            this.Controls.Add(this.but_goCompanies);
            this.Controls.Add(this.but_goProducts);
            this.Controls.Add(this.but_logout);
            this.Controls.Add(this.label_priv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_priv;
        private System.Windows.Forms.Button but_logout;
        private System.Windows.Forms.Button but_goProducts;
        private System.Windows.Forms.Button but_goCompanies;
        private System.Windows.Forms.Button but_goUsers;
        private System.Windows.Forms.Button but_goStaff;
        private System.Windows.Forms.Button but_goSotr;
        private System.Windows.Forms.Button button1;
    }
}