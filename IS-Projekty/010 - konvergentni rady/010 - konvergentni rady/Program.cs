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
        double presnost;  
        while(!double.TryParse(Console.ReadLine(), out presnost)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Nezadali jste cele cislo, znovu zadej pocet generovanych cisel");
        }
        
        double i = 1;
        double znamenko = 1;
        double piCtvrt = 1;

        while(1/i >= presnost){
            i = i + 2;
            znamenko = -znamenko;
            piCtvrt = piCtvrt + znamenko * (1/i);
            
        }

        if (znamenko == 1){
            Console.WriteLine("Zlomek: 1/{0}: aktualni hodnota Pi = 1", i, piCtvrt * 4);
        }
        else {
            Console.WriteLine("Zlomek: -1/{0}: aktualni hodnota Pi = 1", i, piCtvrt * 4);
        }

        Console.WriteLine("Zobrazeni Pi {0}", piCtvrt * 4);       
    }
            
}