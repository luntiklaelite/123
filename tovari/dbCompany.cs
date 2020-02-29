using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tovari
{
    public class dbCompany
    {
        public enum type : int
        {
            common = 0,
            expensive = 1,
            vip = 2
        }

        public int company_id;
        public string company_name;
        public type company_type;

        public dbCompany(DataRow row)
        {
            company_id = Convert.ToInt32(row["company_id"]);
            company_name = Convert.ToString(row["company_name"]);
            company_type = (type)Convert.ToInt32(row["company_type"]);
        }

        public override string ToString()
        {
            return company_name;
        }
        public static bool addComp(string name, int tip)
        {
            if (db.init().exec("INSERT INTO `company` (`company_name`, `company_type`) VALUES (@name, @type);", new List<parami> { new parami("@name", name), new parami("@type", tip) }))
            {
                return true;
            }
            return false;
        }

        public bool editComp(string name, int tip)
        {
            if (db.init().exec("UPDATE `company` SET `company_name` = @name, `company_type` = @type WHERE `company_id` = @id;", new List<parami> { new parami("@name", name), new parami("@type",tip), new parami("@id", company_id) }))
            {
                return true;
            }
            return false;
        }

        public bool dellComp()
        {
            DataTable table = new DataTable();
            if (db.init().select("SELECT * FROM `products` WHERE `products_company_id` = @id", new List<parami> { new parami("@id", company_id) }, out table))
            {
                if (table.Rows.Count > 0)
                    return false;
            }
            else
                return false;
            if (db.init().select("SELECT * FROM `sotr_company` WHERE `sotr_company_id` = @id", new List<parami> { new parami("@id", company_id) }, out table))
            {
                if (table.Rows.Count > 0)
                    return false;
            }
            else
                return false;
            if (db.init().exec("DELETE FROM `company` WHERE `company`.`company_id` = @id;", new List<parami> { new parami("@id", company_id) }))
            {
                return true;
            }
            return false;
        }



        public static bool select(string filter, out List<dbCompany> list)
        {
            DataTable table = new DataTable();
            list = new List<dbCompany>();
            if (db.init().select("SELECT * FROM `company` WHERE `company_name` LIKE @filter", new List<parami> { new parami("@filter", "%" + filter + "%") }, out table))
            {
                foreach(DataRow row in table.Rows) 
                {
                    list.Add(new dbCompany(row));
                }
                return true;
            }
            return false;
        }

    }
}
