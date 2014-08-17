using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.Model;

namespace Api.Controllers
{
    public class CyrilOptionsController : ApiController
    { 
        // POST: api/CyrilOptions
        public void Post(CyrilOption option)
        {
            // this also needs an id
        }

        // PUT: api/CyrilOptions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CyrilOptions/5
        public void Delete(int id)
        {
        }
    }
}
