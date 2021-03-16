using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            Logics logics = new Logics();
            logics.divisibleBy3and5();
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();

            Console.WriteLine(logics.reverseString(str));

        }

        public class Logics
        {
            public void divisibleBy3and5()
            {
                string result = string.Empty;
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine(i + " fizzbuzz");
                    else if (i % 5 == 0)
                        Console.WriteLine(i + " buzz");
                    else if (i % 3 == 0)
                        Console.WriteLine(" fizz");
                }
            }

            public string reverseString(string strValue)
            {
                string reverseStr = string.Empty;
                if (!string.IsNullOrEmpty(strValue))
                {
                    char[] chars = strValue.ToCharArray();

                    for (int i = chars.Length - 1; i >=0;i--)
                        reverseStr += chars[i].ToString();
                }
                return reverseStr;
            }
        }
        

    }
}
