using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tovari
{
    public class dbStaff
    {
        public int staff_id;
        public string staff_name;

        public dbStaff(DataRow row)
        {
            staff_id = Convert.ToInt32(row["staff_id"]);
            staff_name = Convert.ToString(row["staff_name"]);
        }

        public override string ToString()
        {
            return staff_name;
        }
        public static bool addStaff(string name)
        {
            if (db.init().exec("INSERT INTO `staff` (`staff_name`) VALUES (@name)", new List<parami> { new parami("@name", name) }))
            {
                return true;
            }
            return false;
        }

        public bool editStaff(string name)
        {
            if (db.init().exec("UPDATE `staff` SET `staff_name` = @name WHERE `staff`.`staff_id` = @id;", new List<parami> { new parami("@name", name), new parami("@id", staff_id), }))
            {
                return true;
            }
            return false;
        }

        public bool delStaff()
        {
            if (db.init().exec("DELETE FROM `products` WHERE `products`.`products_staff_id` = @id", new List<parami> { new parami("@id", staff_id) } ))
            {
                if (db.init().exec("DELETE FROM `staff` WHERE `staff`.`staff_id` = @id", new List<parami> { new parami("@id", staff_id) }))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool select(string filter, out List<dbStaff> list)
        {
            DataTable table = new DataTable();
            list = new List<dbStaff>();
            if (db.init().select("SELECT * FROM `staff` WHERE `staff_name` LIKE  @filter", new List<parami> { new parami("@filter", "%" + filter + "%") }, out table))
            {
                foreach (DataRow row in table.Rows)
                {
                    list.Add(new dbStaff(row));
                }
                return true;
            }
            return false;
        }
    }
}
