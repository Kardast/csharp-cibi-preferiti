// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = { "Pasta", "Pizza", "Sushi", "Lasagne", "Cioccolata", "Nocciole", "Mandorle" };

Console.WriteLine(cibiPreferiti.Length);
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i] + ", posizione: " + i);
}

Console.WriteLine("Cibo top: " + cibiPreferiti.First());
Console.WriteLine("Cibo bottom: " + cibiPreferiti.Last());
