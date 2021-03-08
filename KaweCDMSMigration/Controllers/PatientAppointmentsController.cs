using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaweCDMSMigration.Controllers
{
    public class PatientAppointmentsController : ApiController
    {
        [HttpGet]
        [Route("api/PxAppointments")]
        public IEnumerable<dtl_PatientAppointment> Get()
        {
            using (IQCareKAWEEntities entities = new IQCareKAWEEntities())
            {
                return entities.dtl_PatientAppointment.ToList();
            }
        }
    }
}
