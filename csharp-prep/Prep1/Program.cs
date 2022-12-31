using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();/* Space */
        
        /* Input to receive the first name */
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine(); /* Save variable */
        /* Input to receive the last name */
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine(); /* Save variable */


        Console.WriteLine();/* Space */

        /* Output*/
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

        Console.WriteLine();/* Space */
    }
}