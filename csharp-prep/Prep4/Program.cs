using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Greeting
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //The number of user
        int userNumber;
        //Counter (total)
        int totalSum = 0;

        //List of numbers
        List<int> numbers = new List<int>();

        //Ask for a number and do a loop until the userNumber will be 0
        do
        {
          //Get a number
          Console.Write("Enter number: ");
          string number = Console.ReadLine();
          userNumber = int.Parse(number);

          //Add that number to the list
          numbers.Add(userNumber);

        } while (userNumber != 0);
    
        //For each element inside the list
        foreach (int number in numbers)
        {
            //Acumulate the total
            totalSum = totalSum + number;
        }

        //Print the total (sum)
        Console.WriteLine($"The sum is: {totalSum}");
    }
       
}