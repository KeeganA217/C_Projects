using System;
using System.Collections.Generic;

namespace Test_projects
{
    class Program
    {
        static void Main(string[] args)
        {

            var fullName = "Keegan Adams ";

            Console.WriteLine(fullName.ToLower());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(index);

            Console.WriteLine(index);
            Console.WriteLine(firstName.Trim()); ;
        }
    }
}
