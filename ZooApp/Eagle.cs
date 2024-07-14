using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    class Eagle: Bird
    {
        public int Wingspan { get; set; }
        public string Species { get; set; }
        public override string ShowPicture()
        {
            return $"{Species}_Eagle";
        }
        public override string ToString()
        {
            return $"{Name} ({Age} years old) - Milage: {Milage} km";
        }
    }
}
