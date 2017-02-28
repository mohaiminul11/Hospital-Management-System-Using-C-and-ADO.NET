using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Fee
    {
        DAL.Fee u = new DAL.Fee();
        public List<DAL.FeeTable> AllCharges()
        {
            List<DAL.FeeTable> a = u.AllCharges();
            return a;
        }

        public List<string> listOfAllServices() {
            List<string> m = u.listOfAllServices();
            return m;
        }
        public bool changeCharge(string type, string amount)
        {
            int number = 0;
            bool s = Int32.TryParse(amount, out number);
            if (number == 0)
            {
                return false;
            }
            bool b = u.changeCharge(type, number);
            return b;
        }

        public bool Addtype(string type,string amount) {
            int number = 0;
            bool s = Int32.TryParse(amount, out number);
            if (number == 0)
            {
                return false;
            }
            bool b = u.Addtype(type, number);
            return b;
        }
        public bool DeleteType(string s)
        {
            bool b=u.DeleteType(s);
            return b;
        }

    }
}
