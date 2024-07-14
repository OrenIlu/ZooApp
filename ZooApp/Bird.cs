using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    public class Bird : Animal
    {
        public bool CanFly { get; set; }
        public string Diet { get; set; }
        public int Milage { get; set; }
    }
}
