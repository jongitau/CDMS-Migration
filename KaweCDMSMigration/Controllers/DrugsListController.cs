using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaweCDMSMigration.Controllers
{
    public class DrugsListController : ApiController
    {
        [HttpGet]
        [Route("api/DrugsList")]

        public IEnumerable<Mst_Drug>Get()
            {
            using (IQCareKAWEEntities entities = new IQCareKAWEEntities())
                {
                    return entities.Mst_Drug.ToList();
                }
            }
    }
}
