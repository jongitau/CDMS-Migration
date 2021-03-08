using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaweCDMSMigration.Controllers
{
    public class UsersController : ApiController
    {
        [HttpGet]
        [Route("api/UsersDetails")]
        public IEnumerable<mst_User> Get()
        {
            using (IQCareKAWEEntities entities = new IQCareKAWEEntities())
            {
                return entities.mst_User.ToList();
            }
        }

    }
}
