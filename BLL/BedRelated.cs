using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BedRelated
    {
        DAL.BedRelated b = new DAL.BedRelated();

        public bool freeBed(string id) {
            int number;
            bool bx=Int32.TryParse(id,out number);
            
            if(bx==true){
                bool by=b.freeBed(number);
                return by;
            }
            return false;
        }

        public List<int> getInfo()
        {
            List<int> a = b.getInfo();
            return a;
        }

        public List<int> OccupiedBed()
        {
            List<int> a = b.OccupiedBed();
            return a;
        }

        public bool assign(string phone, string bedno) {

            bool x = b.assign(phone, bedno);
            return x;
        }

        public List<BedTable> ShowAllBeds() {
            List<BedTable> s = b.ShowAllBeds();
            return s;
        }

        public bool AddBed(string no) {
            int number;
            bool bx=Int32.TryParse(no,out number);
            if(bx==true){
                b.AddBeds(number);
                return true;
            }
            return false;
            
        }
    }
}
