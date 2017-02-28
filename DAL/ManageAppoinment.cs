using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManageAppoinment
    {
        HospitalEntities e = new HospitalEntities();

        //Doc Usernames
        public List<string> getDocNames()
        {
            var v = from Doctor in e.Doctors select Doctor;
            List<string> docNames = new List<string>();

            foreach(var c in v){
                docNames.Add(c.UserName);
            }
            return docNames;
        }
        //patient phone numbers
        public List<string> getPatientPhones()
        {
            var v = from PatientInfo in e.PatientInfoes select PatientInfo;
            List<string> patientPhones = new List<string>();

            foreach(var c in v){
                patientPhones.Add(c.PhoneNo);
            }
            return patientPhones;
        }

        //Add Appoinment
        public bool AddAppoinment(string docid, string patientid, DateTime d)
        {
            Appoinment a = new Appoinment();

            try {
                a.DoctorUname = docid;
                a.PatientPhone = patientid;
                a.Date = d;
                a.Done = "No";
                e.Appoinments.Add(a);
                e.SaveChanges();
            }catch(Exception e){
                return false;
            }
            
          
            

            return true;

        }

        public List<Appoinment> getAppoinments(string docid,DateTime d)
        {
            var query = from Appoinment in e.Appoinments where docid==Appoinment.DoctorUname && d==Appoinment.Date
                        select Appoinment;
            List<Appoinment> userList = query.ToList();

            return userList;
        }

        public void deleteAppoinment(int n) {
            Appoinment a = e.Appoinments.FirstOrDefault(any=>any.appoinmentID==n);
            e.Appoinments.Remove(a);
            e.SaveChanges();
        }

        public List<Appoinment> docAppoinmentList(string id)
        {
            var query = from Appoinment in e.Appoinments where Appoinment.DoctorUname==id && Appoinment.Date==DateTime.Today &&Appoinment.Done=="No"
                        select Appoinment;
            List<Appoinment> userList = query.ToList();

            return userList;
        }
        public bool DocMarkAsDone(int id) {
            Appoinment a = e.Appoinments.FirstOrDefault(Appoinment=>Appoinment.appoinmentID==id);
            if (a != null)
            {
                a.Done = "Yes";
                e.SaveChanges();
                return true;
            }
            else {
                return false;
            }
            
            
        }
    }
}
