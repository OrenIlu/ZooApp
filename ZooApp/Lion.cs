using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    class Lion : Mammal
    {
        public int ManeLength { get; set; }
        public bool IsKing { get; set; }
        public override string ShowPicture()
        {
            return $"{Region}_Lion";
        }
        public override string ToString()
        {
            return $"{Name} ({Age} years old) - Number of Offspring: {NumOffspring}";
        }
    }
}
