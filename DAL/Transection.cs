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
    
    public partial class Transection
    {
        public int TransectionId { get; set; }
        public string PatientPhone { get; set; }
        public string Total { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual PatientInfo PatientInfo { get; set; }
    }
}
