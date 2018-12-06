using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class CharactersCreateVM
    {
        public string Name { get; set; }
        public string Backstory { get; set; }
        public int Type { get; set; } //Vilken datatyp för drop-down?
        public int SpecialTrait { get; set; }   //Vilken datatyp för radio buttons?
    }
}
