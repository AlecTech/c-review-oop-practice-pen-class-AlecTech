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

            Console.Write("Please enter your first name: ");
            pen.FirstName = Console.ReadLine().Trim();

            Console.Write("Please enter your last name: ");
            pen.LastName = Console.ReadLine().Trim();

            Console.Write("Please enter your age: ");
            try
            {
                pen.Age = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message} Setting to zero.");
                pen.Age = 0;
            }

            Console.WriteLine($"Hello, {pen.FirstName} {pen.LastName} {pen.Age}!");

            pen.Birthday();

            Console.WriteLine($"You just had a birthday, you are now {pen.Age} years old.");
        }
    }
}