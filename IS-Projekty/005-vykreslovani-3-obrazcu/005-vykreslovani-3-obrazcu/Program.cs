using System;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main()
    {
        //vstup uzivatele
        Console.WriteLine("Vyber jaky znak chces vypsat (Z - pismeno Z / C - ctverce / O - Obloha): ");
        string znak = Console.ReadLine();
        //vstup uzivatele
        Console.Write("Zadejte výšku (celé číslo): ");
        int vyska;
        while (!int.TryParse(Console.ReadLine(), out vyska))
        {
            Console.WriteLine("Výška musí být celé číslo. Zkuste znovu.");
        }
        
        //if pro vykreslieni obrazce
        if (znak == "Z"){
            vykresliZ(vyska);
        }
        else if (znak == "C" ){
            vykresliP(vyska);
        }
        else if (znak == "O"){
            vykresliObloha(vyska);
        } 

        //funkce pro vykresleni pismene Z
        static void vykresliZ(int vyska){

            //horni radek
            for (int i = 0; i < vyska; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();

            //stredni radek
            for (int i = vyska - 2; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('*');
            }

            //spodni radek
            for (int i = 0; i < vyska; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }


        static void vykresliP(int vyska){
 
        
        int pulka = vyska / 2; 

        for (int i = 0; i < vyska; i++)
        {
            for (int j = 0; j < vyska; j++)
            {
                
                if (i < pulka && j < pulka)
                    Console.Write("*");
        
                else if (i >= pulka && j >= pulka)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        }
       
        }
        static void vykresliObloha(int vyska){

            int sirka = vyska;
            for (int i = 0; i < sirka; i++)
            {
              for (int j = 0; j < vyska; j++)
                {
                    if((i + j) % 2 == 0)
                    Console.Write("*");
                    else
                    Console.Write(" ");
                }
            Console.WriteLine();
            }
        }  
    }
