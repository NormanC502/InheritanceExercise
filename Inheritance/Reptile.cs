using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile:Animal
    {

        public Reptile()
        { }

        public string Scales { get; set; }

        public string LayShelledEggs { get; set; }

        public string Sound { get; set; }

        public string DrySkin { get; set; }

        public void Display2(string scales, string layShelledEggs, string sound, string drySkin)
        {
            Console.WriteLine($"The facts on snakes are its {scales} which is unique.\n Its reproductive design of {layShelledEggs}.\n Its sound is {sound} which turns anyone's head.\n It's {drySkin} is made for the desert.");
        }


    }
}
