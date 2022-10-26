namespace CodeChallenges2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            int runny = 0;
             //Console.WriteLine($"{a}\n{b}");

            //for (int i = 0; i <= 10; i++)
            //{
            //    c = a + b;
            //    a = c + b;
            //    b = a + c;
            //    //Console.WriteLine($"{c}\n{a}\n{b}");
            //    //if (a % 2 == 0 && b % 2 ==0 && c % 2 == 0)
            //    //{
            //    //c = a + b;
            //    //a = c + b;
            //    //b = a + c;

            //    //}
            //    Console.WriteLine($"{c}\n{a}\n{b}");
                
            //}
            do
            {


                a = b;
                b = c;
                c = a + b;
              
                if (c % 2 == 0)
                {
                Console.WriteLine(c);
                    runny += c;
                }
            } while (c <= 4000000);
            Console.WriteLine("The final sum = " + runny);
            
        }
    }
}