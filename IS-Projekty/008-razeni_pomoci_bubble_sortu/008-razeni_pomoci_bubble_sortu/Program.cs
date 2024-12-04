﻿using System;
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

        int myCompare = 0;
        int myChange = 0;

        Stopwatch myStopwatch = new Stopwatch();
        myStopwatch.Start();
        for (int i = 0; i < n - 1; i++){
            for (int j = 0; j < n - i - 1; j++){
                myCompare++;
                if (myArray[j] < myArray[i]) {
                    int tmp = myArray[i + j];
                    myArray[i + j] = myArray[j];
                    myArray[j] = tmp;
                    myChange++;
                }
            }
        }
        myStopwatch.Stop();
        Console.WriteLine("Serazene pole");
        for (int i = 0; i<n; i++){
            Console.Write("{0}: ", myArray);
        }
        Console.WriteLine("Cas potrebny k serazeni {0}", myStopwatch.Elapsed);
        Console.WriteLine("Pocet porovnani {0}", myCompare);
        Console.WriteLine("Pocet zmen {0}", myChange );
    } 
}