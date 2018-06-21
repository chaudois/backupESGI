using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public sealed class Sun
    {
        string Name { get; set; }

        private Sun() { }

        public  static readonly Sun instance=new Sun();
        
    }
}
