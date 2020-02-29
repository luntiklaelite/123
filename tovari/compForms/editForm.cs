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
    public partial class editForm : Form
    {
        dbCompany comp;
        public editForm(dbCompany comp)
        {
            InitializeComponent();
            typeFie.Items.Add(dbCompany.type.common);
            typeFie.Items.Add(dbCompany.type.expensive);
            typeFie.Items.Add(dbCompany.type.vip);
            nameFie.Text = comp.company_name;
            typeFie.SelectedIndex = (int)comp.company_type;
            this.comp = comp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameFie.Text != "")
                comp.company_name = nameFie.Text;
            if (typeFie.SelectedIndex >= 0)
                comp.company_type = (dbCompany.type)typeFie.SelectedIndex;
            if (comp.editComp(comp.company_name, (int)comp.company_type))
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
