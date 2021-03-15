using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaweCDMSMigration.Controllers
{
    public class PharmacyOrdersController : ApiController
    {
        [HttpGet]
        [Route("api/PharmacyOrders")]
        public IEnumerable<ord_PatientPharmacyOrder> Get()
        {
            using (IQCareKAWEEntities entities = new IQCareKAWEEntities())
            {
                return entities.ord_PatientPharmacyOrder.ToList();
            }

        }
    
    }
}
