using System;

namespace Generic_Array_Creator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = ArrayCreator.Create(5, "Peter");
            int[] integers = ArrayCreator.Create(10, 33);

            Console.Read();
        }
    }
}
