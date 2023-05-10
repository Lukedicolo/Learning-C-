using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax

        /// <summary>
        /// This is the main sample application function.
        /// </summary>
        /// <param name='args'> An array of string arguments from command line. </param>
        /// <returns>
        /// No return value.
        /// </returns>
        
        static void Main(string[] args)
        {
            // Single line comments start with 2 slashes: "//"
            // Can have as many of these as you want.
            Console.WriteLine("Hello World!");
            /* Multi line comments start with "/*",
            they continue for multiple lines,
            until closing * and / are encounted... */


        }
    }
}
