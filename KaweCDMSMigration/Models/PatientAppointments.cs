using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaweCDMSMigration.Models
{
    public class PatientAppointments
    {
        public int Ptn_pk { get; set; }
	    public int LocationID { get; set; }
        public int Visit_pk { get; set; }
        public System.DateTime AppDate { get; set; }
        public int AppReason { get; set; }
        public int AppStatus { get; set; }
        public int EmployeeID { get; set; }
        public int DeleteFlag { get; set; }
        public int UserID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int ModuleId { get; set; }
        public string AppNote { get; set; }
        public int UpdateUserId { get; set; }
        public int AppointmentId { get; set; }
    }
}