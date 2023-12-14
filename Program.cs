using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("PartyGame regisztráció");
        Console.Write("Felhasználónév: ");
        string felhasznalonev = Console.ReadLine();

        string jelszo;
        do
        {
            Console.Write("Jelszó: ");
            jelszo = Console.ReadLine();

            if (!JelszoEllenorzes(jelszo))
            {
                Console.WriteLine("Hibás jelszó! A jelszónak legalább 8 karakter hosszúnak, és tartalmaznia kell kis- és nagybetűt, valamint legalább egy számot.");
            }

        } while (!JelszoEllenorzes(jelszo)); 

        if (Regisztracio(felhasznalonev, jelszo))
        {
            Console.WriteLine("Sikeres regisztráció!");
        }
        else
        {
            Console.WriteLine("Hiba történt a regisztráció során. Kérjük, próbálja meg újra.");
        }

        Console.ReadLine();
    }

    static bool JelszoEllenorzes(string jelszo)
    {
        return Regex.IsMatch(jelszo, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
    }

    static bool Regisztracio(string felhasznalonev, string jelszo)
    {
        return true;
    }
}