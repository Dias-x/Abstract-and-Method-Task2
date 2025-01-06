using System;
using Aufgabe_1;


class Program
{
    static void Main(string[] args)
    {
        //Objekt erstellen mit den Parameter
        Rectangle rectangle = new Rectangle(50, 23);
        Circle circle = new Circle(5);
        

        //Ausgabe mit der zugewiesener Methode
        Console.WriteLine($"Es werden die Get.Area Methode abgerufen");
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(circle.GetArea());
        
        Console.WriteLine();
        
        //To.String Methode abrufen
        Console.WriteLine($"Es werden die To.String Methode abgerufen");
        Console.WriteLine(rectangle.ToString());
        Console.WriteLine(circle.ToString());
    }
}