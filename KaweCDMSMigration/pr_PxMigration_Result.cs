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
    
    public partial class pr_PxMigration_Result
    {
        public int ID { get; set; }
        public string PatientEnrollmentID { get; set; }
        public string PatientClinicID { get; set; }
        public Nullable<int> ReferredFrom { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string anonymous { get; set; }
        public System.DateTime DOB { get; set; }
        public Nullable<int> estimated_age { get; set; }
        public string gender { get; set; }
        public string nationality { get; set; }
        public string County { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public Nullable<int> email { get; set; }
        public string picture { get; set; }
        public Nullable<int> DistrictName { get; set; }
        public Nullable<int> Province { get; set; }
        public Nullable<int> MaritalStatus { get; set; }
        public string ID_PassportNo { get; set; }
        public Nullable<int> Town { get; set; }
        public string ID_PassportNo1 { get; set; }
        public string TreatmentSupporterRelationship { get; set; }
        public string NHIFNumber { get; set; }
        public string NCPWDNumber { get; set; }
        public string UHCNumber { get; set; }
        public string EpicarePatientInsuranceCover { get; set; }
        public string EpicareAllergies { get; set; }
        public Nullable<int> staff_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    }
}
