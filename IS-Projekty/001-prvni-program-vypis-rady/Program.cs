using System;

class Program
{
    static void Main() {

        string again = "y";

        while(again=="y"){

            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            Console.WriteLine("Chces program opakovat? Y/N");
            again = Console.ReadLine();


            Console.Write("Zadejte prvni cislo rady: ");
            int first;  
            while(!int.TryParse(Console.ReadLine(), out first)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
                Console.Write("Prvni cislo musi byt celociselne");
            }

            Console.Write("Zadejte prvni cislo rady: ");
            int last;  
            while(!int.TryParse(Console.ReadLine(), out last)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
                Console.Write("Prvni cislo musi byt celociselne");
            }

            Console.Write("Zadejte diferenci (cele cislo): ");
            int step;  
            while(!int.TryParse(Console.ReadLine(), out step)){ // vykricni je negace, dokud nezada uzivatel nesplni podminku, program se nespusti ale ani nespadne
                Console.Write("Prvni cislo musi byt celociselne");
            }


            int current = first;
            while (current <= last){
                Console.WriteLine(current);
                current = current + step;
            } 

            Console.WriteLine("Zadaly jste tyto hodnoty: ");
            Console.WriteLine("Prvni cislo rady: {0}", first);
            Console.WriteLine("Posledni cislo rady: {0}", last);
            Console.WriteLine("Diference cislo rady: {0}", step);
    } 
 }  

}

