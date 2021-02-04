using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird:Animal
    {
        public Bird()
        { }

        public string FeatherColor      { get; set; }
            
        public string BeakType      { get; set; }

        public string WingSpan         { get; set; }

        public string Sound { get; set; }



        public void Display1(string featherColor, string beakType, string wingSpan, string sound)
        {
            
            Console.WriteLine($"The facts on this bird are its pretty {featherColor} feathers.\n Its a beaktype of {beakType}.\n It has a wingspan of {wingSpan}.\n Its sound is {sound}. ");
        }
    }
}
