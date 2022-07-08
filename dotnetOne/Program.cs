using System;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // oneTo255();
            // oneTo100div3();
            oneTo100div3();
        }

        public static void oneTo255() 
        {
            for(int i=0; i<=255; i++)
            {
                Console.WriteLine($"I is {i}");
            }
        }

        public static void oneTo100div3()
        {
            int i = 1;
            while(i<=100)
            {
                if(i%3==0 )
                {
                    Console.WriteLine($"Fizz");
                }
                if(i%5==0)
                {
                    Console.WriteLine($"Buzz");
                }
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine($"FizzBuzz");
                }
                i++;
            }

        }
    }
}

