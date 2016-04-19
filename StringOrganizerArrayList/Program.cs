using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayCollections
{
    class Program
    {
        static public ArrayList OrganizeStrings(string[] strings)
        {
            ArrayList stringList = new ArrayList();
            stringList.AddRange(strings);
            stringList.Sort();
            return stringList;
        }

        static public int[] ReverseSequence(int[] intArray)
        {
            Stack reverser = new Stack();
            foreach (int num in intArray)
            {
                reverser.Push(num);
            }
            int[] result = new int[reverser.Count];
            for (int i = 0; i < result.GetUpperBound(0); i++)
            {
                result[i] = (int) reverser.Pop();
            }
            return result;
        }

        static public string ConvertNumbersInText(string text)
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>();
            numbers.Add("one", "1");
            numbers.Add("two", "2");
            numbers.Add("three", "3");
            numbers.Add("four", "4");
            numbers.Add("five", "5");
            numbers.Add("six", "6");
            numbers.Add("seven", "7");
            numbers.Add("eight", "8");
            numbers.Add("nine", "9");
            numbers.Add("zero", "0");

            foreach (var num in numbers)
            {
                text = text.Replace(num.Key, num.Value);
            };

            return text;
        }

        static void Main(string[] args)
        {
            string[] test = new string[3] {"c", "a", "b"};
            ArrayList stringList = OrganizeStrings(test);
            Console.WriteLine("sorted strings: ");
            foreach (string item in stringList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] reversedNumbers = ReverseSequence(numbers);
            Console.WriteLine("reversed int sequence: ");
            foreach (int num in reversedNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("");

            string text = "one go home two pull yourself together six six nine";
            Console.WriteLine("changing alphabetic numbers to numeric in the following: {0}", text);
            Console.WriteLine(ConvertNumbersInText(text));
            Console.WriteLine("");

            Console.ReadKey();

        }
    }
}
