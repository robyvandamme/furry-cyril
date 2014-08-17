using System.Collections.Generic;
using System.Xml.Schema;

namespace Domain.Model
{
    public class Cyril
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public ICollection<CyrilOption> Options { get; set; }

    }
}