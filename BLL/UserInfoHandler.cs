using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserInfoHandler
    {
        DAL.UserInfoHandler s = new DAL.UserInfoHandler();
        //handling patient info
        public bool AddPatient(string name, string phone, string address) {
            DAL.UserInfoHandler uih = new DAL.UserInfoHandler();
            bool s=uih.AddPatient(name, phone,address);
            return s;
        }
        //Get All Username
        public List<string> getAdminUsername()
        {
            List<string> st = s.getAdminUsername();
            return st;
        }
        public List<string> getDoctorUsername()
        {
            List<string> st = s.getDoctorUsername();
            return st;
        }
        public List<string> getReceptionistUsername()
        {
            List<string> st = s.getReceptionistUsername();
            return st;
        }

        //Handling Admin info
        


        public List<DAL.Admin> viewAllAdmin() {
            List<Admin> a = s.viewAllAdmin();
            return a;
        }
        public bool AddAdmin(string uname,string pass,string fullname,string phone,string addresss) {

            s.AddAdmin(uname,pass,fullname,phone,addresss); 
            return true;
        }
        public bool DeleteAdminInfo(string uname)
        {
            bool m=s.DeleteAdminInfo(uname);   
            return m;
        }

        public bool UpdateAdminInfo(string uname, string pass, string fullname, string phone, string addresss)
        {
            bool m=s.UpdateAdminInfo(uname, pass, fullname, phone, addresss);
            return m;
        }

        //Handling Doc info

        public List<DAL.Doctor> viewAllDoctors()
        {
            List<Doctor> a = s.viewAllDoctors();
            return a;
        }

        public List<DAL.PatientInfo> viewAllPatients(){
            List<PatientInfo> a = s.viewAllPatients();
            return a;
        }

        public bool DeletePatient(string phone) {
            bool bx=s.DeletePatient(phone);
            return bx;
        }
        public bool PatientModify(string phone,string name, string contact)
        {
            bool bx = s.PatientModify(phone,name,contact);
            return bx;
        }
        public bool AddDoc(string uname, string pass, string fullname, string phone, string addresss)
        {
            s.AddDoc(uname, pass, fullname, phone, addresss);
            return true;
        }
        public bool DeleteDocInfo(string uname)
        {
            bool m = s.DeleteDocInfo(uname);
            return m;
        }

        public bool UpdateDocInfo(string uname, string pass, string fullname, string phone, string addresss)
        {
            bool m=s.UpdateDocInfo(uname, pass, fullname, phone, addresss);
            return m;
        }





        //Handling Receptionist info

        public List<DAL.Receptionist> viewAllReceptionists()
        {
            List<Receptionist> a = s.viewAllReceptionists();
            return a;
        }


        public bool AddReceptionist(string uname, string pass, string fullname, string phone, string addresss)
        {
            s.AddReceptionist(uname, pass, fullname, phone, addresss);
            return true;
        }
        public bool DeleteReceptionistInfo(string uname)
        {
            bool m = s.DeleteReceptionistInfo(uname);
            return m;
        }

        public bool UpdateReceptionistInfo(string uname, string pass, string fullname, string phone, string addresss)
        {
            s.UpdateReceptionistInfo(uname, pass, fullname, phone, addresss);
            return true;
        }
    }
}
