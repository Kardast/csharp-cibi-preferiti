// See https://aka.ms/new-console-template for more information
using System;
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
//int y = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("inserisci un numero");
//    int x = Convert.ToInt32(Console.ReadLine());
//    y += x;
//}
//Console.WriteLine("La somma dei tuoi numeri è: " + y);

//Snack4.

//Calcola la somma e la media dei numeri da 2 a 10.
//int x = 0;
//for (int i = 2; i <= 10; i++)
//{
//    x += i;
//    Console.WriteLine("questa è x: " + x);
//}
//Console.WriteLine("la somma dei valori è: " + x);
//Console.WriteLine("la media dei valori è: " + x / 9);


//Operatore modulo

//Snack5.

//Il software chiede all’utente di inserire un numero.
//Console.WriteLine("Inserisci un numero");
//int x = Convert.ToInt32(Console.ReadLine());
//if (x % 2 == 0)
//{
//    //Se il numero inserito è pari, stampa il numero
//    Console.WriteLine("il tuo numero è pari: " + x);
//}
//else
//{
//    //se è dispari, stampa il numero successivo.
//    Console.WriteLine("il tuo numero è dispari: " + x + ", il numero successivo è: " + (x + 1));
//}

//Array

//Snack6.
//In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//string[] guests = { "Ika", "Sandro", "Edo", "Ale", "Simo" };
////Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
//Console.WriteLine("Inserisci il tuo nome");
//string name = Console.ReadLine();
//bool invited = false;

//for (int i = 0; i < guests.Length; i++)
//{
//    if (name == guests[i])
//    {
//        invited = true;
//        break;
//    }
//}

//if (invited == true)
//{
//    Console.WriteLine("Sei accettato alla festa!");
//}
//else
//{
//    Console.WriteLine("Non sei ammesso alla festa!");
//}


//Snack7.
//Crea un array vuoto.
//int[] arrayNum = new int[6];
////Chiedi per 6 volte all’utente di inserire un numero
//Console.WriteLine("Inserisci un numero: ");
//for (int i = 0; i < arrayNum.Length; i++)
//{
//    Console.WriteLine("il tuo array: ");
//    int myNum = Convert.ToInt32(Console.ReadLine());
//    //se è dispari inseriscilo nell’array
//    if (myNum % 2 != 0)
//    {
//        arrayNum[i] = myNum;
//    }
//}
//Console.WriteLine("il tuo array:");
//for (int i = 0; i < arrayNum.Length; i++)
//{
//    Console.WriteLine("Posizione" + i + ": " + arrayNum[i]);
//}


//Snack8.
//Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
//posizione dispari.
//int[] numbers = { 2, 3, 7, 10, 4, 6 };
//int sum = 0;
//for (int i = 1; i < numbers.Length; i+=2)
//{
//    sum += numbers[i];
//}
//Console.WriteLine("La somma è: " + sum);


//Snack9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
//somma degli elementi è minore di 50.
//int[] numeri = new int[50];
//int somma = 0;
//while (somma < 50)
//{
//    Console.WriteLine("Inserisci un numero");
//    somma += Convert.ToInt32(Console.ReadLine());
//}


//Random
//Snack10.Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.
//Console.WriteLine("Inserisci un numero");
//int N = Convert.ToInt32(Console.ReadLine());
//Random random = new Random();
//for (int i = 0; i < N; i++)
//{
//    int[] array = new int[10];
//    Console.WriteLine("L'array numero " + (i + 1) + " è: ");
//    for (int j = 0; j < 10; j++)
//    {
//        array[j] = random.Next(1, 100);
//        Console.Write(array[j] + "  ");
//    }
//    Console.WriteLine();
//}

//Snack 1
//Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.
//Console.WriteLine("Inserisci la prima parola");
//string firstWord = Console.ReadLine();

//Console.WriteLine("Inserisci la seconda parola");
//string secondWord = Console.ReadLine();

//myFunction(firstWord, secondWord);

//void myFunction(string firstWord, string secondWord)
//{
//    if (firstWord.Length == secondWord.Length)
//    {
//        Console.WriteLine("le tue parole sono: " + firstWord + ", " + secondWord);
//    }
//    else if(firstWord.Length > secondWord.Length)
//    {
//        Console.WriteLine("la tua parola più lunga è: " + firstWord);
//    }
//    else
//    {
//        Console.WriteLine("la tua parola più lunga è: " + secondWord);
//    }
//}


//Snack 2
//Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.
void pariDispari(int num)
{
    if(num % 2 == 0)
    {
        Console.WriteLine("il tuo numero è pari");
    }
    else
    {
        Console.WriteLine("il tuo numero è dispari");
    }
}
Console.WriteLine("inserisci un numero");
int num = Convert.ToInt32(Console.ReadLine());
pariDispari(num);