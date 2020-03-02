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
    public partial class uprSotrForm : Form
    {
        private bool selCell = false;
        dbCompany selcomp;
        dbSotr selsotr;
        public uprSotrForm()
        {
            InitializeComponent();
            reloadGrid("");
        }
        private bool reloadGrid(string filter)
        {
            grid_sotr.Rows.Clear();
            grid_sotr.Columns.Clear();
            grid_sotr.Columns.Add("Column1", "Логин");
            Column1.HeaderText = "Логин";
            Column1.ReadOnly = true;
            List<dbCompany> list1 = new List<dbCompany>();
            if (dbCompany.select("", out list1))
            {
                foreach (dbCompany comp in list1)
                {
                    int d = grid_sotr.Columns.Add("comp", comp.company_name);
                    grid_sotr.Columns[d].Name = "Comp" + d;
                    grid_sotr.Columns[d].Tag = comp;
                }
            }
            List<dbSotr> list = new List<dbSotr>();
            if (dbSotr.select(filter, out list))
            {
                foreach (dbSotr sotr in list)
                {
                    int r = grid_sotr.Rows.Add(sotr.users.users_login);
                    for (int i = 1; i < grid_sotr.Columns.Count; i++)
                    {
                        dbCompany comp = (dbCompany)grid_sotr.Columns[i].Tag;
                        if(comp.company_name == sotr.company.company_name)
                            grid_sotr.Rows[r].Cells[i].Value = "+++++";
                    }
                    grid_sotr.Rows[r].Tag = sotr;
                }
                return true;
            }
            return false;
        }

        private void grid_sotr_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > grid_sotr.Columns.Count - 1 || e.ColumnIndex <= 0 || e.RowIndex > grid_sotr.Rows.Count -1 || e.RowIndex < 0)
            {
                selCell = false;
                return;
            }
            selsotr = (dbSotr)grid_sotr.Rows[e.RowIndex].Tag;
            selCell = true;
        }

        private void grid_sotr_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > grid_sotr.Columns.Count - 1 || e.ColumnIndex <= 0 || e.RowIndex > grid_sotr.Rows.Count - 1 || e.RowIndex < 0)
            {
                selCell = false;
                return;
            }
            selcomp = (dbCompany)grid_sotr.Columns[e.ColumnIndex].Tag;
            selsotr.editSotr(selcomp, selsotr.users);
            reloadGrid("");
        }

    }
}
