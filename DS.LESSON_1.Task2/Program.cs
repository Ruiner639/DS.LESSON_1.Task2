using System;

namespace DS.LESSON_1.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Write a C# Sharp Program to display the following pattern using the alphabet";
            string[] list = str.Split(" ");
            int max = 0, a = 0, result = 0;
            while (a < list.Length)
            {
                if (list[a].Length > max)
                {
                    max = list[a].Length;
                    result = a;
                }
                a++;
            }
            Console.WriteLine(list[result]);
        }
    }
}
