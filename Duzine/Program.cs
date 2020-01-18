using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duzine
{

	class Program
	{
		

		private Program() { }

		static void Main(string[] args)
		{
			List<double> operandi = new List<double>();
			List<char> operatori = new List<char>();
			List<int> duzine = new List<int>();
			int uku=0;
			string unos , mj_fin;
			double cm, mm, m, km;
			Console.WriteLine("Molimo unesite duzine koje zelite zbrojiti(oduzeti).\n");
			unos = Console.ReadLine();
			char[] spearator = { '+', '-' };
			String[] strlist = unos.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
			foreach (String s in strlist)
			{
				int size = s.Length;

				duzine.Add(size);
				
				if (s.TrimEnd(null).EndsWith("mm"))
				{
					string a=s.Remove(s.LastIndexOf("m")-1,2);
					mm = Double.Parse(a);
					mm /= 1000;
					operandi.Add(mm);
					continue;
				}
				if (s.TrimEnd(null).EndsWith("cm"))
				{
					string a = s.Remove(s.LastIndexOf("c"), 2);
					cm = Double.Parse(a);
					cm /= 100;
					operandi.Add(cm);
					continue;
				}
			
				if (s.TrimEnd(null).EndsWith("km"))
				{
					string a = s.Remove(s.LastIndexOf("k"), 2);
					km = Double.Parse(a);
					km *= 1000;
					operandi.Add(km);
					continue;
				}
				if (s.TrimEnd(null).EndsWith("m"))
				{
					string a = s.Remove(s.LastIndexOf("m"), 1);
					m = Double.Parse(a);
					operandi.Add(m);
					continue;
				}

			}
			
			for (int i = 0; i < duzine.Count-1; i++)
			{
				int sizes = duzine.ElementAt(i);
				int velicina = operatori.Count;
				int operato = sizes + velicina;
				uku += operato;
				char znak = unos.ElementAt(uku);
				operatori.Add(znak);
			}

			double sve_ukupno = operandi.ElementAt(0);

			for (int i = 1, j = 0; i < operandi.Count; i++, j++)
			{
				
				double operand = operandi.ElementAt(i);
				char znak = operatori.ElementAt(j);

				switch (znak)
				{
					case '+':
						sve_ukupno += operand;
						break;
					case '-':
						sve_ukupno -= operand;
						break;
				}
			}
			Console.WriteLine("\n");
			Console.WriteLine("Molimo unesite mjernu jedinicu u kojoj zelite rezultat(mm,cm,m,km).\n");
			mj_fin = Console.ReadLine();
			Console.WriteLine("\n");

			switch (mj_fin)
			{
				case "mm":
					Console.WriteLine("Rezultat je {0}mm", sve_ukupno*1000);
					break;
				case "cm":
					Console.WriteLine("Rezultat je {0}cm", sve_ukupno*100);
					break;
				case "m":
					Console.WriteLine("Rezultat je {0}m", sve_ukupno);
					break;
				case "km":
					Console.WriteLine("Rezultat je {0}km", sve_ukupno/1000);
					break;
				default:
					Console.WriteLine("Rezultat je Pogresan unos");
					break;
			}
			Console.ReadKey();


		}
	}
}
