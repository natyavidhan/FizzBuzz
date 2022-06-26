using System;
class FizzBuzz{
    public static void Main()
    {
        for(int i = 1; i <= 100; i++)							
        {
            if (i%3==0 && i%5==0)
                Console.Write("FizzBuzz\n");
            else if (i%3==0)	
                Console.Write("Fizz\n");
            else if (i%5==0)											
                Console.Write("Buzz\n");
            else
                Console.Write(i + "\n");					
        }
    }
}