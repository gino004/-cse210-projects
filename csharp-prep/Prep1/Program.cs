using System;

class Program
{
    static void Main(string[] args)
    
    {
        // conlose write sirve para hacer una entrada de dato
        Console.Write("What is your first name? ");
        // string first es para hacer uso final de la console write en la salida y al igual que abajo es el mismo proceso
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last},{first} {last}.");
    }
}