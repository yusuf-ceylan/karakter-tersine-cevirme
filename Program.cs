using System;

namespace karakter_tersten_yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni giriniz: ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Metnin tersine çevrilmiş hali: " + ReverseStringValue(inputValue));
        }

        public static string ReverseStringValue(string input)
        {
            string[] inputArray = input.Split(' ');
            string output = "";

            foreach (var item in inputArray)
            {
                char[] charArray = item.ToCharArray();
                Array.Reverse(charArray);

                string reverseValue = new string(charArray);

                output += reverseValue + " ";
            }
            return output;
        }
    }
}
