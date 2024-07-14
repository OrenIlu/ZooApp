using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    class Clownfish: Fish
    {
        public bool IsNemo { get; set; }
        public string Species { get; set; }
        public override string ShowPicture()
        {
            return $"{Species}_Clownfish";
        }
        public override string ToString()
        {
            return $"{Name} ({Age} years old) - Tracker ID: #{TrackerID}";
        }
    }
}
