//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientInfo
    {
        public PatientInfo()
        {
            this.Appoinments = new HashSet<Appoinment>();
            this.BedTables = new HashSet<BedTable>();
            this.Transections = new HashSet<Transection>();
        }
    
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string ContactAddress { get; set; }
    
        public virtual ICollection<Appoinment> Appoinments { get; set; }
        public virtual ICollection<BedTable> BedTables { get; set; }
        public virtual ICollection<Transection> Transections { get; set; }
    }
}