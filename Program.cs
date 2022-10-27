// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = { "Pasta", "Formaggio", "Pizza", "Sushi", "Lasagne", "Cioccolata", "Nocciole", "Mandorle" };

//Stampa della lunghezza dell'array
Console.WriteLine(cibiPreferiti.Length);

//Stampa della lista dei cibi
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i] + ", posizione: " + i);
}

//Stampa del cibo più preferito
Console.WriteLine("Cibo top: " + cibiPreferiti.First());

//Stampa del cibo meno preferito
Console.WriteLine("Cibo bottom: " + cibiPreferiti.Last());

//Se il numero degli elementi nell'array è dispari
//float y = cibiPreferiti.Length / 2;
//Console.WriteLine("Cibo middle: " + Math.Floor(y));

//Se il numero degli elementi nell'array è pari
int x = cibiPreferiti.Length / 2;
Console.WriteLine("Posizione cibo mediano se pari: " + (x - 1) + ", " + x);
Console.WriteLine("Cibo mediano se pari: " + cibiPreferiti[x-1] + ", " + cibiPreferiti[x]);


