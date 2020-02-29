using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tovari.compForms
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
            typeFie.Items.Add(dbCompany.type.common);
            typeFie.Items.Add(dbCompany.type.expensive);
            typeFie.Items.Add(dbCompany.type.vip);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (typeFie.SelectedIndex < 0 || nameFie.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (dbCompany.addComp(nameFie.Text, typeFie.SelectedIndex))
            {
                MessageBox.Show("Успешно!");
                DialogResult = DialogResult.Yes;
                return;
            }
            DialogResult = DialogResult.No;
            return;
        }
    }
}
