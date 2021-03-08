using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaweCDMSMigration.Models
{
    public class PatientDetails
    {
        public int ID { get;  set; }
        public string PatientEnrollmentID { get; set; }
        public string PatientClinicID { get; set; }
        public int ReferredFrom { get; set; }
        public int LocationID { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Anonymous { get; set; }
        public System.DateTime DOB { get; set; }
        public string Estimated_age { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public int District { get; set; }
        public int Province { get; set; }
        public int MaritalStatus { get; set; }
        public string IDPassportNo { get; set; }
        public string TreatmentSupporterRelationship { get; set; }
        public string NHIFNumber { get; set; }
        public string NCPWDNumber { get; set; }
        public string UHCNumber { get; set; }
        public string EpicarePatientInsuranceCover { get; set; }
        public string EpicareAllergies { get; set; }
        public int Staff_id { get; set; }
        public System.DateTime Created_at { get; set; }
        public System.DateTime Updated_at { get; set; }

    }
}