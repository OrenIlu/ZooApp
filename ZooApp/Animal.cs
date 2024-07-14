using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    [Serializable]
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual string ShowPicture()
        {
            return "AnimalPicture";
        }
        public override string ToString()
        {
            return "AnimalString";
        }
    }

}
