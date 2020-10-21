using System;
using System.Collections.Generic;
using System.Text;

namespace oct21PenClassPractice
{
    class Pen
    {
        // In-Class Practice:
        // Add an "Age" property. Validate that the incoming "value" is greater than or equal to zero before setting the backing variable.
        // If it is not, throw an Exception.


        // Public items can be seen anywhere.
        // Auto-Implemented Property (Automatically generates a default "getter" (accessor) and "setter" (mutator).
        // AccessModifier DataType PropertyName { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Age must be greater than, or equal to, zero.");
                }
                _age = value;
            }
        }

        public void Birthday()
        {
            // Any references to properties will reference the properties of the instance on which the method is called.
            Age += 1;
        }

        // Default Constructor - Takes no parameters, and sets default values for the properties.
        public Pen()
        {
            FirstName = "John";
            LastName = "Doe";
            Age = 20;
        }

        // Partial Constructror - Takes parameters for some properties, and defaults others.
        public Pen(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = 20;
        }

        // Greedy Constructor - Takes paramaters for all properties.
        public Pen(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        /*
        // Private items cannot be seen outside of the class. Marking it as private enforces that all data to be stored MUST go through the property.
        private string _lastName;
        // Fully-Implemented Property (You specify the beahviour for the "getter" (accessor) and "setter" (mutator).
        public string LastName { 
            get 
            {
                // For the getter, typically you will want to return the value from the backing variable.
                // You may format it first, etc. but that is not necessary.
                return _lastName;
            } 
            set 
            {
                // For the setter, typically you will want to assign the backing variable to the keyword "value" which represents what is being assigned to the property.
                // You may perform validation here as well.
                _lastName = value;
            } 
        }
        */
    }
}