using System.Collections.Generic;

namespace Dependency
{
    public class ExternalFurryService : IExternalFurryService
    {
        public Furry GeFurry(string furryId)
        {
            return new Furry();
        }
    }

    public class Furry
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public ICollection<FurryOption> Options { get; set; } 
    }

    public class FurryOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
