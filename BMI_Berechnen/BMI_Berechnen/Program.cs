using System;

namespace BMI_Berechnen
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bitte Gewicht in Kg eingeben (aufgerundet):");
			string gewicht1 = Console.ReadLine();
			Console.WriteLine("Bitte die Körpergröße in meter eingeben (Achtung! Eingabe NICHT mit einen punkt trennen, sondern ein komma verwenden.)");
			string größe1 = Console.ReadLine();
			Console.WriteLine("Ergebnis: ");
			bmi_ausgabe(gewicht1, größe1);
		}
		public static void bmi_ausgabe(string gewicht, string größe)
		{
			double gewicht2 = Convert.ToDouble(gewicht);
			double größe2 = Convert.ToDouble(größe);
			double BMIWert = gewicht2 / (größe2 * größe2);
			if (BMIWert < 18.5)
			{
				Console.WriteLine("Untergewicht");
			}
			else if (BMIWert >= 25)
			{
				Console.WriteLine("Übergewicht");
			}
			else if (BMIWert >= 18.5 && BMIWert < 25)
			{
				Console.WriteLine("Normalgewicht");
			}
		}
	}
}