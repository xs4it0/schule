using System;


/*
	Dominik Brodeufel
	BFT91	 
*/

namespace Hotelrechnung
{
	class Program
	{
		static void Main(string[] args)
		{
			double MwSt = 7; //hardcode
			Console.WriteLine("Was für ein Zimmer soll gebucht werden?");
			Console.WriteLine("");
			Console.WriteLine("(1) Normales Zimmer");
			Console.WriteLine("(2) Premium Zimmer");
			Console.WriteLine("(3) Fist Class Zimmer");
			int ZimmerArt = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");
			Console.WriteLine("Wie viele Personen wollen einchecken?");
			int Personen = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nWie viele Tage bleiben die Personen im Hotel?");
			int Aufenthaltsdauer = Convert.ToInt32(Console.ReadLine());
			double Standard_Room = 70, Premium_Room = 150, First_Class = 250;
			double Nettopreis = 0, Gesamtpreis = 0;

			//#########################################################################################
			
			Console.WriteLine(); //
			Console.WriteLine("Wie viele von den Personen sind Kinder?");
			int AnzahlKinder = Convert.ToInt32(Console.ReadLine());

			if(AnzahlKinder > Personen)
			{
				Console.WriteLine("Fehler mehr Kinder als insgesamt Personen ?"); //Fehlerausgabe

				return; 
			}

			int[] KindAlterListe = new int[AnzahlKinder]; 

			for(int Kind = 0; Kind < AnzahlKinder; Kind++) 
			{
				Console.WriteLine();
				Console.WriteLine("Wie alt ist Kind {0} ?", Kind + 1);
				int Alter = Convert.ToInt32(Console.ReadLine()); 

				KindAlterListe[Kind] = Alter; 
			}

			//#########################################################################################
			
			if (ZimmerArt == 1)
			{
				string Zimmer = "Normal_Room";

				//#########################################################################################

				Nettopreis = Standard_Room * Aufenthaltsdauer * (Personen - AnzahlKinder);

				for (int Kind = 0; Kind < AnzahlKinder; Kind++)
				{
					int KindAlter = KindAlterListe[Kind];
					
					if(KindAlter <= 6)
					{
						//Frei
					}

					else if(KindAlter <= 11) //Von 7 bis 11
					{
						Nettopreis += Standard_Room * Aufenthaltsdauer * 0.4; //0.4 = 40%
					}

					else if(KindAlter <= 14) //Von 12 bis 14
					{
						Nettopreis += Standard_Room * Aufenthaltsdauer * 0.7; //0.7 = 70%
					}

					else //Von 15 bis Infinity
					{
						Nettopreis += Standard_Room * Aufenthaltsdauer; //100%
					}
				}

				//#########################################################################################

				Gesamtpreis = Nettopreis + Nettopreis * MwSt / 100;
				Console.WriteLine("");
				Console.WriteLine("Der Gesamtpreis für ein Normales Zimmer beträgt {0}", Gesamtpreis);
				Console.WriteLine("Bitte überprüfe folgende Eingaben: {0} Personen checken für {1} Tag(e) ein. Zimmertyp: {2}", Personen, Aufenthaltsdauer, Zimmer);
			}
			if (ZimmerArt == 2)
			{
				string Zimmer = "Premium_Room";

				//#########################################################################################

				Nettopreis = Premium_Room * Aufenthaltsdauer * (Personen - AnzahlKinder); 

				for (int Kind = 0; Kind < AnzahlKinder; Kind++)
				{
					int KindAlter = KindAlterListe[Kind];

					if (KindAlter <= 6)
					{
						//Frei
					}

					else if (KindAlter <= 11) //Von 7 bis 11
					{
						Nettopreis += Premium_Room * Aufenthaltsdauer * 0.4; //0.4 = 40%
					}

					else if (KindAlter <= 14) //Von 12 bis 14
					{
						Nettopreis += Premium_Room * Aufenthaltsdauer * 0.7; //0.7 = 70%
					}

					else //Von 15 bis Infinity
					{
						Nettopreis += Premium_Room * Aufenthaltsdauer; //100%
					}
				}

				//#########################################################################################

				Gesamtpreis = Nettopreis + Nettopreis * MwSt / 100;
				Console.WriteLine("");
				Console.WriteLine("Der Gesamtpreis für ein Premium Zimmer beträgt {0} Euro", Gesamtpreis);
				Console.WriteLine("Bitte überprüfe folgende Eingaben: {0} Personen checken für {1} Tag(e) ein. Zimmertyp: {2}", Personen, Aufenthaltsdauer, Zimmer);
			}
			if (ZimmerArt == 3)
			{
				string Zimmer = "FirstClass_Room";

				//#########################################################################################

				Nettopreis = First_Class * Aufenthaltsdauer * (Personen - AnzahlKinder);

				for (int Kind = 0; Kind < AnzahlKinder; Kind++)
				{
					int KindAlter = KindAlterListe[Kind];

					if (KindAlter <= 6)
					{
						//Frei
					}

					else if (KindAlter <= 11) //Von 7 bis 11
					{
						Nettopreis += First_Class * Aufenthaltsdauer * 0.4; //0.4 = 40%
					}

					else if (KindAlter <= 14) //Von 12 bis 14
					{
						Nettopreis += First_Class * Aufenthaltsdauer * 0.7; //0.7 = 70%
					}

					else //Von 15 bis Infinity
					{
						Nettopreis += First_Class * Aufenthaltsdauer; //100%
					}
				}

				//#########################################################################################

				Gesamtpreis = Nettopreis + Nettopreis * MwSt / 100;
				Console.WriteLine("");
				Console.WriteLine("Der Gesamtpreis für ein FirstClasss Zimmer beträgt {0} Euro.", Gesamtpreis);
				Console.WriteLine("Bitte überprüfe folgende Eingaben: {0} Personen checken für {1} Tag(e) ein. Zimmertyp: {2}", Personen, Aufenthaltsdauer, Zimmer);
			}
			if (ZimmerArt <= 0 && ZimmerArt >= 4)
			{
				Console.WriteLine("Es wurden fehlerhafte Angaben gemacht!");
			}
		}
	}
}
