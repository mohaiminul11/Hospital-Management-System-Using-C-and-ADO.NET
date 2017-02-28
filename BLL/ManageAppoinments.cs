using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ManageAppoinments
    {
        DAL.ManageAppoinment a = new DAL.ManageAppoinment();

        public List<string> getDocNames() {
            List<string> docNames = a.getDocNames();
            return docNames;
        }
        public List<string> getPatientPhones() {
            List<string> patientPhones = a.getPatientPhones();
            return patientPhones;
        }

        public bool AddAppoinment(string DocName,string PatientPhone,string Date) {
            DateTime d = Convert.ToDateTime(Date);
            bool bx=a.AddAppoinment(DocName, PatientPhone,d);
            return bx;
            
        }


        public List<Appoinment> getAppoinments(string docid, string Date)
        {
            DateTime d = Convert.ToDateTime(Date);
            
            List<Appoinment> b = a.getAppoinments(docid,d);
            return b;
        }

        public List<Appoinment> getAppoinmentsWithDate(string docid, string Date)
        {
            DateTime d = Convert.ToDateTime(Date);

            List<Appoinment> b = a.getAppoinments(docid, d);
            return b;
        }

        public void deleteAppoinment(string s) {
            int number;
            Int32.TryParse(s,out number);
            a.deleteAppoinment(number);
        }



        public List<DAL.Appoinment> docAppoinmentList(string id)
        {

            List<Appoinment> b = a.docAppoinmentList(id);
            return b;
        }

        public bool DocMarkAsDone(string id)
        {
            int number;
            Int32.TryParse(id, out number);
            if (number != 0)
            {
                bool b = a.DocMarkAsDone(number);
                return b;
            }
            return false;
        }
    }
}
