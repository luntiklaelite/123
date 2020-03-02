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
    public partial class editForm : Form
    {
        dbProd prod;
        public editForm(dbProd prod)
        {
            InitializeComponent();
            this.prod = prod;
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

        private void but_edit_Click(object sender, EventArgs e)
        {
            double pric = prod.products_price;
            double pricee;
            dbStaff staffs = prod.staff;
            dbCompany comp = prod.company;
            if (!(objectFie.SelectedIndex < 0))
                staffs = (dbStaff)objectFie.SelectedItem;
            if (!(compFie.SelectedIndex < 0))
                comp = (dbCompany)compFie.SelectedItem;
            if (double.TryParse(priceFie.Text, out pricee))
                pric = pricee;
            if (prod.editProd(staffs, pric, comp))
            {
                DialogResult = DialogResult.Yes;
                return;
            }
            DialogResult = DialogResult.No;
            return;
        }
    }
}
