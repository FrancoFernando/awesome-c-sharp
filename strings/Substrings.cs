namespace Strings {

    public class Substrings {

        public static void Run() {
            BasicSubstring();
            ConcatenateWithSubstring();
        }
        public static void BasicSubstring() {
            Console.WriteLine($"Run {nameof(BasicSubstring)}");
            string text = "Hello, World!";
            string subtext = text.Substring(7); //when no length is specifeid, it takes the rest of the string
            Console.WriteLine(subtext);
            subtext = text.Substring(7, 5);
            Console.WriteLine(subtext);

            try {
                subtext = text.Substring(7, 10); //throws exception because lengh is greater than the length of the string
                Console.WriteLine(subtext);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        // use substring to concatenate two parts of a string and add a character in between
        public static void ConcatenateWithSubstring() {
            Console.WriteLine($"Run {nameof(ConcatenateWithSubstring)}");
            string text = "Hello, World!";
            string subtext1 = text.Substring(0, 5);
            string subtext2 = text.Substring(7);
            string result = subtext1 + "New" + subtext2;
            Console.WriteLine(result);
        }
    }
}