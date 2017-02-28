using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Transection
    {
        DAL.Transection2 d = new Transection2();
        public bool AddTransection(List<string>m,int number, string phone) { 
            bool b=d.AddTransection(m,number,phone);
            return b;
        }

        public List<DAL.Transection> viewAllTransection(){
            List<DAL.Transection> lt= d.viewAllTransection();
            return lt;
        }
    }
}
