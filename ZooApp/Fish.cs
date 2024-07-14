using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    public class Fish : Animal
    {
        public bool HasTracker { get; set; }
        public string WaterType { get; set; }
        public string TrackerID { get; set; }
    }
}
