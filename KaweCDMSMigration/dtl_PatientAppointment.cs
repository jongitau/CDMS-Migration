//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KaweCDMSMigration
{
    using System;
    using System.Collections.Generic;
    
    public partial class dtl_PatientAppointment
    {
        public int Ptn_pk { get; set; }
        public int LocationID { get; set; }
        public int Visit_pk { get; set; }
        public System.DateTime AppDate { get; set; }
        public Nullable<int> AppReason { get; set; }
        public int AppStatus { get; set; }
        public Nullable<long> EmployeeID { get; set; }
        public bool DeleteFlag { get; set; }
        public int UserID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string AppNote { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public int AppointmentId { get; set; }
    }
}
