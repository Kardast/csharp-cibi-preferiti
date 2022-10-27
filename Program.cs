// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");

//string[] cibiPreferiti = { "Pasta", "Formaggio", "Pizza", "Sushi", "Lasagne", "Cioccolata", "Nocciole", "Mandorle" };

////Stampa della lunghezza dell'array
//Console.WriteLine(cibiPreferiti.Length);

////Stampa della lista dei cibi
//for (int i = 0; i < cibiPreferiti.Length; i++)
//{
//    Console.WriteLine(cibiPreferiti[i] + ", posizione: " + (i+1));
//}

////Stampa del cibo più preferito
////Console.WriteLine("Cibo top: " + cibiPreferiti.First());
//Console.WriteLine("Cibo top: " + cibiPreferiti[0]);

////Stampa del cibo meno preferito
////Console.WriteLine("Cibo bottom: " + cibiPreferiti.Last());
//Console.WriteLine("Cibo bottom: " + cibiPreferiti[cibiPreferiti.Length - 1]);

//if (cibiPreferiti.Length % 2 == 0)
//{
//    //pari
//    int ySup = cibiPreferiti.Length / 2;
//    int yInf = ySup - 1;
//    Console.WriteLine("Cibo middle: " + cibiPreferiti[yInf] + ", " + cibiPreferiti[ySup]);
//}
//else
//{
//    //dispari
//    int y = cibiPreferiti.Length / 2;
//    Console.WriteLine("Cibo middle: " + cibiPreferiti[y]);
//}

//Se il numero degli elementi nell'array è dispari
//float y = cibiPreferiti.Length / 2;
//Console.WriteLine("Cibo middle: " + Math.Floor(y));

//Se il numero degli elementi nell'array è pari
//int x = cibiPreferiti.Length / 2;
//Console.WriteLine("Posizione cibo mediano se pari: " + (x - 1) + ", " + x);
//Console.WriteLine("Cibo mediano se pari: " + cibiPreferiti[x-1] + ", " + cibiPreferiti[x]);


//Istruzioni condizionali

//Snack1.

//L’utente inserisce due numeri in successione.
//Console.WriteLine("Inserisci il primo numero");
//int firstNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("il tuo primo numero è: " + firstNum);

//Console.WriteLine("Inserisci il secondo numero");
//int secondNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("il tuo secondo numero è: " + secondNum);

////Il software stampa il maggiore.
//if (firstNum > secondNum)
//{

//Console.WriteLine("il numero più grande è: " + firstNum);
//}
//else
//{
//    Console.WriteLine("il numero più grande è: " + secondNum);
//}


//Snack2.

//L’utente inserisce due parole in successione.
//Console.WriteLine("Inserisci la prima parola");
//string firstWord = Console.ReadLine();
//Console.WriteLine("la tua prima parola è: " + firstWord);

//Console.WriteLine("Inserisci la seconda parola");
//string secondWord = Console.ReadLine();
//Console.WriteLine("la tua seconda parola è: " + secondWord);

////Il software stampa prima la parola più corta, poi la parola più lunga.
//if (firstWord.Length < secondWord.Length)
//{

//    Console.WriteLine("la parola più corta è: " + firstWord + ", la parola più lunga è: " + secondWord);
//}
//else
//{
//    Console.WriteLine("la parola più corta è: " + secondWord + ", la parola più lunga è: " + firstWord);
//}


//Ciclo for

//Snack3.

//Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.
int y = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("inserisci un numero");
    int x = Convert.ToInt32(Console.ReadLine());
    y += x;
}
Console.WriteLine("La somma dei tuoi numeri è: " + y);

//Snack4.

//Calcola la somma e la media dei numeri da 2 a 10.
