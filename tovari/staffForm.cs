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
    public partial class staffForm : Form
    {
        public staffForm()
        {
            InitializeComponent();
            reloadGrid("");
            if(dbUsers.localuser.users_role != dbUsers.roles.admin)
            {
                but_staffDel.Visible = false;
                but_staffEdit.Visible = false;
                editFie.Visible = false;
            }
        }

        private void but_staffAdd_Click(object sender, EventArgs e)
        {
            if (addFie.Text == "")
                return;
            if(dbStaff.addStaff(addFie.Text))
            {
                MessageBox.Show("Успешно!");
                addFie.Text = "";
                reloadGrid("");
                return;
            }
            return;
        }

        private bool reloadGrid(string filter)
        {
            grid_staff.Rows.Clear();
            List<dbStaff> list = new List<dbStaff>();
            if (dbStaff.select(filter, out list))
            {
                foreach (dbStaff staff in list)
                {
                    int r = grid_staff.Rows.Add(staff.staff_name);
                    grid_staff.Rows[r].Tag = staff;
                }
                return true;
            }
            return false;
        }

        private void but_staffDel_Click(object sender, EventArgs e)
        {
            if (!chGrid.selRows(grid_staff))
                return;
            var box = MessageBox.Show("Вы действительно хотите удалить эту запись?", "", MessageBoxButtons.YesNo);
            if (box == DialogResult.Yes)
            {
                dbStaff staff = (dbStaff)grid_staff.SelectedRows[0].Tag;
                if (staff.delStaff())
                {
                    reloadGrid("");
                    MessageBox.Show("Успешно!");
                    return;
                }
            }
        }

        private void but_staffEdit_Click(object sender, EventArgs e)
        {
            dbStaff staff = (dbStaff)grid_staff.SelectedRows[0].Tag;
            string edit = editFie.Text;
            if (editFie.Text == "")
                edit = staff.staff_name;
            if (staff.editStaff(edit))
            {
                MessageBox.Show("Успешно!");
                editFie.Text = "";
                reloadGrid("");
                return;
            }
            return;
        }

        private void but_poisk_Click(object sender, EventArgs e)
        {
            reloadGrid(poiskFie.Text);
        }
    }
}
