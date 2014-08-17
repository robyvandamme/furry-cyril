using System;
using System.Globalization;
using Domain.Interfaces;
using Domain.Interfaces.Adapters;
using Domain.Model;

namespace Dependency
{
    public class CyrilServiceAdapter: ICyrilService
    {
        private readonly IExternalFurryService _externalFurryService;

        public CyrilServiceAdapter(IExternalFurryService externalFurryService)
        {
            _externalFurryService = externalFurryService;
        }

        public Cyril FindCyril(int id)
        {
            var furry = _externalFurryService.GeFurry(id.ToString(CultureInfo.InvariantCulture));
            return MapFurryToCyril(furry);
        }

        // In order to make this testable we can move mapping outside and test as public methods 
        // (although this is not a method that should be public, so maybe internal and make visible only to testing project)
        private Cyril MapFurryToCyril(Furry furry)
        {
            var cyril = new Cyril();
            cyril.Id = furry.Id;            
            cyril.Age = furry.Age;
            return cyril;
        }
    }
}