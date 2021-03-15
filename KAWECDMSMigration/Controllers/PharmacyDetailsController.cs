using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaweCDMSMigration.Controllers
{
    public class PharmacyDetailsController : ApiController
    {
        [HttpGet]
        [Route("api/PharmacyDetails")]

        public IEnumerable<dtl_PatientPharmacyOrder> Get()
        {
            using (IQCareKAWEEntities entities = new IQCareKAWEEntities())
            {
                return entities.dtl_PatientPharmacyOrder.ToList();
            }
        }

    }
}
