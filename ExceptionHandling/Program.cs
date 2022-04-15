using System;

namespace ExceptionHandling // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))  //So, the Using statement is the preferred way as opposed to creating a finally block and calling the Dispose method.
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred");
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


You have seen the try block,

you have seen the catch block,

you have seen multiple occurrences of the catch blocks from the most

specific to most generic ones and you have also seen the finally block.

But how can we create and throw custom exceptions?

And in what scenarios do we need that?

Take a look at this YouTube.Api class I have implemented here.



 */