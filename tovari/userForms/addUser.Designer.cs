namespace tovari.userForms
{
    partial class addUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.but_addUser = new System.Windows.Forms.Button();
            this.loginFie = new System.Windows.Forms.TextBox();
            this.passFie = new System.Windows.Forms.TextBox();
            this.fioFie = new System.Windows.Forms.TextBox();
            this.roleFie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Роль";
            // 
            // but_addUser
            // 
            this.but_addUser.Location = new System.Drawing.Point(6, 155);
            this.but_addUser.Name = "but_addUser";
            this.but_addUser.Size = new System.Drawing.Size(266, 23);
            this.but_addUser.TabIndex = 4;
            this.but_addUser.Text = "Добавить пользователя";
            this.but_addUser.UseVisualStyleBackColor = true;
            this.but_addUser.Click += new System.EventHandler(this.but_addUser_Click);
            // 
            // loginFie
            // 
            this.loginFie.Location = new System.Drawing.Point(100, 13);
            this.loginFie.Name = "loginFie";
            this.loginFie.Size = new System.Drawing.Size(172, 20);
            this.loginFie.TabIndex = 5;
            // 
            // passFie
            // 
            this.passFie.Location = new System.Drawing.Point(100, 49);
            this.passFie.Name = "passFie";
            this.passFie.Size = new System.Drawing.Size(172, 20);
            this.passFie.TabIndex = 6;
            // 
            // fioFie
            // 
            this.fioFie.Location = new System.Drawing.Point(100, 86);
            this.fioFie.Name = "fioFie";
            this.fioFie.Size = new System.Drawing.Size(172, 20);
            this.fioFie.TabIndex = 7;
            // 
            // roleFie
            // 
            this.roleFie.FormattingEnabled = true;
            this.roleFie.Location = new System.Drawing.Point(100, 120);
            this.roleFie.Name = "roleFie";
            this.roleFie.Size = new System.Drawing.Size(172, 21);
            this.roleFie.TabIndex = 8;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.roleFie);
            this.Controls.Add(this.fioFie);
            this.Controls.Add(this.passFie);
            this.Controls.Add(this.loginFie);
            this.Controls.Add(this.but_addUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_addUser;
        private System.Windows.Forms.TextBox loginFie;
        private System.Windows.Forms.TextBox passFie;
        private System.Windows.Forms.TextBox fioFie;
        private System.Windows.Forms.ComboBox roleFie;
    }
}