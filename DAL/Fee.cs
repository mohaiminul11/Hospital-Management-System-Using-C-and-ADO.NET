using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Fee
    {
        HospitalEntities e = new HospitalEntities();
        public List<FeeTable> AllCharges()
        {
            var query = from FeeTable in e.FeeTables
                        select FeeTable;
            List<FeeTable> userList = query.ToList();

            return userList;
        }

        public List<string> listOfAllServices() {
            var query = from FeeTable in e.FeeTables
                        select FeeTable;
            List<string> list = new List<string>();
            foreach (var v in query) {
                list.Add(v.FeeName);
            }
            return list;
        }

        public bool changeCharge(string type, int amount)
        {
            var v=from FeeTable in e.FeeTables select FeeTable;
            FeeTable f = e.FeeTables.FirstOrDefault(fee=>fee.FeeName==type);
            f.Charge=amount;
            e.SaveChanges();
            return true;
            
        }

        public bool Addtype(string type, int amount)
        {
            FeeTable fee = new FeeTable();
            fee.FeeName = type;
            fee.Charge = amount;

            e.FeeTables.Add(fee);
            e.SaveChanges();
            return true;
            
        }

        public bool DeleteType(string s) {
            FeeTable fee = e.FeeTables.FirstOrDefault(f=>f.FeeName==s);
            e.FeeTables.Remove(fee);
            e.SaveChanges();
            return true;

        }
    }
}
