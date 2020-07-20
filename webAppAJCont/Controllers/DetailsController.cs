using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webAppAJCont.Controllers
{
    public class DetailsController : ApiController
    {
        // GET: api/Details
        public IEnumerable<string> Get()
        {
            return new string[] { "abhishekjoshi@eurofins.com", "98989898" };
        }

        // GET: api/Details/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Details
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Details/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Details/5
        public void Delete(int id)
        {
        }
    }
}
