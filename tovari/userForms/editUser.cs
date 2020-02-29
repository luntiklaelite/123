using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tovari.userForms
{
    public partial class editUser : Form
    {
        dbUsers user;
        public editUser(dbUsers user)
        {
            InitializeComponent();
            roleFie.Items.Add(dbUsers.getRoleName(dbUsers.roles.admin));
            roleFie.Items.Add(dbUsers.getRoleName(dbUsers.roles.user));
            roleFie.Items.Add(dbUsers.getRoleName(dbUsers.roles.sotr));
            loginFie.Text = user.users_login;
            fioFie.Text = user.users_fio;
            roleFie.SelectedIndex = (int)user.users_role;
            this.user = user;
        }

        private void but_editUser_Click(object sender, EventArgs e)
        {
            if (loginFie.Text != "")
                user.users_login = loginFie.Text;
            if (passFie.Text != "")
                user.users_pass = passFie.Text;
            if (fioFie.Text != "")
                user.users_fio = fioFie.Text;
            if (roleFie.SelectedIndex >= 0)
                user.users_role = (dbUsers.roles)roleFie.SelectedIndex;
            if(user.editUser(user.users_fio, user.users_login, user.users_pass, (int)user.users_role))
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
