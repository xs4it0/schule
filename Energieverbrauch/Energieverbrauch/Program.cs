using System;

namespace Energieverbrauch
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Gib die Elektische Leistung ein:");
			double ElektrischeLeistung = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("");
			Console.WriteLine("Gib die Stunden pro Tag an:");
			double StundeJeTag = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("");
			Console.WriteLine("Gib die Tage pro Jahr an:");
			double TagProJahr = Convert.ToDouble(Console.ReadLine());
			double Verbrauch = ElektrischeLeistung * StundeJeTag * TagProJahr;
			//
			Console.WriteLine("");
			Console.WriteLine("Der Verbrauch verläuft sich auf folgende Zahl:");
			Console.WriteLine(Verbrauch);
		}
	}
}
