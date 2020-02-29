using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tovari
{
    public class dbProd
    {
        public int products_id, products_price;
        public dbStaff staff;
        public dbCompany company;
        public dbProd(DataRow row)
        {
            products_id = Convert.ToInt32(row["products_id"]);
            products_price = Convert.ToInt32(row["products_price"]);
        }

        public static bool addProd(dbStaff staffs, double price ,dbCompany comp)
        {
            if (db.init().exec("INSERT INTO `products` (`products_staff_id`, `products_price`, `products_company_id`) VALUES (@staff_id, @price, @comp_id)", new List<parami> { new parami("@staff_id", staffs.staff_id ), new parami("@price", price), new parami("@comp_id", comp.company_id) }))
            {
                return true;
            }
            return false;
        }

        public bool editProd(dbStaff staffs, double price, dbCompany comp)
        {
            if (db.init().exec("UPDATE `products` SET `products_staff_id` = @staff_id, `products_price` = @price, `products_company_id` = @comp_id WHERE `products`.`products_id` = @id;", new List<parami> { new parami("@staff_id", staffs.staff_id), new parami("@price", price), new parami("@comp_id", comp.company_id), new parami("@id", products_id) }))
            {
                return true;
            }
            return false;
        }

        public bool delProd()
        {
            if (db.init().exec("DELETE FROM `products` WHERE `products`.`products_id` = @id", new List<parami> { new parami("@id", products_id) }))
            {
                return true;
            }
            return false;
        }

        public static bool select(string filter, out List<dbProd> list)
        {
            DataTable table = new DataTable();
            list = new List<dbProd>();
            if (db.init().select("SELECT * FROM `products`, `company`, `staff` WHERE `products_company_id` = `company`.`company_id` AND `products_staff_id` = `staff`.`staff_id` AND (`company_name` LIKE @filter OR `staff_name` LIKE @filter)", new List<parami> { new parami("@filter", "%" + filter + "%")}, out table))
            {
                foreach (DataRow row in table.Rows)
                {
                    dbProd prod = new dbProd(row);
                    prod.staff = new dbStaff(row);
                    prod.company = new dbCompany(row);
                    list.Add(prod);
                }
                return true;
            }

            return false;
        }
    }
}
