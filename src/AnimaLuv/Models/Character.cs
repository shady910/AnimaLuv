using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimaLuv.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Outfit { get; set; }
        public string Size { get; set; }
        public string stuffingMaterial  { get; set; }
        public string stuffingLevel { get; set; }
    }
}
