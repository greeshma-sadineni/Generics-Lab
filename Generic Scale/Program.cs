using System;

namespace Generic_Scale
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> s = new Scale<int>(3,3);
         

           Console.WriteLine(s.GetHeavier());
            Scale<int> s1 = new Scale<int>(3, 4);
            Console.WriteLine(s1.GetHeavier());
            Scale<string> s2 = new Scale<string>("rajiiii", "raji") ;
            Console.WriteLine(s2.GetHeavier());

        }
    }
}
