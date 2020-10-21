using System;

namespace oct21PenClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the object using the "new" keyword - generate an instance of a class / blueprint.
            Pen pen = new Pen();
            // The new object has all of the properties that are specified in the class, but they are tied to that object.
            // One object's properties cannot see another object's properties without explicitly passing the values.

            Console.Write("Please enter brand name of your pen: ");
            pen.FirstName = Console.ReadLine().Trim();

            Console.Write("Please enter color of the pen to use: ");
            pen.LastName = Console.ReadLine().Trim();

            Console.Write("Please enter amount of ink you need: ");
            try
            {
                pen.Ink = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message} Setting ink level to zero.");
                pen.Ink = 0;
            }

            Console.WriteLine($"This, {pen.FirstName} pen with  {pen.LastName} color, has {pen.Ink} ml of ink ");

            pen.Write();

            Console.WriteLine($"You used up some of the ink. {pen.Ink} ml of ink remaining!");
        }
    }
}