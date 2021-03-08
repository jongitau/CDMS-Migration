using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaweCDMSMigration.Controllers
{
    public class PxDetailsController : ApiController
    {
        [HttpGet]
        [Route("api/PxDetails")]
        public HttpResponseMessage Get()

        {
            IQCareKAWEEntities entities = new IQCareKAWEEntities();
            return Request.CreateResponse((HttpStatusCode.OK), entities.pr_PxMigration().ToList());
        }


    }
}
