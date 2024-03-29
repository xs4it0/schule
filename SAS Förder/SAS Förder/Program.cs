﻿using System;

namespace SAS_Förder
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welche Operation möchtest du ausführen?");
			Console.WriteLine("1. Hypotenuse berechnen");
			Console.WriteLine("2. Nullstelle berechnen");
			Console.WriteLine("");
			int choose = Convert.ToInt32(Console.ReadLine());
			if (choose == 1)
			{
				double Kathete1 = 0, Kathete2 = 0, Hypotenuse = 0, a = 0;
				Console.WriteLine("Hypotenusenberechnung");
				Console.WriteLine("");
				Console.WriteLine("Gib die Länge der ersten Kathete an");
				Kathete1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("");
				Console.WriteLine("Gib die Länge der zweiten Kathete an");
				Kathete2 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("");
				a = Kathete1 * Kathete1 + Kathete2 * Kathete2;
				Hypotenuse = Math.Sqrt(a);
				Console.WriteLine("Die Hypotenuse beträgt: {0}", Hypotenuse);
			}
			if (choose == 2)
			{
				double b = 0, m = 0, nullstelle = 0;
				Console.WriteLine("Nullstellenberechnung");
				Console.WriteLine("");
				Console.WriteLine("Geben Sie den Wert für b ein");
				b = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("");
				Console.WriteLine("Geben Sie den Wert für m ein");
				m = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("");
				if (m != 0)
				{
					nullstelle = (-b / m);
					Console.WriteLine("Das Ergebnis lautet {0}", nullstelle);
				}
				else
				{
					Console.WriteLine("Du kannst b nicht durch 0 teilen! Bitte wähle eine andere Zahl!");
				}
			}
			else
			{
				Console.WriteLine("Es wurde eine fehlerhafte Eingabe gemacht."); //anti-bug
			}
		}
	}
}
