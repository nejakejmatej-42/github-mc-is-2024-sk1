using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main() {
        Console.Write("Zadejte diferenci (cele cislo): ");
        int number;  
        while(!int.TryParse(Console.ReadLine(), out number)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Prvni cislo musi byt celociselne");
        }
        int suma = 0;
        int numberBackup = number;
        int digit;
        int multi = 1;

        while (number >= 10){
            digit = number % 10;
            number = (number - digit)/10;
            Console.WriteLine("Digit = {0}", digit);
            suma = suma + digit;
            multi = multi * digit;
        }

        Console.WriteLine();
        Console.WriteLine("Soucet cifer cisla: {0} je {1}", numberBackup, suma);
        Console.WriteLine("Soucet cifer cisla: {0} je {1}", numberBackup, multi);
    

        }

     }  
 
