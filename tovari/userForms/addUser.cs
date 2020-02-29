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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
            roleFie.Items.Add(dbUsers.getRoleName(dbUsers.roles.admin));
            roleFie.Items.Add(dbUsers.getRoleName(dbUsers.roles.user));
            roleFie.Items.Add(dbUsers.getRoleName(dbUsers.roles.sotr));
        }

        private void but_addUser_Click(object sender, EventArgs e)
        {
            if (loginFie.Text == "" || passFie.Text == "" || fioFie.Text == "" || roleFie.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if(dbUsers.addUser(loginFie.Text, passFie.Text, fioFie.Text, roleFie.SelectedIndex))
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
