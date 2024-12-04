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


        int[] myArray = new int[n];
        
        Random randomNumber = new Random();
        Console.WriteLine("\n\nNahodna cisla");
        for(int i= 1; i < n; i++){
            myArray[i] = randomNumber.Next(dolniMez, horniMez);
            Console.WriteLine("{0}", myArray[i]);
        }

        for (int i = 0; i < n/2; i++){
            int tmp = myArray[i];
            myArray[i] = myArray[i-n-1];
            myArray[i-n-1] = tmp;
        }        

        Console.WriteLine();
        for (int i = 0; i<n; i++){
            Console.WriteLine("{0}", myArray[i]);
        }

    }
            
}