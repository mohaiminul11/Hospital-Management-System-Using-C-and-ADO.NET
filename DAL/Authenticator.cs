using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Authenticator
    {
        HospitalEntities e = new HospitalEntities();
        public string authenticateDoc(string username, string pass,ref string i)
        {

            var query = from Doctor in e.Doctors where Doctor.UserName == username && Doctor.Pass == pass select Doctor;
            string s = "";
            foreach (Doctor d in query)
            {
                s = d.FullName;
                i = d.UserName;
            }
            //Doctor doc = e.Doctors.FirstOrDefault(Doctor => Doctor.UserName == username && Doctor.Pass == pass);
            if (query != null)
            {
                return s;
            }
            return "";
        }

        public string authenticateAdmin(string username, string pass,ref string i)
        {
            var query = from Admin in e.Admins where Admin.UserName == username && Admin.Password == pass select Admin;
            string s = "";
            foreach (Admin d in query)
            {
                s = d.FullName;
                i = d.UserName;
            }
            //Doctor doc = e.Doctors.FirstOrDefault(Doctor => Doctor.UserName == username && Doctor.Pass == pass);
            if (query != null)
            {
                return s;
            }
            return "";
        }

        public string authenticateReceptionist(string username, string pass,ref string i)
        {
            Receptionist Rec = e.Receptionists.FirstOrDefault(Admin => Admin.Username == username && Admin.Password == pass);
            if (Rec != null)
            {
                i = Rec.Username;
                return Rec.FullName;
            }
            return "";
        }
    }
}
