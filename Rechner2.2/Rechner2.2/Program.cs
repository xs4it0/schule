using System;

namespace Rechner2._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Gib die erste Zahl ein");
			double Zahl1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("");
			Console.WriteLine("Gib die zweite Zahl ein");
			double Zahl2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("");
			Console.WriteLine("Die Ergebnisse lauten wiefolgt:");
			Console.WriteLine("");
			double Ergebnis1 = Zahl1 + Zahl2;
			double Ergebnis2 = Zahl1 - Zahl2;
			double Ergebnis3 = Zahl1 * Zahl2;
			double Ergebnis4 = Zahl1 / Zahl2;
			//
			Console.WriteLine(Ergebnis1);
			Console.WriteLine(Ergebnis2);
			Console.WriteLine(Ergebnis3);
			Console.WriteLine(Ergebnis4);
		}
	}
}
