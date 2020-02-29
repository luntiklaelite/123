using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tovari
{
    public class chGrid
    {
        public static bool selRows(DataGridView grid)
        {
            if (grid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите строчку!");
                return false;
            }
            return true;
        }
    }
}
