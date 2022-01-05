/*
 
Nullable values add nullability to value types.
Nullable references allow to distinguish between:
- references that may be null
- references that must not be

----------------------------------------

Nullable values

➤ introduced with C#2

➤ implemented through the wrapper struct Nullable<T>

➤ the struct extends the type with a flag saying if the type has a value or not

➤ the '?' operator shorts the syntax (e.g. int? instead of using Nullable<int>)

----------------------------------------

➤  assign null to a non-nullable value type causes a compiler error

➤ the HasValue() method returns true if the object has been assigned a value, false otherwise

➤ the GetValueOrDefault() method gets the actual value if it is not null or the default value if it is null

----------------------------------------

 2. Nullable references

➤ introduced with C#8

➤ not enabled by default, but require the '#nullable enable' context

➤ use the same syntax of nullable values ('?' operator)

➤ assign null to a non nullable reference causes a compiler warning

➤ dereferencing a nullable reference causes a compiler warning

➤ assign a reference that might be null to a non nullable reference causes a compiler warning

➤ the null forgiving operator ('!') converts a nullable to a non-nullable reference
 * */


using System;

#nullable enable

namespace Nullability
{
    class Program
    {

        static void Main()
        {
            // --> Nullable values

            Nullable<int> i = null;
            int? j = null;

            if (i.HasValue) 
                Console.WriteLine(i); 
            else
                Console.WriteLine("Null");

            if (j != null)
                Console.WriteLine(j);
            else
                Console.WriteLine("Null");

            // --> Nullable references

            string cantBeNull = "MyString";
            string? mayBeNull = null;

            Console.WriteLine(cantBeNull.Length);

            if (mayBeNull != null)
            {
                Console.WriteLine(mayBeNull.Length);
            }

            // Allowed because it checks for null and handles it
            Console.WriteLine(mayBeNull?.Length ?? 0);

            // This generates a warning in an enabled nullable context
            // Console.WriteLine(mayBeNull.Length);

            mayBeNull = "NotNull";

            // The null forgiving operator converts a nullable to a non-nullable reference
            string mayBeNullAnymore = mayBeNull!;

            Console.WriteLine(mayBeNullAnymore.Length);

            // Array are intialized with all 0s
            var nullableStrings = new string?[10];
            var nonNullableStrings = new string[10];
            Console.WriteLine(nullableStrings[0] == null);
            Console.WriteLine(nonNullableStrings[0] == null);
        }
    }
}
