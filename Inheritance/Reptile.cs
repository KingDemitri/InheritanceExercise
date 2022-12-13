using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public string ScaleColor { get; set; }
        public bool FertalizeEggsInternally { get; set; }
        public bool IsEctothermic { get; set; }
        //Ectothermic means their main source of heat comes from their environment.
        //Opposite is Endothermic
    }
}
