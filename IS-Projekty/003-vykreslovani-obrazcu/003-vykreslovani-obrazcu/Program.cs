using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main() {
        Console.Write("Zadejte vysku (cele cislo): ");
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
        for (int i = 1; i <= height; i++)
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
                }
            }
            Console.WriteLine();           
     }
    }
}
 
