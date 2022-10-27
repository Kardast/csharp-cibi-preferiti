// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = { "Pasta", "Formaggio", "Pizza", "Sushi", "Lasagne", "Cioccolata", "Nocciole", "Mandorle" };

//Stampa della lunghezza dell'array
Console.WriteLine(cibiPreferiti.Length);

//Stampa della lista dei cibi
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i] + ", posizione: " + (i+1));
}

//Stampa del cibo più preferito
//Console.WriteLine("Cibo top: " + cibiPreferiti.First());
Console.WriteLine("Cibo top: " + cibiPreferiti[0]);

//Stampa del cibo meno preferito
//Console.WriteLine("Cibo bottom: " + cibiPreferiti.Last());
Console.WriteLine("Cibo bottom: " + cibiPreferiti[cibiPreferiti.Length - 1]);

if (cibiPreferiti.Length % 2 == 0)
{
    //pari
    int ySup = cibiPreferiti.Length / 2;
    int yInf = ySup - 1;
    Console.WriteLine("Cibo middle: " + cibiPreferiti[yInf] + ", " + cibiPreferiti[ySup]);
}
else
{
    //dispari
    int y = cibiPreferiti.Length / 2;
    Console.WriteLine("Cibo middle: " + cibiPreferiti[y]);
}

//Se il numero degli elementi nell'array è dispari
//float y = cibiPreferiti.Length / 2;
//Console.WriteLine("Cibo middle: " + Math.Floor(y));

//Se il numero degli elementi nell'array è pari
//int x = cibiPreferiti.Length / 2;
//Console.WriteLine("Posizione cibo mediano se pari: " + (x - 1) + ", " + x);
//Console.WriteLine("Cibo mediano se pari: " + cibiPreferiti[x-1] + ", " + cibiPreferiti[x]);


