using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    public class Mammal : Animal
    {
        public string Region { get; set; }
        public bool HasOffspring { get; set; }
        public int NumOffspring { get; set; }
    }
}
