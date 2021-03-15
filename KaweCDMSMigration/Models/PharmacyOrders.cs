using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaweCDMSMigration.Models
{
    public class PharmacyOrders
    {
        public int ptn_pharmacy_pk { get; set; }
        public int Ptn_pk { get; set; }
        public int VisitID { get; set; }
        public int LocationID { get; set; }
        public int OrderedBy { get; set; }
        public System.DateTime OrderedByDate { get; set; }
        public int DispensedBy { get; set; }
        public System.DateTime DispensedByDate { get; set; }
        public int OrderType { get; set; }
        public Decimal Height { get; set; }
        public int FDC { get; set; }
        public int ProgID { get; set; }
        public Decimal Weight { get; set; }
        public int HoldMedicine { get; set; }
        public int Signature { get; set; }
        public int EmployeeID { get; set; }
        public int ProviderID { get; set; }
        public int DeleteFlag { get; set; }
        public int UserID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int PharmacyPeriodTaken { get; set; }
        public int RegimenLine { get; set; }
        public string PharmacyNotes { get; set; }
        public int StoreId { get; set; }
        public int orderstatus   { get; set; }
        public string ReportingID { get; set; }
        public int CPAD_PharmacyOrderId { get; set; }
        public int PatientMasterVisitId { get; set; }
        public int PatientId { get; set; }
    }
}