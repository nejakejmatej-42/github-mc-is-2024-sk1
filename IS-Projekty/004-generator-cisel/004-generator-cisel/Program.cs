﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main() {
        /*Console.Write("Zadejte vysku (cele cislo): ");
        int height;  // leva strana aka vyska
        while(!int.TryParse(Console.ReadLine(), out height)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Prvni cislo musi byt celociselne");
        }
        Console.Write("Zadejte sirku (cele cislo): ");
        int width;  //sirka
        while(!int.TryParse(Console.ReadLine(), out width)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Prvni cislo musi byt celociselne");
        }
        
        /*
        for ( int i = 1; i <= 10; i++){
            Console.WriteLine(i);
        }
        int j = 1;
        while (j <=10){
            Console.WriteLine(j);
            j++;

        } */
        //provede se dokud nesplni podminku zadanou uzivatelem, napr 6 + pokazde kdyz se zopakuje, zvysi se hodnota cisla i
        //zaciname od 1 aby se splnila podminka druheho cyklu, ktery napise prvni hvezdicku 
        //<= pouzivame, abychom dostali i posledni zadany radek
        /*for (int i = 1; i <= height; i++)
        {
            //cyklus, ktery tiskne hvezdicku, kdyz je j < i, tudiz pokud je i = 1 a j = 0, provede se
            //(vypise jednu hvezdicku, protoze splnil podminku) a zvysi se pokazde jeho hodnota obou cyklu, protoze uz jednou,
            //probehli pokud je i = 2 a j = 1, provede se 2x aka 0,1 atd
            for (int j = 0; j < i; j++)
            {

                //kontroluje, zda je j < nez zadana sirka, pokud by bylo i = 10 a j = 5, vypise hvezdicky pro j=5, protoze
                //splnuje podmku j je < 5 a to i ukazdeho dale provedeneho cyklu, takze se pak vypise 6 radek o 6 hvezdickach
                //od nuly 
                if (j <= width)
                {
                    Console.Write('*'); //napise hvezdicku na stejny radek
                    System.Threading.Thread.Sleep(500);
                }*/

        Console.Write("Zadejte  pocet generovanych cisel (cele cislo): ");
        int number;  
        while(!int.TryParse(Console.ReadLine(), out number)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Nezadali jste cele cislo, znovu zadej pocet generovanych cisel");
        }

        Console.Write("Zadejte dolni mez (cele cislo): ");
        int dolniMez;  
        while(!int.TryParse(Console.ReadLine(), out dolniMez)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Prvni cislo musi byt celociselne. Zadej dolni mez znovu");
        }

        Console.Write("Zadejte horni mez (cele cislo): ");
        int horniMez;  
        while(!int.TryParse(Console.ReadLine(), out horniMez)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Prvni cislo musi byt celociselne. Zadej horni mez znovu");
        }
        Console.WriteLine("Pocet cisel: {0}, dolni mez {1}, horni mez {2}.", number, dolniMez, horniMez);

        int[] myArray = new int[number];
        int kladna = 0;
        int zaporna = 0;
        int nuly = 0;
        int suda = 0;
        int licha = 0;
        int max = myArray[0];
        int min = myArray[0];
        int poziceMin = 0;
        int poziceMax = 0;

        Random randomNumber = new Random();
        Console.WriteLine("\n\nNahodna cisla");
        


        for(int i= 1; i < number; i++){
            myArray[i] = randomNumber.Next(dolniMez, horniMez);
            Console.WriteLine("{0}", myArray[i]);

            //max, minumum
            if(myArray[i] > max){
                max = myArray[i];
            }
            else if (myArray[i] < max){
                min = myArray[i];
            }
            
            //jake to je cislo
            if(myArray[i]>0)
                kladna++;
            else if (myArray[i]<0)
                zaporna++;
            else 
                nuly++;

            //sudost, lichost
            if(myArray[i] % 2 == 0)
                suda++;
            else
                licha++;

            //kde se cislo nachazi
            if (myArray[i] > max) {
                max = myArray[i];
                poziceMax = i;
            } 
            else if (myArray[i] < min) {
                min = myArray[i];
                poziceMin = i;
    }
        }
        Console.WriteLine();
        Console.WriteLine("Cislo maximalni: {0}", max);
        Console.WriteLine("Pozice max: {0}", poziceMax);
        Console.WriteLine("Cislo minimum: {0}", min);
        Console.WriteLine("Pozice min: {0}", poziceMin);
        Console.WriteLine("Pocet kladnych cisel: {0}", kladna);
        Console.WriteLine("Pocet zapornych cisel: {0}", zaporna);
        Console.WriteLine("Pocet nul: {0}", nuly);
        Console.WriteLine("Pocet sudych cisel: {0}", suda);
        Console.WriteLine("Pocet lichych cisel: {0}", licha);
    }
} 