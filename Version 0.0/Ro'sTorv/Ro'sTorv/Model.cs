using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ro_sTorv
{
    class Model
    {
        public string Name { get; set; }

        public Model(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
