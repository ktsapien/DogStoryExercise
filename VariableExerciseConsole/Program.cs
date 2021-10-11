using System;

namespace VariableExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Dante";
            int dogAge = 7;
            char exclamation = '!';
            bool lovesNapping = true;
            double kissesPerDay = 80;
            decimal weight = 44.5m;


            Console.WriteLine($"My dog's name is {dogName}, she is {dogAge} years old{exclamation} She weighs {weight}lbs It is {lovesNapping} she loves napping. She gets {kissesPerDay} kisses per day");
        }
    }
}
