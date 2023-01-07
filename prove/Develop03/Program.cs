using System;

class Program
{
    static void Main(string[] args)
    {
        //Inputs
        Console.Write("Enter the book: ");
        string userBook = Console.ReadLine();
        Console.Write("Enter the chapter of the book: ");
        string userChapter = Console.ReadLine();
        Console.Write("Enter the first verse of the chapter: ");
        string userVerseF = Console.ReadLine();
        Console.Write("Enter the last verse of the chapter: (Press 'N' if there isn't) ");
        string userVerseL = Console.ReadLine().ToLower();
        Console.Write("Enter your scripture: ");
        string userPhase = Console.ReadLine();

        //Create new objetcs for the reference, the scripture, and the domain
        Reference referenceStructure = new(userBook, userChapter, userVerseF, userVerseL);
        string reference = referenceStructure.GetCompleteReference();
        Scripture scritureStructure = new Scripture(userPhase);
        string scripture = scritureStructure.GetCompleteScripture();
        Domain domain = new Domain(reference, scripture);
        string CompletePhrase = domain.FraseJunta();


        List<string> lista = new();
        lista = scripture.Split(" ").ToList();

        //A list will change to "-" 
        List<string> listWithSlash = new();
        bool condition = true;


        Console.WriteLine($"Original quote: {CompletePhrase}");
        while (lista.Any(s => !s.All(c => c == '-')) && condition)
        {
            //Create a random library to change the place of the word will turn to "-"
            Random rnd = new Random();
            int index = rnd.Next(0, lista.Count); //0, max elements in the list (range)
            string word = lista[index];

            string newWord = "";

            //Do the action to all the letters of the word
            for (int i = 0; i < word.Length; i++)
            {
                newWord += "-";
            }

            lista[index] = newWord;

            string UltimatePhase = string.Empty;
            for (int i = 0; i < lista.Count; i++)
            {
                UltimatePhase += lista[i].ToString() + " ";
            }

            Console.WriteLine($"Updated quote: {reference} {UltimatePhase}");

            Console.WriteLine("If you want to continue press the 'Enter' otherwise type 'Exit' ");
            string response = Console.ReadLine().ToLower();

            if (response == "exit")
            {
                //Change the concition to stop the loop and print the last message
                condition = false;
            }
            Console.Clear();
        }

        listWithSlash.Add(reference + " ");

        for (int i = 0; i < lista.Count; i++)
        {
            listWithSlash.Add((string)lista[i] + " ");
        }

        foreach (var item in listWithSlash)
        {
            Console.Write($"{item}");
        }

        //Clean the console and print the final last output */
        Console.Clear();
        Console.WriteLine($"Original quote: {CompletePhrase}");

    }
}