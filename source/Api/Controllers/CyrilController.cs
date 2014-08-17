using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Http;
using Domain.Model;

namespace Api.Controllers
{
    public class CyrilController : ApiController
    {
        // GET api/cyril
        public IEnumerable<Cyril> Get()
        {
            return new List<Cyril> { new Cyril(){Id="1", Name="Cyril", Age = 5, Color = "Black", Options = new Collection<CyrilOption>(){new CyrilOption(){Option = "Blah", OptionId = 512}}} };
        }

        // GET api/cyril/1
        public Cyril Get(int id)
        {
            return new Cyril() { Id = "1", Name = "Cyril", Age = 5, Color = "Black", Options = new Collection<CyrilOption>() { new CyrilOption() { Option = "Blah", OptionId = 512 }}} ;
        }
    }
}
