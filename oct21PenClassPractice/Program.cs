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

            //https://docs.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=netcore-3.1
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            Console.Write("Please enter color of the pen to use: ");
            string colorinput = Console.ReadLine().Trim();
            pen.Color = string.IsNullOrWhiteSpace(colorinput) ? pen.Color : colorinput;
            //pen.Color = Console.ReadLine().Trim();

            Console.Write("Please set MAX Ink Level: ");
            string maxinkLevel = Console.ReadLine().Trim();
            int maxinkValue = 0;
            Int32.TryParse(maxinkLevel, out maxinkValue);

            pen.MaxInk = maxinkValue == 0 ? pen.MaxInk : maxinkValue;

            Console.Write("Please enter amount of ink you need: ");
            try
            {
                //https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=netcore-3.1
                string inkinput = Console.ReadLine().Trim();
                int inkValue = 0;
                Int32.TryParse(inkinput, out inkValue);

                pen.InkGange = inkValue == 0 ? pen.InkGange : inkValue;
                //pen.MaxInk = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message} Setting ink level to zero.");
                pen.InkGange = 0;
            }

            Console.Write("Does your pen has lid yes or no: ");

            string trueORfalse = Console.ReadLine().Trim().ToUpper();
            if(trueORfalse == "YES" || trueORfalse == "NO")
            {
                pen.HasLid = trueORfalse.Equals("YES") ? true : false ;
            }
            else
            {
                throw new Exception("MUST enter \"yes\" or \"no\".");
            }
            string doesNot = "does not";
            string does = "does";
            string lidPresent = pen.HasLid ? does : doesNot;

            Console.WriteLine($"This, {pen.Brand} pen with  {pen.Color} color, has {pen.InkGange} ml of ink and  {lidPresent} have lid and max ink Level is{pen.MaxInk}");

            pen.Write();

            Console.WriteLine($"You used up some of the ink. {pen.InkGange} ml of ink remaining!");
        }
    }
}