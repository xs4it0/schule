using System;

namespace Zinsberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
			//Variablen
			Console.WriteLine("Gib dein Startkapital ein");
			double Startkapital = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Gib den Zinssatz ein:");
			double Zinssatz = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("");
			Console.WriteLine("Das Ergebnis lautet wiefolgt:");
			double Zinsen = Startkapital * (Zinssatz / 100);
			//Ausführung
			Console.WriteLine(Zinsen);
			Console.Read();
        }
    }
}
