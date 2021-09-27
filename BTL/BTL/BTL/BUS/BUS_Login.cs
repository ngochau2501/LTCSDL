using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL.DAO;
namespace BTL.BUS
{
    class BUS_Login
    {
        public bool login(string username, string password)
        {
            try
            {
                DAO_Login objdal = new DAO_Login();
                return objdal.login(username, password);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
