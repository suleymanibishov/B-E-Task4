using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetReverseStringName("Suleyman Semed Tural Mirqubad"));
        }
        static string GetReverseStringName(string str)
        {
            var strs = str.Split(' ');
            string newStr = "";
            foreach (var s in strs)
            {
                for (int i = s.Length-1; i >= 0; i--)
                {
                    newStr += s[i];
                }
                newStr += ' ';
            }
            return newStr;
        }
    }
}
