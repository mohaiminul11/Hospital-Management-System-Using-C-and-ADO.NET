using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class UserInfoHandler
    {
        HospitalEntities e = new HospitalEntities();

        //Handling Patient info
        public bool AddPatient(string name, string phone, string address)
        {
            PatientInfo u = new PatientInfo();

            try {
                u.Name = name;
                u.PhoneNo = phone;
                u.ContactAddress = address;

                e.PatientInfoes.Add(u);
                e.SaveChanges();
            }catch(Exception e){
                return false;
            }

            
            return true;
        }

        public bool DeletePatient(string phone){

            PatientInfo p = e.PatientInfoes.FirstOrDefault(PatientInfo => PatientInfo.PhoneNo == phone);
            try{
                e.PatientInfoes.Remove(p);
                e.SaveChanges();
            }
           catch(Exception ef){
                return false;
           }
            
            return true;
            
        }

        public bool PatientModify(string phone,string name,string contact)
        {
            PatientInfo p = e.PatientInfoes.FirstOrDefault(PatientInfo => PatientInfo.PhoneNo == phone);
            try
            {
                if(name!=""){
                    p.Name = name;
                }
                if(contact!=""){
                    p.ContactAddress = contact;
                }
                
                e.SaveChanges();
            }
            catch (Exception ef)
            {
                return false;
            }

            return true;
        }
        //get the userNames

        public List<string> getAdminUsername()
        {
            List<string> s = new List<string>();
            var v = from Admin in e.Admins select Admin;
            foreach (var c in v) {
                s.Add(c.UserName);
            }
            return s;
        }
        public List<string> getDoctorUsername()
        {
            List<string> s = new List<string>();
            var v = from Doctor in e.Doctors select Doctor;
            foreach (var c in v)
            {
                s.Add(c.UserName);
            }
            return s;
        }
        public List<string> getReceptionistUsername()
        {
            List<string> s = new List<string>();
            var v = from Receptionist in e.Receptionists select Receptionist;
            foreach (var c in v)
            {
                s.Add(c.Username);
            }
            return s;
        }

        //Handling Admin info

       

        public List<Admin> viewAllAdmin()
        {
            var query = from Admin in e.Admins
                        select Admin;
            List<Admin> userList = query.ToList();

            return userList;
        }
        
        public bool AddAdmin(string uname, string pass, string fullname, string phone, string addresss)
        {
            Admin a = new Admin();
            a.UserName = uname;
            a.Password = pass;
            a.FullName = fullname;
            a.Phone = phone;
            a.Address = addresss;

            e.Admins.Add(a);
            e.SaveChanges();


            return true;
        }
        public bool DeleteAdminInfo(string uname)
        {
            Admin d = e.Admins.FirstOrDefault(Admin => Admin.UserName == uname);
            if(d==null){
                return false;
            }
            e.Admins.Remove(d);
            e.SaveChanges();
            return true;
        }

        public bool UpdateAdminInfo(string uname, string pass, string fullname, string phone, string address)
        {
            Admin a = e.Admins.FirstOrDefault(Admin=>Admin.UserName==uname);
            if(a==null){
                return false;
            }

            if(pass!=""){
                a.Password = pass;
            }
            if(fullname!=""){
                a.FullName = fullname;
            }
            if (phone!="")
            {
                a.Phone = phone;
            }
            if (address!="")
            {
                a.Address = address;
            }
            
            
            e.SaveChanges();

            return true;
        }





        //Handling Doc info

        public List<Doctor> viewAllDoctors()
        {
            var query = from Doctor in e.Doctors
                        select Doctor;
            List<Doctor> userList = query.ToList();

            return userList;
        }

        public List<DAL.PatientInfo> viewAllPatients() {
            var query = from PatientInfo in e.PatientInfoes
                        select PatientInfo;
            List<PatientInfo> userList = query.ToList();

            return userList;
        }

        public bool AddDoc(string uname, string pass, string fullname, string phone, string addresss)
        {
            Doctor a = new Doctor();
            a.UserName = uname;
            a.Pass = pass;
            a.FullName = fullname;
            a.Phone = phone;
            a.Address = addresss;

            e.Doctors.Add(a);
            e.SaveChanges();
            return true;
        }
        public bool DeleteDocInfo(string uname)
        {
            Doctor d = e.Doctors.FirstOrDefault(Doctor => Doctor.UserName == uname);
            if(d==null){
                return false;
            }
            e.Doctors.Remove(d);
            e.SaveChanges();
            return true;
        }

        public bool UpdateDocInfo(string uname, string pass, string fullname, string phone, string addresss)
        {
            Doctor a = e.Doctors.FirstOrDefault(Doctor=>Doctor.UserName==uname);
            if (a != null)
            {
                if (a == null)
                {
                    return false;
                }
                if (pass != "")
                {
                    a.Pass = pass;
                }
                if (fullname != "")
                {
                    a.FullName = fullname;
                }
                if (phone != null)
                {
                    a.Phone = phone;
                }
                if (addresss != "")
                {
                    a.Address = addresss;
                }
                e.SaveChanges();
                return true;
            }
            else {
                return false;
            }
            
            
        }

        //Handling Receptionist info

        public List<Receptionist> viewAllReceptionists()
        {
            var query = from Receptionist in e.Receptionists
                        select Receptionist;
            List<Receptionist> userList = query.ToList();

            return userList;
        }

        public bool AddReceptionist(string uname, string pass, string fullname, string phone, string addresss)
        {
            Receptionist a = new Receptionist();
            a.Username = uname;
            a.Password = pass;
            a.FullName = fullname;
            a.Phone = phone;
            a.Address = addresss;

            e.Receptionists.Add(a);
            e.SaveChanges();
            return true;
        }
        public bool DeleteReceptionistInfo(string uname)
        {
            Receptionist r = e.Receptionists.FirstOrDefault(Receptionist => Receptionist.Username == uname);
            if(r==null){
                return false;
            }
            e.Receptionists.Remove(r);
            e.SaveChanges();
            return true;
        }

        public bool UpdateReceptionistInfo(string uname, string pass, string fullname, string phone, string addresss)
        {
            Receptionist a = e.Receptionists.FirstOrDefault(Receptionist=>Receptionist.Username==uname);
            if (a==null)
            {
                return false;
            }
            if (a == null)
            {
                return false;
            }
            if (pass != "")
            {
                a.Password = pass;
            }
            if (fullname != "")
            {
                a.FullName = fullname;
            }
            if (phone != null)
            {
                a.Phone = phone;
            }
            if (addresss != "")
            {
                a.Address = addresss;
            }
            e.SaveChanges();
            return true;
        }
    }
}
