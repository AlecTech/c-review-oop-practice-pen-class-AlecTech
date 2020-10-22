using System;
using System.Collections.Generic;
using System.Text;

namespace oct21PenClassPractice
{
    class Pen
    {
        // In-Class Practice:
        // Add an "Ink" property. Validate that the incoming "value" is greater than or equal to zero before setting the backing variable.
        // If it is not, throw an Exception.


        // Public items can be seen anywhere.
        // Auto-Implemented Property (Automatically generates a default "getter" (accessor) and "setter" (mutator).
        // AccessModifier DataType PropertyName { get; set; }
        public string Brand { get; set; }

        public string Color { get; set; }

        // private bool _haslid;

        
        public bool HasLid { get; set; }

       

        public double MaxInk { get; set; } 

        private double _inklevel;

        public double InkGange
        {
            get
            {
                return _inklevel;
            }
            set
            {
               if (value <= 0)
              {
                    _inklevel = 0;
                    //throw new Exception("Ink must be greater than zero.");
               }
              else if (value > MaxInk)
               {
                    _inklevel = MaxInk;
              }
              else

                _inklevel = value;
            }
        }

        public void Write()
        {
            Console.Write("Please type something to reduse ink: ");
            string stringInput = Console.ReadLine();
            int count = stringInput.Length;

            InkGange = InkGange - (count*0.05);
        }
       
        public void Write(int charactercount)
       {
            
           InkGange = InkGange - charactercount;
        }
        // Default Constructor - Takes no parameters, and sets default values for the properties.
        public Pen()
        {
            Brand = "Bic";
            Color = "Red";
            InkGange = 10;
        }

        // Greedy Constructor - Takes paramaters for all properties.
        public Pen(string brandName, string colorName, double level)
        {
            Brand = brandName;
            Color = colorName;
            InkGange = level;
        }
    }
}