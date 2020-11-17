using System;


namespace G7Cas21
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** while
            int a = 10;
            while(true)
            {
                Console.WriteLine(" A = {0}", a);
                a++;
                break;
            }
            Console.WriteLine("Out of the loop");

            //*** for
            for(int i =0; i <10; i++)
            {

            }

            Console.ReadKey();
        }
    }
}
