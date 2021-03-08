using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaweCDMSMigration.Models
{
    public class PatientVisitsDetails
    {
     public int ID { get; set; }
     public int Ptn_pk { get; set; }
     public int Visit_Pk { get; set; }
     public int LocationId { get; set; }
     public int UserId { get; set; }
     public System.DateTime CreateDate { get; set; }
     public System.DateTime UpdateDate  { get; set; }
     public int NoANCVisits { get; set; }
     public String OtherImmunisation { get; set; }
     public int EPFUComplaints { get; set; }
     public String  EPFUNoSeizuresSinceLastVisit  { get; set; }
     public int EPFUTakeMedsDaily { get; set; }
     public int EPFUHowManyTimesMissed  { get; set; }
     public int EPFUTakeMedsPrescribedTime { get; set; }
     public int EPFUSeizuresAfterMissingMeds { get; set; }
     public string EpiComplaint { get; set; }
     public string EPFUSideEffectsOther { get; set; }
     public string EPFUDosingFrequency  { get; set; }
    }
}