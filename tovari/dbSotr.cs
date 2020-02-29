using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tovari
{
    public class dbSotr
    {
        public int sotr_id, sotr_company_id, sotr_users_id;
        public dbCompany company;
        public dbUsers users;
        public static dbSotr localSotr;
        private static bool localInit;

        public static bool setLocal()
        {
            DataTable table;
            if (db.init().select("SELECT * FROM `sotr_company`, `users`, `company` WHERE `sotr_users_id` = `users`.`users_id` AND `sotr_company`.`sotr_company_id` = `company`.`company_id` AND `sotr_users_id` = @id", new List<parami> { new parami("@id", dbUsers.localuser.users_id) }, out table) && table.Rows.Count > 0)
            {
                localSotr = new dbSotr(table.Rows[0]);
                localInit = true;
                return true;
            }
            return false;
        }

        public dbSotr(DataRow row)
        {
            sotr_id = Convert.ToInt32(row["sotr_id"]);
            users = new dbUsers(row);
            company = new dbCompany(row);
        }

        public static bool addSotr(dbCompany comp, dbUsers user)
        {
            if (db.init().exec("INSERT INTO `sotr_company` (`sotr_company_id`, `sotr_users_id`) VALUES (@comp, @user)", new List<parami> { new parami("@comp", comp.company_id), new parami("@user", user.users_id) }))
            {
                return true;
            }
            return false;
        }

        public bool editSotr(dbCompany comp, dbUsers user)
        {
            if (db.init().exec("UPDATE `sotr_company` SET `sotr_company_id` = @comp, `sotr_users_id` = @user WHERE `sotr_company`.`sotr_id` = @id", new List<parami> { new parami("@comp", comp.company_id), new parami("@user", user.users_id), new parami("@id", sotr_id) }))
            {
                return true;
            }
            return false;
        }

        public bool delSotr()
        {
            if (db.init().exec("DELETE FROM `sotr_company` WHERE `sotr_company`.`sotr_users_id` = @id", new List<parami> { new parami("@id", sotr_id) }))
            {
                return true;
            }
            return false;
        }

        public static bool select(string filter, out List<dbSotr> list)
        {
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            list = new List<dbSotr>();
            if (dbUsers.localuser.users_role != dbUsers.roles.admin)
            {
                if (localInit == false)
                    return false;
                if (db.init().select("SELECT * FROM `company`, `users`, `sotr_company` WHERE `sotr_company`.`sotr_company_id` = `company`.`company_id` AND `sotr_company`.`sotr_users_id` = `users`.`users_id` AND `sotr_company`.`sotr_company_id` = @comp_id AND ( `users_login` LIKE @filter OR `users_fio` LIKE @filter)", new List<parami> { new parami("@comp_id", localSotr.company.company_id), new parami("@filter", "%" + filter + "%") }, out table))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        dbSotr sotr = new dbSotr(row);
                        sotr.company = new dbCompany(row);
                        sotr.users = new dbUsers(row);
                        list.Add(sotr);
                    }
                    return true;
                }
            }
            if (db.init().select("SELECT * FROM `company`, `users`, `sotr_company` WHERE `sotr_company`.`sotr_company_id` = `company`.`company_id` AND `sotr_company`.`sotr_users_id` = `users`.`users_id` AND (`company_name` LIKE @filter OR `users_login` LIKE @filter OR `users_fio` LIKE @filter)", new List<parami> { new parami("@filter", "%" + filter + "%") }, out table))
            {
                foreach (DataRow row in table.Rows)
                {
                    dbSotr sotr = new dbSotr(row);
                    sotr.company = new dbCompany(row);
                    sotr.users = new dbUsers(row);
                    list.Add(sotr);
                }
                return true;
            }
            return false;
        }
    }
}
