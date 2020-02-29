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
    public partial class sotrForm : Form
    {
        public sotrForm()
        {
            InitializeComponent();
            reloadGrid("");
        }
        private bool reloadGrid(string filter)
        {
            grid_sotr.Rows.Clear();
            List<dbSotr> list = new List<dbSotr>();
            if (dbSotr.select(filter, out list))
            {
                foreach (dbSotr sotr in list)
                {
                    int r = grid_sotr.Rows.Add(sotr.users.users_login,sotr.users.users_fio, sotr.company.company_name);
                    grid_sotr.Rows[r].Tag = sotr;
                }
                return true;
            }
            return false;
        }

        private void but_poisk_Click(object sender, EventArgs e)
        {
            reloadGrid(poiskFie.Text);
        }

        private void but_infoUser_Click(object sender, EventArgs e)
        {
            if (!chGrid.selRows(grid_sotr))
                return;
            dbSotr sotr = (dbSotr)grid_sotr.SelectedRows[0].Tag;
            MessageBox.Show("Логин: " + sotr.users.users_login + "\nФио: " + sotr.users.users_fio + "\nРоль: " + dbUsers.getRoleName(sotr.users.users_role));
        }

        private void but_infoComp_Click(object sender, EventArgs e)
        {
            if (!chGrid.selRows(grid_sotr))
                return;
            dbSotr sotr = (dbSotr)grid_sotr.SelectedRows[0].Tag;
            MessageBox.Show("Название компании: " + sotr.company.company_name + "\nТип: " + sotr.company.company_type);
        }
    }
}
