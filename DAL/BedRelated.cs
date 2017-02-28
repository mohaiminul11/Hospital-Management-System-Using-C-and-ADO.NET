using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BedRelated
    {
        HospitalEntities e = new HospitalEntities();

        public bool freeBed(int id) {
            BedTable b = e.BedTables.FirstOrDefault(BedTable=>BedTable.BedId==id);
            if(b!=null){
                b.PatientPhone = null;
                b.Assigned = "No";
                e.SaveChanges();
                return true;
            }
            return false;
            
        }
        public List<int> getInfo()
        {
            var query = from BedTable in e.BedTables where BedTable.Assigned=="No" select BedTable.BedId;
            List<int> userList = query.ToList();

            return userList;
        }

        public List<int> OccupiedBed()
        {
            var query = from BedTable in e.BedTables where BedTable.Assigned == "Yes" select BedTable.BedId;
            List<int> userList = query.ToList();

            return userList;
        }

        public bool assign(string phone, string bedno)
        {
            int m=Convert.ToInt32(bedno);

            try {
                BedTable b = e.BedTables.FirstOrDefault(BedTable => BedTable.BedId == m);
                b.Assigned = "Yes";
                b.PatientPhone = phone;
                e.SaveChanges();
            }
            catch(Exception e){
                return false;
            }
            return true;
            
        }

        public List<BedTable> ShowAllBeds() {
            var c = from BedTable in e.BedTables select BedTable;
            List<BedTable>b=c.ToList<BedTable>();
            return b;
        }

        public void AddBeds(int no)
        {
            for (int i = 0; i < no;i++ )
            {
                BedTable b=new BedTable();
                b.Assigned = "No";
                e.BedTables.Add(b);
                e.SaveChanges();
            }
        }
    }
}
