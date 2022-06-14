// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Badetidssystemet;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hej deltagere!");
        Kreds Kreds1 = new Kreds("3", "Torben", "Peterbangsvej 34 th.", 15, "23 34 45 23");
        Kreds Kreds2 = new Kreds("4", "Stine", "Holmegårds Alle 23 ", 15, "56 34 64 42");
        Console.WriteLine();
        Console.WriteLine(Kreds1);
        Console.WriteLine("______________________________________________________________________");
        Console.WriteLine();
        Console.WriteLine(Kreds2);
        Console.WriteLine("______________________________________________________________________");
        //Udskrevet kreds

        Badetidsperiode bade1 = new Badetidsperiode("Aftenbad", DayOfWeek.Friday, new DateTime().AddHours(6).AddMinutes(30), new DateTime().AddHours(8).AddMinutes(30));
        Badetidsperiode bade2 = new Badetidsperiode("Vinterbad", DayOfWeek.Monday, new DateTime().AddHours(14).AddMinutes(30), new DateTime().AddHours(17).AddMinutes(30));
        Console.WriteLine(bade1);
        Console.WriteLine("______________________________________________________________________");
        Console.WriteLine(bade2);
        //Udskrevet badetidsperiode

        bade1.AdderKreds(bade1);
        bade2.SletKreds(bade2);
        Console.WriteLine("______________________________________________________________________");
        Console.WriteLine(bade1);
        Console.WriteLine("______________________________________________________________________");
        Console.WriteLine(bade2);
        Console.WriteLine("______________________________________________________________________");
        Console.ReadLine();
        // Create og delete

    }
}


