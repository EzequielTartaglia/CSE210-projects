using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();/* Space */
        
        /* Input to receive the first name */
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine(); /* Save variable */
        /* Input to receive the last name */
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine(); /* Save variable */


        Console.WriteLine();/* Space */

        /* Output*/
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        Console.WriteLine();/* Space */
    }
}