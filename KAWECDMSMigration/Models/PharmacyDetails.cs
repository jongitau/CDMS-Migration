using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaweCDMSMigration.Models
{
    public class PharmacyDetails
    {
        public int ptn_pharmacy_pk { get; set; }
        public int Drug_Pk { get; set; }
        public int GenericID { get; set; }
        public int StrengthID { get; set; }
        public int FrequencyID { get; set; }
        public Decimal SingleDose { get; set; }
        public Decimal Duration { get; set; }
        public Decimal OrderedQuantity { get; set; }
        public Decimal DispensedQuantity { get; set; }
        public int Financed { get; set; }
        public int UserID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int RegimenId { get; set; }
        public int Prophylaxis { get; set; }
        public int BatchNo { get; set; }
        public string TreatmentPhase { get; set; }
        public int Month { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public int TabId { get; set; }
        public int PrintPrescriptionStatus { get; set; }
        public string PatientInstructions { get; set; }
        public int Id { get; set; }
        public string WhyPartial { get; set; }
        public int ScheduleId { get; set; }
        public int pillCount { get; set; }
    }
}