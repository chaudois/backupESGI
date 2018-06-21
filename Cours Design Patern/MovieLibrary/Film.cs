using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Film : Animation
    {
        public int cpt;
        public void click()
        {
            Run();
        }

        public void show()
        {
            throw new NotImplementedException();
        }
        public void Run()
        {
            cpt++;
        }

    }
}
