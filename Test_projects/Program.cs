using System;

namespace Test_projects
{
    class Program
    {
        static void Main(string[] args)
        {

            var total =  new int[50];
            for(var i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    total[i] = i;
                    Console.WriteLine(total);
                }
            }

        }
    }
}
