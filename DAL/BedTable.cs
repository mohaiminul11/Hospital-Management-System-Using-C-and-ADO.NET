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
    
    public partial class BedTable
    {
        public int BedId { get; set; }
        public string Assigned { get; set; }
        public string PatientPhone { get; set; }
    
        public virtual PatientInfo PatientInfo { get; set; }
    }
}