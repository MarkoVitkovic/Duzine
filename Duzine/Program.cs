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
			int duzina;
			string unos;
			double cm, mm, m, km;
			Console.WriteLine("Molimo unesite duzine koje zelite zbrojiti(oduzeti).\n");
			unos = "3m + 45cm - 38mm + 56km + 13mm";
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

				Console.WriteLine(s);

			}
			foreach (double aPart in operandi)
			{
				Console.WriteLine(aPart);
			}
			foreach (int aPart in duzine)
			{
				Console.WriteLine(aPart);
			}

			int velicina = operatori.Count;
			

			//Console.WriteLine("\n");
			//Console.WriteLine("Molimo unesite mjernu jedinicu u kojoj zelite rezultat(mm,cm,m,km).\n");
			//mj_fin = Console.ReadLine();
			//Console.WriteLine("\n");

			//switch (mj_fin)
			//{
			//	case "mm":
			//		Console.WriteLine("{0}mm je {1}m.", duz.mm, duz.Value);
			//		break;
			//	case "cm":
			//		Console.WriteLine("{0}cm je {1}m.", duz.cm, duz.Value);
			//		break;
			//	case "m":
			//		Console.WriteLine("{0}m je {1}m.", duz.m, duz.Value);
			//		break;
			//	case "km":
			//		Console.WriteLine("{0}km je {1}m.", duz.km, duz.Value);
			//		break;
			//	default:
			//		Console.WriteLine("Pogresan unos");
			//		break;
			//}
			Console.ReadKey();


		}
	}
}
