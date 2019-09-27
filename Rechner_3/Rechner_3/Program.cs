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
			int choose = 0;
			double Zahl1 = 0, Zahl2 = 0, Ergebnis1 = 0;
			Console.WriteLine("Welche Rechenoperation möchtest du ausführen?\n");
			Console.WriteLine("(1) Addition\n(2) Subtraktion\n(3) Multiplikation\n(4) Division\n(5) Wurzel ziehen\n(6) Potenz berechnen\n(7) BONUS: Zwei Zahlen vergleichen\n");
			choose = Convert.ToInt32(Console.ReadLine());
			if (choose <= 0 || choose >= 8)
			{
				Console.WriteLine("Es wurden falsche angaben gemacht!");
			}
			if (choose >= 1 && choose <= 4 || choose >= 6 && choose <= 7)
			{
				
				Console.WriteLine("Gib bitte die erste Zahl ein");
				Zahl1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Gib bitte die zweite Zahl ein");
				Zahl2 = Convert.ToDouble(Console.ReadLine());
			}
			if (choose == 5)
			{
				Console.WriteLine("Gib bitte die erste Zahl ein");
				Zahl1 = Convert.ToDouble(Console.ReadLine());
			}
			if (choose == 1)
			{
				Ergebnis1 = Zahl1 + Zahl2;
				Console.WriteLine("\nDas Ergebnis lautet {0}", Ergebnis1);
			}
			if (choose == 2)
			{
				Ergebnis1 = Zahl1 - Zahl2;
				Console.WriteLine("\nDas Ergebnis lautet {0}", Ergebnis1);
			}
			if (choose == 3)
			{
				Ergebnis1 = Zahl1 * Zahl2;
				Console.WriteLine("\nDas Ergebnis lautet {0}", Ergebnis1);
			}
			if (choose == 4)
			{
				Ergebnis1 = Zahl1 / Zahl2;
				Console.WriteLine("\nDas Ergebnis lautet {0}", Ergebnis1);
			}
			if (choose == 5)
			{
				Ergebnis1 = Math.Sqrt(Zahl1);
				Console.WriteLine("\nDie Wurzel aus {0} lautet {1}", Zahl1, Ergebnis1);
			}
			if (choose == 6)
			{
				Ergebnis1 = Math.Pow(Zahl1, Zahl2);
				Console.WriteLine("\nDas Ergebnis ist {0}.", Ergebnis1);
			}
			if (choose == 7)
			{
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