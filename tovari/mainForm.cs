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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            label_priv.Text = "Здравствуйте,\n" + dbUsers.localuser.users_fio + "\nВаша роль в системе: " + dbUsers.getRoleName(dbUsers.localuser.users_role);
            if(dbUsers.localuser.users_role != dbUsers.roles.admin) 
            {
                but_goUsers.Visible = false;
                if(dbUsers.localuser.users_role != dbUsers.roles.sotr)
                {
                    but_goStaff.Visible = false;
                    but_goSotr.Visible = false;
                }
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void but_logout_Click(object sender, EventArgs e)
        {
            Hide();
            dbUsers.localuser = null;
            dbSotr.localSotr = null;
            loginForm form = new loginForm();
            form.Show();
            return;
        }

        private void but_goProducts_Click(object sender, EventArgs e)
        {
            productsForm form = new productsForm();
            form.Show();
        }

        private void but_goUsers_Click(object sender, EventArgs e)
        {
            usersForm form = new usersForm();
            form.Show();
        }

        private void but_goCompanies_Click(object sender, EventArgs e)
        {
            compForm form = new compForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staffForm form = new staffForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sotrForm form = new sotrForm();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            uprSotrForm form = new uprSotrForm();
            form.Show();
        }
    }
}
