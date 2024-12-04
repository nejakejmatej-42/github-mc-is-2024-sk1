using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;

class Program
{
    static void Main() {

        Console.Write("Zadejte  pocet generovanych cisel (cele cislo): ");
        int n;  
        while(!int.TryParse(Console.ReadLine(), out n)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Nezadali jste cele cislo, znovu zadej pocet generovanych cisel");
        }
        Console.Write("Zadejte  pocet generovanych cisel (cele cislo): ");
        int dolniMez;  
        while(!int.TryParse(Console.ReadLine(), out dolniMez)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Nezadali jste cele cislo, znovu zadej pocet generovanych cisel");
        }
        Console.Write("Zadejte  pocet generovanych cisel (cele cislo): ");
        int horniMez;  
        while(!int.TryParse(Console.ReadLine(), out horniMez)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Nezadali jste cele cislo, znovu zadej pocet generovanych cisel");
        }

        int interval1 = 0;
        int interval2 = 0;
        int interval3 = 0;
        int interval4 = 0;
        int[] myArray = new int[n];
        
        Random randomNumber = new Random();
        Console.WriteLine("\n\nNahodna cisla");
        for(int i= 1; i < n; i++){
            myArray[i] = randomNumber.Next(dolniMez, horniMez);
            Console.WriteLine("{0}", myArray[i]);

            if ( myArray [i] <= (0.25 * horniMez)){
                interval1++;
            }
            else if ( myArray [i] <= (0.50 * horniMez)){
                interval2++;
            }
            else if ( myArray [i] <= (0.75 * horniMez)){
                interval3++;
            }
            else{
                interval4++;
            }
        }
        Console.WriteLine("Pocet cisel v intervalu <1,25>: {0}", interval1);
        Console.WriteLine("Pocet cisel v intervalu <26,50>: {0}", interval2);
        Console.WriteLine("Pocet cisel v intervalu <51,75: {0}", interval3);
        Console.WriteLine("Pocet cisel v intervalu <76,100>: {0}", interval4);
    } 
}