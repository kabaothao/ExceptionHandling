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
            catch (Exception ex)
            {
                Console.WriteLine("You cannot divide by 0.");
            }
            finally
            {
                Console.WriteLine();
            }



        }
    }
}


/*
 you should always have a global exception handling block in your application.


Target site is the method where the exception happened.

So these four properties are really common when working with exceptions.

Inner exception represents an exception that could be inside this exception.



So why do we need finally block?

In.NET, we have classes that access unmanaged resources.

What do I mean by unmanaged resources,

that is resources that are not managed by CLR,

so there is no garbage collection applied to them.

Examples are file handles,

database connections, network connections,

graphic handles and in situations like that we need to manually do the cleanup.

 */