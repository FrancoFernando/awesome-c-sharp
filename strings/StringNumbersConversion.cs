namespace Strings
{
    public class StringNumbersConversion
    {
        public static void Run()
        {
            ConvertNumberToString();
            ConvertStringToNumber();
            ConvertStringToNumberWithTryParse();
            ConvertNumberToCharArray();
        }
        public static void ConvertNumberToString()
        {
            Console.WriteLine($"Run {nameof(ConvertNumberToString)}");
            int number = 1234;
            string result = number.ToString();
            Console.WriteLine(result);
        }

        public static void ConvertStringToNumber()
        {
            Console.WriteLine($"Run {nameof(ConvertStringToNumber)}");
            string number = "1234";
            int result = int.Parse(number);
            Console.WriteLine(result);
        }

        public static void ConvertStringToNumberWithTryParse()
        {
            Console.WriteLine($"Run {nameof(ConvertStringToNumberWithTryParse)}");
            string number = "1234";
            int result;
            if (int.TryParse(number, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }

        // convert to char array if you neef to manipulate individual characters
        public static void ConvertNumberToCharArray()
        {
            Console.WriteLine($"Run {nameof(ConvertNumberToCharArray)}");
            string text = "1234";
            char[] digits = text.ToCharArray();
            foreach (var digit in digits)
            {
                Console.Write($"{digit} ");
            }
            Console.WriteLine();
        }
    }
}