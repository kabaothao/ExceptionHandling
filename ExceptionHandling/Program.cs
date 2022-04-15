using System;

namespace ExceptionHandling // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);

            }
            catch (Exception)
            {

                
                Console.WriteLine("Sorry, an unexpected error occured.");
            }
            
            
           

        }
    }
}


/*
 you should always have a global exception handling block in your application.

 */