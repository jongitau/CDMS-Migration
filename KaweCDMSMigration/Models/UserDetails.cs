using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaweCDMSMigration.Models
{
    public class UserDetails
    {
        public int UserID { get; set; }
        public string UserLastName { get; set; }
	    public string UserFirstName { get; set; }
	    public string UserName { get; set; }
	    public string Password { get; set; }
	    public int DeleteFlag { get; set; }
        public int OperatorID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int EmployeeId { get; set; }
    }
}