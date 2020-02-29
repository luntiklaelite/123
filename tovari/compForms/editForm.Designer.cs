namespace tovari.compForms
{
    partial class editForm
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
            this.but_editComp = new System.Windows.Forms.Button();
            this.typeFie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameFie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_editComp
            // 
            this.but_editComp.Location = new System.Drawing.Point(13, 73);
            this.but_editComp.Name = "but_editComp";
            this.but_editComp.Size = new System.Drawing.Size(337, 23);
            this.but_editComp.TabIndex = 9;
            this.but_editComp.Text = "Изменить";
            this.but_editComp.UseVisualStyleBackColor = true;
            this.but_editComp.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeFie
            // 
            this.typeFie.FormattingEnabled = true;
            this.typeFie.Location = new System.Drawing.Point(192, 40);
            this.typeFie.Name = "typeFie";
            this.typeFie.Size = new System.Drawing.Size(158, 21);
            this.typeFie.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип компании";
            // 
            // nameFie
            // 
            this.nameFie.Location = new System.Drawing.Point(192, 12);
            this.nameFie.Name = "nameFie";
            this.nameFie.Size = new System.Drawing.Size(158, 20);
            this.nameFie.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название компании";
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 105);
            this.Controls.Add(this.but_editComp);
            this.Controls.Add(this.typeFie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameFie);
            this.Controls.Add(this.label1);
            this.Name = "editForm";
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_editComp;
        private System.Windows.Forms.ComboBox typeFie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameFie;
        private System.Windows.Forms.Label label1;
    }
}