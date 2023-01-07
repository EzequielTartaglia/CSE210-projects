using System;

class Program
{
    static void Main(string[] args)
    {

Console.Write("Enter the book: ");
string userBook = Console.ReadLine();
Console.Write("Enter the chapter of the book: ");
string userChapter = Console.ReadLine();
Console.Write("Enter the first verse of the chapter: ");
string userVerseF = Console.ReadLine();
Console.Write("Enter the last verse of the chapter: (Press 'N' if there isn't) ");
string userVerseL = Console.ReadLine().ToLower();
Reference referenceStructure = new(userBook, userChapter, userVerseF, userVerseL);
string reference = referenceStructure.GetCompleteReference();
Console.Write("Enter your scripture: ");
string userPhase = Console.ReadLine();
Scripture scritureStructure = new Scripture(userPhase);
string scripture = scritureStructure.GetCompleteScripture();

Domain domain = new Domain(reference, scripture);
string CompletePhrase = domain.FraseJunta();


List<string> lista = new();
lista = scripture.Split(" ").ToList();

List<string> listWithSlash = new();
bool condition = true;


Console.WriteLine($"Original quote: {CompletePhrase}");
while (lista.Any(s => !s.All(c => c == '-')) && condition)
{
    Random rnd = new Random();
    int index = rnd.Next(0, lista.Count);
    string word = lista[index];

    string newWord = "";

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
        condition = false;
        Console.WriteLine($"The last instance reached was:");
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

Console.WriteLine($"Original quote: {CompletePhrase}");

    }
}