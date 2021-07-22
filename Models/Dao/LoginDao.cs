using Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class LoginDao
    {
        DbContextWeb db = new DbContextWeb();

        public Login FindLogin(string username)
        {
            Login rs = db.Logins.Find(username);
            if (rs != null)
            {
                return rs;
            }
            return null;
        }

        public bool Login(string username, string password)
        {
            Login lg = db.Logins.FirstOrDefault(x => x.UserName == username && x.Password == password);
            if (lg != null)
            {
                return true;
            }
            return false;
        }
    }
}
