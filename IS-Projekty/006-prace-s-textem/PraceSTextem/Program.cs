using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main() {
        
        Console.WriteLine("Vlozte svuj text: ");
        string mujText = Console.ReadLine();
        int length = mujText.Length;
        string samohlaska = "a,e,i,y,o,u,á,é,í,ý,ó,ú,ů";
        string souhlaska = "h, ch, k, r, d, t, n, ž, š, c, č, ř, j, ď, ť, ň, b, f, l, m, p, s, v, z";
        int cislo = 0;
        int pismeno = 0;
        int specialniZnak = 0;
        int samohlasky = 0;
        int souhlasky = 0;
        


        char[] strArray = mujText.ToCharArray();
        foreach (char znak in mujText){
            if (char.IsDigit(znak))
                cislo++;
            if (char.IsLetter(znak))
                pismeno++;
            if (!char.IsLetterOrDigit(znak))  // negace, takze vse co neni cislo nebo pismeno je special char
                specialniZnak++;
            if (samohlaska.Contains(znak))  // negace, takze vse co neni cislo nebo pismeno je special char
                samohlasky++;
            if (souhlaska.Contains(znak))  // negace, takze vse co neni cislo nebo pismeno je special char
                souhlasky++;
        }

        Console.WriteLine("Vas vlozeny text " + mujText);
        Console.WriteLine("Delka vami vlozeneho text: {0}", length);
        Console.WriteLine("Vlozeny text obsahuje {0} cisel", cislo);
        Console.WriteLine("Vlozeny text obsahuje {0} pismen", pismeno);
        Console.WriteLine("Vlozeny text obsahuje {0} specialnich znaku", specialniZnak);
        Console.WriteLine("Vlozeny text obsahuje {0} souhlasek", souhlasky);
        Console.WriteLine("Vlozeny text obsahuje {0} samohlasek", samohlasky);
    }
} 