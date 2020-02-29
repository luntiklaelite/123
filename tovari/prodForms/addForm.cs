using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tovari.prodForms
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
            List<dbStaff> list1 = new List<dbStaff>();
            List<dbSotr> list2 = new List<dbSotr>();
            if (dbStaff.select("", out list1))
            {
                foreach (dbStaff staff in list1)
                {
                    objectFie.Items.Add(staff);
                }
            }
            if (dbSotr.select("", out list2))
            {
                foreach (dbSotr sotr in list2)
                {
                    compFie.Items.Add(sotr.company);
                }
            }
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            double price;
            if (objectFie.SelectedIndex < 0 || compFie.SelectedIndex < 0 || !double.TryParse(priceFie.Text, out price))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (dbProd.addProd((dbStaff)objectFie.SelectedItem, price, (dbCompany)compFie.SelectedItem))
            {               
                DialogResult = DialogResult.Yes;
                return;
            }
            DialogResult = DialogResult.No;
            return;
        }
    }
}
