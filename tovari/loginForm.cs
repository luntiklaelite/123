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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void but_Auth_Click(object sender, EventArgs e)
        {
            if(loginFie.Text == "" || passFie.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (dbUsers.auth(loginFie.Text, passFie.Text))
            {
                dbSotr.setLocal();
                mainForm form = new mainForm();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
                return;
            }
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
