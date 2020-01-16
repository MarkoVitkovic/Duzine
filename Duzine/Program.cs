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
		public static Program Parse(string s)
		{
			Program duz = new Program();

			

			return duz;
		}

		private Program() { }

		static void Main(string[] args)
		{
			string unos;
			string mj_fin;
			Console.WriteLine("Molimo unesite duzine koje zelite zbrojiti(oduzeti).\n");
			unos = "3m + 45cm - 38mm";
			Program duzina = new Program();
			char[] spearator = { '+', '-' };
			String[] strlist = unos.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
			foreach (String s in strlist)
			{
				Console.WriteLine(s.Length);
			}
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
