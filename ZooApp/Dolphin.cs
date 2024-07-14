using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    class Dolphin: Fish
    {
        public bool IsTrained { get; set; }
        public string Color { get; set; }
        public override string ShowPicture()
        {
            return $"{Color}_Dolphin";
        }
        public override string ToString()
        {
            return $"{Name} ({Age} years old) - Tracker ID: #{TrackerID}";
        }
    }
}
