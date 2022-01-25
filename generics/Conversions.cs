/*
 
💜 C#: as operator 💜


You can do exception free conversions between reference types using "as":


➤ handy for converting nullable types


➤ return the object if compatible, null otherwise


➤ mostly replaced by the is operator, but common in existing code

----------------------------------------

💜 C#: is operator 💜

You can check if the run-time type of an object is compatible with a given type with "is":


➤ return true if compatible, false otherwise


➤ combined with a variable can also perform type conversion without exceptions

----------------------------------------

*/


using System;

namespace Inheritance
{
    class Base { }

    class Derived : Base { }

    class WeirdType : Base { }

    class Conversions
    {
        // converting nullable types
        static void PrintAsInt(object o)
        {
            int? nullable = o as int?;
            Console.WriteLine(nullable.HasValue ?
            nullable.Value.ToString() : "null");
        }

        // downcasting a type
        public static void MightDowncast(Base b)
        {
            var d = b as Derived;

            if (d != null)
            {
                // ... do some logic with d
                Console.WriteLine("b compatible with d");
            }
            Console.WriteLine("b not compatible with d");
        }

        public static void UseIsOperator(Base b)
        {
            if (!(b is WeirdType))
            {
                // ... do the processing that everything except WeirdType requires
            }

            //better than "as", don't require null check
            if (b is Derived d)
            {
                // ... do some logic with d
                Console.WriteLine("b compatible with d");
            }
        }

        static void Main(string[] args)
        {
            PrintAsInt(2);
            PrintAsInt("my string");

            Base b = new Derived();
            MightDowncast(b);
            UseIsOperator(b);
        }
    }
}
