using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaweCDMSMigration.Models
{
    public class DrugsList
    {
        public int Drug_pk { get; set; }
        public string DrugID { get; set; }
        public int ItemTypeID { get; set; }
        public string DrugName { get; set; }
        public bool DeleteFlag { get; set; }
        public int UserID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int DispensingMargin { get; set; }
        public int DispensingUnitPrice { get; set; }
        public string FDACode { get; set; }
        public int Manufacturer { get; set; }
        public int MaxStock { get; set; }
        public int MinStock { get; set; }
        public int PurchaseUnitPrice { get; set; }
        public int QtyPerPurchaseUnit { get; set; }		
        public int SellingUnitPrice { get; set; }
        public int DispensingUnit { get; set; }
        public int PurchaseUnit { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public int Sequence { get; set; }
        public string ItemInstructions { get; set; }
        public string Abbreviation { get; set; }

    }
}