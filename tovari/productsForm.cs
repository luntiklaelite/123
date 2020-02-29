using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tovari
{
    public partial class productsForm : Form
    {
        public productsForm()
        {
            InitializeComponent();
            if(!reloadGrid(""))
            {
                MessageBox.Show("Ошибка с выполнением запроса к базе данных!");
                return;
            }
            if (dbUsers.localuser.users_role != dbUsers.roles.admin)
            {
                but_prodAdd.Visible = false;
                but_prodDel.Visible = false;
                but_prodEdit.Visible = false;
            }
            if(dbUsers.localuser.users_role == dbUsers.roles.sotr)
            {
                but_prodAdd.Visible = true;
            }
        }

        private bool reloadGrid(string filter)
        {
            grid_products.Rows.Clear();
            List<dbProd> list = new List<dbProd>();
            if (dbProd.select(filter, out list))
            {
                foreach (dbProd prod in list)
                {
                    int r = grid_products.Rows.Add(prod.staff.staff_name, prod.company.company_name, prod.products_price);
                    grid_products.Rows[r].Tag = prod;
                }
                return true;
            }
            return false;
        }


        private void but_poisk_Click(object sender, EventArgs e)
        {
            if(!reloadGrid(poiskFie.Text))
            {
                MessageBox.Show("Ошибка с выполнением запроса к базе данных!");
                return;
            }
        }

        private void but_prodDel_Click(object sender, EventArgs e)
        {
            if (!chGrid.selRows(grid_products))
                return;
            var box = MessageBox.Show("Вы действительно хотите удалить этот продукт?", "", MessageBoxButtons.YesNo);  
            if (box == DialogResult.Yes)
            {
                dbProd prod = (dbProd)grid_products.SelectedRows[0].Tag;
                if (prod.delProd())
                {
                    reloadGrid("");
                    MessageBox.Show("Успешно!");
                    return;
                }
            }
        }

        private void but_prodAdd_Click(object sender, EventArgs e)
        {
            prodForms.addForm form = new prodForms.addForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.Yes)
            {
                reloadGrid("");
                MessageBox.Show("Успешно!");
                return;
            }
        }

        private void but_prodEdit_Click(object sender, EventArgs e)
        {
            if (!chGrid.selRows(grid_products))
                return;
            prodForms.editForm form = new prodForms.editForm((dbProd)grid_products.SelectedRows[0].Tag);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.Yes)
            {
                reloadGrid("");
                MessageBox.Show("Успешно!");
                return;
            }
        }
    }
}
