using System;

namespace Test_projects
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Length:" + numbers.Length);

            var index = Array.IndexOf(numbers, 4);
            Console.WriteLine(index);

            var test = Array.Clear(numbers, 2, 2);

            Console.WriteLine(test);

        }
    }
}
