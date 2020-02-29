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
    public partial class usersForm : Form
    {
        public usersForm()
        {
            InitializeComponent();
            if(!reloadGrid("")) 
            {
                MessageBox.Show("Ошибка с выполнением запроса к базе данных!");
                return;
            }
        }

        private bool reloadGrid(string filter)
        {
            grid_users.Rows.Clear();
            List<dbUsers> list = new List<dbUsers>();
            if (dbUsers.select(filter, out list))
            {
                foreach (dbUsers user in list)
                {
                    int r = grid_users.Rows.Add(user.users_login, user.users_fio, dbUsers.getRoleName(user.users_role));
                    grid_users.Rows[r].Tag = user;
                }
                return true;
            }
            return false;
        }

        private void but_poisk_Click(object sender, EventArgs e)
        {
            if (!reloadGrid(poiskFie.Text))
            {
                MessageBox.Show("Ошибка с выполнением запроса к базе данных!");
                return;
            }
        }

        private void but_addUser_Click(object sender, EventArgs e)
        {
            userForms.addUser form = new userForms.addUser();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.Yes)
            {
                form.Hide();
                reloadGrid("");
                return;
            }
            return;
        }

        private void but_editUser_Click(object sender, EventArgs e)
        {
            if (!chGrid.selRows(grid_users))
                return;
            userForms.editUser form = new userForms.editUser((dbUsers)grid_users.SelectedRows[0].Tag);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Yes)
            {
                form.Hide();
                reloadGrid("");
                return;
            }
            return;
        }

        private void but_delUser_Click(object sender, EventArgs e)
        {
            if (!chGrid.selRows(grid_users))
                return;
            var box = MessageBox.Show("Вы действительно хотите удалить этого пользователя?", "", MessageBoxButtons.YesNo);
            if (box == DialogResult.Yes)
            {
                dbUsers user = (dbUsers)grid_users.SelectedRows[0].Tag;
                if(user.delUser())
                {
                    reloadGrid("");
                    MessageBox.Show("Успешно!");
                    return;
                }
            }
            
        }
    }
}
