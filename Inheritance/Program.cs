using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            //DONE



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird bird1 = new Bird();
            bird1.HasFeet = true;
            bird1.Species = "Sharp-shinned Hawk";
            bird1.BeakLength = "Short";
            bird1.EyeColor = "Gold";
            bird1.CanFly = true;
            bird1.FeatherColor = "Brown";
            bird1.LaysEggs = true;
            bird1.IsDiurnal = true;
            Console.WriteLine($"It may come as a surprise to you, but the {bird1.Species} has a {bird1.BeakLength} beak, {bird1.FeatherColor} feathers, and {bird1.EyeColor} eyes.");

            Console.WriteLine($"Here are some more quick facts about them!\n");

            Console.WriteLine($"Do they posses feet?: \n{bird1.HasFeet}");
            Console.WriteLine($"Are they active during the daytime?: \n{bird1.IsDiurnal}");
            Console.WriteLine($"Can they fly?: \n{bird1.CanFly}");
            Console.WriteLine($"Do they lay eggs?: \n{bird1.HasFeet}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Console.WriteLine();
            Console.WriteLine("Now let's look at a certain Reptillian");
            Console.WriteLine();

            Reptile reptile1 = new Reptile();
            reptile1.HasFeet = false;
            reptile1.Species = "Boa Constrictor";
            reptile1.EyeColor = "Brown, but can appear Blue sometimes";
            reptile1.IsDiurnal = false;
            reptile1.IsColdBlooded= true;
            reptile1.ScaleColor = "Gray, Brown, or Cream";
            reptile1.FertalizeEggsInternally = true;
            reptile1.IsEctothermic = true;
            Console.WriteLine($"Contrary to popular belief, not all animals possess feet. \nThe {reptile1.Species} being a snake, means they never have feet to move around with.\n" +
                $"It's eye color can be {reptile1.EyeColor}, and it's scale colors can be {reptile1.ScaleColor}. \n" +
                $"Now let's fact-check!\n");
            Console.WriteLine($"Do they posses feet?: \n{reptile1.HasFeet}");
            Console.WriteLine($"Are they active during the daytime?: \n{reptile1.IsDiurnal}");
            Console.WriteLine($"Are they cold-blooded creatures?: \n{reptile1.IsColdBlooded}");
            Console.WriteLine($"Do they fertalize their eggs internally?: \n{reptile1.FertalizeEggsInternally}");
            Console.WriteLine($"Is it true that their main source of heat comes from their environment?: \n{reptile1.IsEctothermic}");



        }
    }
}
