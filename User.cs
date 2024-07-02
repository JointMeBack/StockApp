using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public Profile Prof { get; set; }

        public User(int id, string log) 
        {
            Id = id;
            Login = log;
            Prof = new Profile(id);
        }
        public static User GetUser(string log, string pass)
        {
            User user = null;
            DataTable dt = DBManager.DBSelect("Select Id, Login from tUsers where Login = '" + log +"' and Pass = '"+ pass +"'");
            if(dt != null && dt.Rows.Count > 0)
            {
                user = new User(Convert.ToInt32(dt.Rows[0]["Id"].ToString()), dt.Rows[0]["Login"].ToString());
            }
            return user;
        }
    }
}
