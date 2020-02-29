using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tovari
{
    public class dbUsers
    {
        public static dbUsers localuser;


        public enum roles : int
        {
            admin = 0,
            user = 1,
            sotr = 2
        }

        public static string getRoleName(roles role)
        {
            if (role == roles.admin)
                return "Администратор";
            if (role == roles.user)
                return "Пользователь";
            if (role == roles.sotr)
                return "Сотрудник компании";
            return "Неизвестно";
        }

        public int users_id;
        public string users_fio, users_login, users_pass;
        public roles users_role;

        public dbUsers(DataRow row)
        {
            users_id = Convert.ToInt32(row["users_id"]);
            users_fio = Convert.ToString(row["users_fio"]);
            users_login = Convert.ToString(row["users_login"]);
            users_pass = Convert.ToString(row["users_pass"]);
            users_role = (roles)Convert.ToInt32(row["users_role"]);
        }

        public static bool auth(string login, string pass)
        {
            DataTable table;
            if (db.init().select("SELECT * FROM `users` WHERE `users_login` = @login AND `users_pass` = @pass", new List<parami> { new parami("@login", login), new parami("@pass", pass) }, out table) && table.Rows.Count > 0)
            {
                localuser = new dbUsers(table.Rows[0]);
                return true;
            }
            return false;

        }


        public static bool addUser(string login, string pass, string fio, int role)
        {
            if(db.init().exec("INSERT INTO `users` (`users_fio`, `users_login`, `users_pass`, `users_role`) VALUES (@fio, @login, @pass, @roles)", new List<parami> { new parami("@fio", fio),new parami("@login", login),new parami("@pass", pass),new parami("@roles", role) }))
            {
                return true;
            }
            return false;
        }

        public bool editUser(string fio, string login, string pass, int role)
        {
            if (db.init().exec("UPDATE `users` SET `users_fio` = @fio, `users_login` = @login, `users_pass` = @pass, `users_role` = @role WHERE `users`.`users_id` = @id;", new List<parami> { new parami("@fio", fio), new parami("@login", login), new parami("@pass", pass), new parami("@role", role), new parami("@id", users_id), }))
            {
                return true;
            }
            return false;
        }

        public bool delUser()
        {
            if (db.init().exec("DELETE FROM `sotr_company` WHERE `sotr_company`.`sotr_users_id` = @id", new List<parami> { new parami("@id", users_id) }))
            {
                if (db.init().exec("DELETE FROM `users` WHERE `users`.`users_id` = @id", new List<parami> { new parami("@id", users_id) }))
                {
                    return true;
                }
            }
            return false;
        }


        public static bool select(string filter, out List<dbUsers> list) 
        {
            DataTable table = new DataTable();
            list = new List<dbUsers>();
            if (db.init().select("SELECT * FROM `users` WHERE `users_login` LIKE @filter OR `users_fio` LIKE @filter", new List<parami> { new parami("@filter", "%" + filter + "%") }, out table))
            {
                foreach (DataRow row in table.Rows)
                {
                    list.Add(new dbUsers(row));
                }
                return true;
            }
            return false;
        }
    }
}
