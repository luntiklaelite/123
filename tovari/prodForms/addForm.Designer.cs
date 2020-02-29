namespace tovari.prodForms
{
    partial class addForm
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
            this.objectFie = new System.Windows.Forms.ComboBox();
            this.compFie = new System.Windows.Forms.ComboBox();
            this.priceFie = new System.Windows.Forms.TextBox();
            this.but_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объект";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Компания";
            // 
            // objectFie
            // 
            this.objectFie.FormattingEnabled = true;
            this.objectFie.Location = new System.Drawing.Point(135, 12);
            this.objectFie.Name = "objectFie";
            this.objectFie.Size = new System.Drawing.Size(244, 21);
            this.objectFie.TabIndex = 3;
            // 
            // compFie
            // 
            this.compFie.FormattingEnabled = true;
            this.compFie.Location = new System.Drawing.Point(135, 88);
            this.compFie.Name = "compFie";
            this.compFie.Size = new System.Drawing.Size(244, 21);
            this.compFie.TabIndex = 4;
            // 
            // priceFie
            // 
            this.priceFie.Location = new System.Drawing.Point(135, 52);
            this.priceFie.Name = "priceFie";
            this.priceFie.Size = new System.Drawing.Size(244, 20);
            this.priceFie.TabIndex = 5;
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(16, 127);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(363, 23);
            this.but_add.TabIndex = 6;
            this.but_add.Text = "Добавить";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 158);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.priceFie);
            this.Controls.Add(this.compFie);
            this.Controls.Add(this.objectFie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addForm";
            this.Text = "addForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox objectFie;
        private System.Windows.Forms.ComboBox compFie;
        private System.Windows.Forms.TextBox priceFie;
        private System.Windows.Forms.Button but_add;
    }
}