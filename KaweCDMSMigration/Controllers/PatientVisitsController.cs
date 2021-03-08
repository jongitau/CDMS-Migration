using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaweCDMSMigration.Controllers
{
    public class PatientVisitsController : ApiController
    {
        [HttpGet]
        [Route("api/VisitsDetails")]
        public IEnumerable<DTL_FBCUSTOMFIELD_Epicare> Get()
        {
            using (IQCareKAWEEntities entities = new IQCareKAWEEntities())
            {
                return entities.DTL_FBCUSTOMFIELD_Epicare.ToList();
            }
        }
    }
}
