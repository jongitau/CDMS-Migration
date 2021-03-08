using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaweCDMSMigration.Controllers
{
    public class PatientHistoryController : ApiController
    {
        [HttpGet]
        [Route("api/HistoryDetails")]
        public IEnumerable<DTL_FBCUSTOMFIELD_Epicare_Patient_History> Get()
        {
            using (IQCareKAWEEntities entities = new IQCareKAWEEntities())
            {
                return entities.DTL_FBCUSTOMFIELD_Epicare_Patient_History.ToList();
            }
        }
    }
}
