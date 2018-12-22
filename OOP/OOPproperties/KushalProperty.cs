using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPproperties
{
    class KushalProperty
    {
        private string name;  // the name field
        public string Name    // the Name property
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
