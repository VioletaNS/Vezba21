using System;


namespace G7Cas21
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** while
            int a = 10;
            while(a <20)
            {
                Console.WriteLine(" A = {0}", a);
                a++;
                
            }
            Console.WriteLine("Out of the loop");

            //*** for
            for(int i =0; i <50; i= i + 5)
            {
                Console.WriteLine("for loop  | i = {0}", i);
            }

            // *** do .. while


            Console.ReadKey();
        }
    }
}
