using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Authenticator
    {
        DAL.Authenticator a = new DAL.Authenticator();
        public string authenticate(string acctype, string username, string pass,ref string i)
        {

            if (acctype == "Admin")
            {
                string s = a.authenticateAdmin(username, pass,ref i);
                return s;
            }
            else if (acctype == "Doctor")
            {
                string s = a.authenticateDoc(username, pass, ref i);
                return s;
            }
            else if (acctype == "Receptoinist")
            {
                string s = a.authenticateReceptionist(username, pass, ref i);
                return s;
            }
            return "";
        }
    }
}
