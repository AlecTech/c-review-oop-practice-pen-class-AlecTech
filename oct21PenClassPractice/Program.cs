using System;

namespace oct21PenClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();
         
            Console.Write("Please enter brand name of your pen: ");
            string brandinput = Console.ReadLine().Trim();
            pen.Brand = string.IsNullOrWhiteSpace(brandinput) ? pen.Brand : brandinput;

            Console.Write("Please enter color of the pen to use: ");
            string colorinput = Console.ReadLine().Trim();
            pen.Color = string.IsNullOrWhiteSpace(colorinput) ? pen.Color : colorinput;
            //pen.Color = Console.ReadLine().Trim();

            Console.Write("Please enter amount of ink you need: ");
            try
            {
                
                string inkinput = Console.ReadLine().Trim();
                int inkValue = 0;
                int.TryParse(inkinput, out inkValue);

                pen.MaxInk = inkValue == 0 ? pen.MaxInk : inkValue;
                //pen.MaxInk = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message} Setting ink level to zero.");
                pen.MaxInk = 0;
            }

            Console.WriteLine($"This, {pen.Brand} pen with  {pen.Color} color, has {pen.MaxInk} ml of ink ");

            pen.Write();

            Console.WriteLine($"You used up some of the ink. {pen.MaxInk} ml of ink remaining!");
        }
    }
}