using System;

namespace Hotelrechnung
{
	class Program
	{
		static void Main(string[] args)
		{
			double MwSt = 7; //hardcode
			Console.WriteLine("Wie viele Personen wollen einchecken?");
			double Personen = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("");
			Console.WriteLine("Wie viele Tage bleiben die Personen im Hotel?");
			double Aufenthaltsdauer = Convert.ToDouble(Console.ReadLine());
			double Zimmerpreis = 70;
			double Nettopreis = Zimmerpreis * Aufenthaltsdauer * Personen;
			double Gesamtpreis = Nettopreis + Nettopreis * MwSt / 100;
			Console.WriteLine("");
			Console.WriteLine("Der Gesamtpreis beträgt:");
			Console.WriteLine(Gesamtpreis);
		}
	}
}
