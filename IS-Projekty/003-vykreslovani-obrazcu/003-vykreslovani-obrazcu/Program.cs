using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main() {
        Console.Write("Zadejte diferenci (cele cislo): ");
        int height;  
        while(!int.TryParse(Console.ReadLine(), out height)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
        Console.Write("Prvni cislo musi byt celociselne");
        }
        Console.Write("Zadejte diferenci (cele cislo): ");
        int width;  
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
        for (int i = 1; i <= height; i++){
            for(int j = 1; j <= height; j++){
                Console.Write("*");
                System.Threading.Thread.Sleep(System.TimeSpan.FromSeconds(1));
                

            }
            Console.WriteLine("*");
        }

     } 
}
 
