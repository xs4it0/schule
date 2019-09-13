using System;

/*
	Dominik B.
	BFT91
	13.09.2019 - 15:50
*/


namespace Rechner_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welche Rechenoperation möchtest du ausführen?\n");
			Console.WriteLine("(1) Addition");
			Console.WriteLine("(2) Subtraktion");
			Console.WriteLine("(3) Multiplikation");
			Console.WriteLine("(4) Division");
			Console.WriteLine("(5) Wurzel ziehen");
			Console.WriteLine("(6) Potenz berechnen");
			Console.WriteLine("(7) BONUS: Zwei Zahlen vergleichen\n");
			int choose = Convert.ToInt32(Console.ReadLine());
			if (choose <= 0 || choose >= 8)
			{
				Console.WriteLine("Es wurden falsche angaben gemacht!");
			}
			if (choose == 1)
			{
				Console.WriteLine("Gib bitte die erste Zahl ein");
				double Zahl1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Gib bitte die zweite Zahl ein");
				double Zahl2 = Convert.ToDouble(Console.ReadLine());
				double Ergebnis1 = Zahl1 + Zahl2;
				Console.WriteLine("\nDas Ergebnis lautet {0}", Ergebnis1);
			}
			if (choose == 2)
			{
				Console.WriteLine("\nGib bitte die erste Zahl ein");
				double Zahl1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Gib bitte die zweite Zahl ein");
				double Zahl2 = Convert.ToDouble(Console.ReadLine());
				double Ergebnis1 = Zahl1 - Zahl2;
				Console.WriteLine("\nDas Ergebnis lautet {0}", Ergebnis1);
			}
			if (choose == 3)
			{
				Console.WriteLine("\nGib bitte die erste Zahl ein");
				double Zahl1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Gib bitte die zweite Zahl ein");
				double Zahl2 = Convert.ToDouble(Console.ReadLine());
				double Ergebnis1 = Zahl1 * Zahl2;
				Console.WriteLine("\nDas Ergebnis lautet {0}", Ergebnis1);
			}
			if (choose == 4)
			{
				Console.WriteLine("\nGib bitte die erste Zahl ein");
				double Zahl1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Gib bitte die zweite Zahl ein");
				double Zahl2 = Convert.ToDouble(Console.ReadLine());
				double Ergebnis1 = Zahl1 / Zahl2;
				Console.WriteLine("\nDas Ergebnis lautet {0}", Ergebnis1);
			}
			if (choose == 5)
			{
				Console.WriteLine("\nAus welcher Zahl möchtest du die Wurzel ziehen?");
				double Zahl1 = Convert.ToDouble(Console.ReadLine());
				double Ergebnis1 = Math.Sqrt(Zahl1);
				Console.WriteLine("\nDie Wurzel aus {0} beträgt {1}", Zahl1, Ergebnis1);
			}
			if (choose == 6)
			{
				Console.WriteLine("\nVon welcher Zahl willst du Potenzieren?");
				double zahl = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("\nWie hoch soll die Potenz sein?");
				double exponent = Convert.ToDouble(Console.ReadLine());
				double Ergebnis = Math.Pow(zahl, exponent);
				Console.WriteLine("\nDas Ergebnis beträgt {0}.", Ergebnis);
			}
			if (choose == 7)
			{
				Console.WriteLine("\nGib bitte die erste Zahl ein");
				double Zahl1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("\nGib bitte die zweite Zahl ein");
				double Zahl2 = Convert.ToDouble(Console.ReadLine());
				if (Zahl1 > Zahl2)
				{
					Console.WriteLine("\nDie Zahl {0} ist größer als die Zahl {1}", Zahl1, Zahl2);
				}
				else
				{
					Console.WriteLine("\nDie Zahl {0} ist größer als die Zahl {1}", Zahl2, Zahl1);
				}
			}
		}
	}
}