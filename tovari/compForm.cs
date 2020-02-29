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
    public partial class compForm : Form
    {
        public compForm()
        {
            InitializeComponent();
            if (!reloadGrid(""))
            {
                MessageBox.Show("Проблема с загрузкой данных в таблицу!");
            }
            if (dbUsers.localuser.users_role != dbUsers.roles.admin)
            {
                but_compAdd.Visible = false;
                but_compDel.Visible = false;
                but_compEdit.Visible = false;
            }
        }

        private bool reloadGrid(string filter)
        {
            grid_comps.Rows.Clear();
            List<dbCompany> list = new List<dbCompany>();
            if (dbCompany.select(filter, out list))
            {
                foreach (dbCompany comp in list)
                {
                    int r = grid_comps.Rows.Add(comp.company_name, comp.company_type);
                    grid_comps.Rows[r].Tag = comp;
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

        private void but_compAdd_Click(object sender, EventArgs e)
        {
            compForms.addForm form = new compForms.addForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Yes)
            {
                form.Hide();
                reloadGrid("");
                return;
            }
            return;
        }

        private void but_compEdit_Click(object sender, EventArgs e)
        {
            if (grid_comps.SelectedRows.Count < 1) 
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            dbCompany comp = (dbCompany)grid_comps.SelectedRows[0].Tag;
            compForms.editForm form = new compForms.editForm(comp);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Yes)
            {
                form.Hide();
                reloadGrid("");
                return;
            }
            return;
        }

        private void but_compDel_Click(object sender, EventArgs e)
        {
            if (grid_comps.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
            var box = MessageBox.Show("Вы действительно хотите удалить эту компанию?", "", MessageBoxButtons.YesNo);
            if (box == DialogResult.Yes)
            {
                dbCompany comp = (dbCompany)grid_comps.SelectedRows[0].Tag;
                if (comp.dellComp())
                {
                    reloadGrid("");
                    MessageBox.Show("Успешно!");
                    return;
                }
                MessageBox.Show("Не удалось удалить компанию по причине ошибки,\nлибо у компании есть записи в других таблицах.");
            }
        }
    }
}
