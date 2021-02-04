using System;
using System.Collections.Concurrent;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal (DONE IN ANIMAL CLASS)
            // give this class 4 members that all Animals have in common


            // Create a class Bird (DONE IN BIRD CLASS)
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile (DONE IN REPTILE CLASS)
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class (DONE IN MAIN PROGRAM)
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class (DONE IN MAIN PROGRAM)
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var species = new AnimalList();   //Declares species to class Animal print through variable species


            var sparrow = new Bird();

            sparrow.Legs =              "Small";
            sparrow.Eyes =              "Red-Brown";
            sparrow.Teeth =             "Not Applicable";
            sparrow.Nose =              "Not Applicable";
            sparrow.FeatherColor =      "Red-Brown";
            sparrow.BeakType =          "Short, Stout, Cone Shaped";
            sparrow.WingSpan =          "8.3 in";
            sparrow.Sound =             "TweetTweet";

            species.Creature.Add(sparrow); //speciexs calls list Creature to add sparrow to list





            var snake = new Reptile();

            snake.Legs =                    "Not since Ancient Days";
            snake.Eyes =                    "Simple with Rods";
            snake.Teeth =                   "Fangs if Poisonous";
            snake.Nose =                    "Only Nostrils";
            snake.Scales =                  "Patterned Snakeskin";
            snake.LayShelledEggs =          "Laying Eggs";
            snake.Sound =                   "A Hissing";
            snake.DrySkin =                 "Keratin Skin Surfaces the Scales";

            species.Creature.Add(snake);


            sparrow.Display1(sparrow.FeatherColor, sparrow.BeakType, sparrow.WingSpan, sparrow.Sound);
            snake.Display2(snake.Scales, snake.LayShelledEggs, snake.Sound, snake.DrySkin);
        }
    }
}
