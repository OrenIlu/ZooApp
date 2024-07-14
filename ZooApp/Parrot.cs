using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    class Parrot: Bird
    {
        public string Color { get; set; }
        public bool CanSpeak { get; set; }
        public override string ShowPicture()
        {
            return $"{Color}_Parrot";
        }
        public override string ToString()
        {
            return $"{Name} ({Age} years old) - Milage: {Milage} km";
        }
    }
}
