using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Greeting
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //The number of user
        int userNumber = -1;
        //Sum counter (total)
        int totalSum = 0;
        
        int largestNumber = 0;

        //List of numbers
        List<int> numbers = new List<int>();

        //Ask for a number and do a loop until the userNumber will be 0
        do
        {
          //Get a number
          Console.Write("Enter number: ");
          string number = Console.ReadLine();
          userNumber = int.Parse(number);

            //Add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
          

        } while (userNumber != 0);
    
        //For each element inside the list
        foreach (int number in numbers)
        {
            //Acumulate the total
            totalSum = totalSum + number;

            //Get the largest number (if the number is higher than largest number
            //receive that value)
            if(number > largestNumber){
                largestNumber = number;
            }
        }

        //Print the total (sum)
        Console.WriteLine($"The sum is: {totalSum}");

        
        //Average of total(convert to float to be more exacly number)
        float average;

        if (totalSum > 0){
            average = ((float)totalSum) / numbers.Count;
        }
        else{
            average = 0;  
        }
        Console.WriteLine($"The average is: {average}");

        //Find the largest number (highest)
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
       
}