using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldTest
{
    class Hello
    {
        static void main (string args[])
        {
            Console.WriteLine(CreateMessage());
        }

        public static string CreateMessage()
        {
            return "Hello World!";
        }
    }
}
