using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    class Tiger: Mammal
    {
        public string FurColor { get; set; }
        public int StripeCount { get; set; }
        public override string ShowPicture()
        {
            return $"{Region}_Tiger";
        }
        public override string ToString()
        {
            return $"{Name} ({Age} years old) - Number of Offspring: {NumOffspring}";
        }
    }
}
