using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string FeatherColor { get; set; }
        public string BeakLength { get; set; }
        public bool CanFly { get; set; }
        public bool LaysEggs { get; set; }

    }
}
