using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhouse.classes
{
    class Plant
    {
        int id;
        string name;
        int maturity;

        public Plant(int id, string name, int maturity)
        {
            this.id = id;
            this.name = name;
            this.maturity = maturity;
        }
    }
}
