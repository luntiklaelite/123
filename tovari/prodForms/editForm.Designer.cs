namespace tovari.prodForms
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
            this.but_edit = new System.Windows.Forms.Button();
            this.priceFie = new System.Windows.Forms.TextBox();
            this.compFie = new System.Windows.Forms.ComboBox();
            this.objectFie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_edit
            // 
            this.but_edit.Location = new System.Drawing.Point(12, 127);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(363, 23);
            this.but_edit.TabIndex = 13;
            this.but_edit.Text = "Изменить";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // priceFie
            // 
            this.priceFie.Location = new System.Drawing.Point(131, 52);
            this.priceFie.Name = "priceFie";
            this.priceFie.Size = new System.Drawing.Size(244, 20);
            this.priceFie.TabIndex = 12;
            // 
            // compFie
            // 
            this.compFie.FormattingEnabled = true;
            this.compFie.Location = new System.Drawing.Point(131, 88);
            this.compFie.Name = "compFie";
            this.compFie.Size = new System.Drawing.Size(244, 21);
            this.compFie.TabIndex = 11;
            // 
            // objectFie
            // 
            this.objectFie.FormattingEnabled = true;
            this.objectFie.Location = new System.Drawing.Point(131, 12);
            this.objectFie.Name = "objectFie";
            this.objectFie.Size = new System.Drawing.Size(244, 21);
            this.objectFie.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Компания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Объект";
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 158);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.priceFie);
            this.Controls.Add(this.compFie);
            this.Controls.Add(this.objectFie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editForm";
            this.Text = "editForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.TextBox priceFie;
        private System.Windows.Forms.ComboBox compFie;
        private System.Windows.Forms.ComboBox objectFie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}