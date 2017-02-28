using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Transection2
    {
        HospitalEntities e = new HospitalEntities();

        public bool AddTransection(List<string>m, int number,string phone)
        {
            int total=0;
            var f = from FeeTable in e.FeeTables select FeeTable;
            foreach(var v in f){
                foreach(var w in m){
                    if(v.FeeName==w){
                        total += v.Charge;
                    }
                }
            }

            Transection t = new Transection();

            PatientInfo p = e.PatientInfoes.FirstOrDefault(i=>i.PhoneNo==phone);

            if(p!=null){
                t.PatientPhone = phone;
                t.Total = total.ToString();
                t.Date = DateTime.Today;
                e.Transections.Add(t);
                e.SaveChanges();
                return true;
            }
            return false;

        }

        public List<Transection> viewAllTransection()
        {
            var v=from Transection in e.Transections select Transection;
            List<Transection> tm = v.ToList<Transection>();
            return tm;
        }
        //public bool addNewEntry(string phone, bool docfee, bool bedcharge,string days, bool Urinalysis, bool PapSmear, bool occultBloodTest, bool CholesterolLevel, bool GlucoseLevel) {
        //    var f = from feetable in e.FeeTables select feetable;

        //    int total=0;
            //string Docfee;
            //string BedCharge;
            //string Urinalysisfee;
            //string PapSmearfee;
            //string OccultBloodTestee;
            //string CholesterolLevelfee;
            //string GlucoseLevelfee;
            //int labcharge=0;

            //Transection t = new Transection();

            //PatientInfo p = e.PatientInfoes.FirstOrDefault(PatientInfo=>PatientInfo.PhoneNo==phone);
        //    if (p != null)
        //    {
        //        //Transection t = e.Transections.FirstOrDefault(Transection => Transection.PatientPhone == phone);
        //        if (docfee == true)
        //        {


        //            foreach (FeeTable s in f)
        //            {
        //                //Docfee=s.DocFee.ToString();
        //                total += s.DocFee;
        //                t.DoctorsVisit = s.DocFee.ToString();
        //            }
        //        }
        //        if (bedcharge == true)
        //        {
        //            foreach (FeeTable s in f)
        //            {
        //                //BedCharge = s.Bedcharge.ToString();
        //                total += s.Bedcharge * (Convert.ToInt32(days));
        //                t.BedCharge = s.Bedcharge.ToString();
        //            }
        //        }
        //        if (Urinalysis == true)
        //        {
        //            foreach (FeeTable s in f)
        //            {
        //                //Urinalysisfee = s.Urinalysis.ToString();
        //                total += s.Urinalysis;
        //                labcharge += s.Urinalysis;

        //            }
        //        }
        //        if (PapSmear == true)
        //        {
        //            foreach (FeeTable s in f)
        //            {
        //                //PapSmearfee = s.PapSmear.ToString();
        //                total += s.PapSmear;
        //                labcharge += s.PapSmear;
        //            }
        //        }
        //        if (occultBloodTest == true)
        //        {
        //            foreach (FeeTable s in f)
        //            {
        //                //OccultBloodTestee = s.OccultBloodTest.ToString();
        //                total += s.OccultBloodTest;
        //                labcharge += s.OccultBloodTest;
        //            }
        //        }
        //        if (CholesterolLevel == true)
        //        {
        //            foreach (FeeTable s in f)
        //            {
        //                //CholesterolLevelfee = s.CholesterolLevel.ToString();
        //                total += s.CholesterolLevel;
        //                labcharge += s.CholesterolLevel;
        //            }
        //        }
        //        if (GlucoseLevel == true)
        //        {
        //            foreach (FeeTable s in f)
        //            {
        //                //GlucoseLevelfee = s.BloodGlucoseLevel.ToString();
        //                total += s.BloodGlucoseLevel;
        //                labcharge += s.BloodGlucoseLevel;
        //            }
        //        }
        //        DateTime thisDay = DateTime.Today;
        //        t.Date = thisDay;
        //        t.PatientPhone = phone;
        //        t.Labcharge = labcharge.ToString();
        //        t.Total = total.ToString();

        //        e.Transections.Add(t);
        //        e.SaveChanges();
        //        return true;
        //    }

        //    else {
        //        return false;
        //    }
            
        //}
    }
}
