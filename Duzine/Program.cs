using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duzine
{
	public class Duzina
	{

		public static Duzina Parse(string s, NumberStyles styles, IFormatProvider provider)
		{
			Duzina duz = new Duzina();

			if (s.TrimEnd(null).EndsWith("mm"))
			{
				duz.Value = Double.Parse(s.Remove(s.LastIndexOf("m"), 2), styles, provider);
			}
			if (s.TrimEnd(null).EndsWith("cm"))
			{
				duz.Value = Double.Parse(s.Remove(s.LastIndexOf("c"), 2), styles, provider);
			}
			if (s.TrimEnd(null).EndsWith("m"))
			{
				duz.Value = Double.Parse(s.Remove(s.LastIndexOf("m"), 1), styles, provider);
			}
			if (s.TrimEnd(null).EndsWith("km"))
			{
				duz.Value = Double.Parse(s.Remove(s.LastIndexOf("k"), 2), styles, provider);
			}

			return duz;
		}

		private Duzina() { }

		protected double m_value;

		public double Value
		{
			get { return m_value; }
			private set { m_value = value; }
		}
		public double mm
		{
			get { return (m_value / 1000); }
			private set { m_value = value * 1000; }
		}

		public double cm
		{
			get { return (m_value / 100); }
			private set { m_value = value * 100; }
		}
		public double km
		{
			get { return (m_value / 1000); }
			private set { m_value = value / 1000; }
		}

		public double m
		{
			get { return m_value; }
			private set { m_value = value; }
		}
	}
	class Program
	{

		static void Main(string[] args)
		{
			string unos;
			string mj_fin;
			NumberStyles styles;
			IFormatProvider provider;
			Duzina duz;
			Console.WriteLine("Molimo unesi duzine koje zelite zbrojiti(oduzeti).\n");
			unos = Console.ReadLine();
			Console.WriteLine("\n");
			Console.WriteLine("Molimo unesite mjernu jedinicu u kojoj zelite rezultat(mm,cm,m,km).\n");
			mj_fin = Console.ReadLine();
			Console.WriteLine("\n");
			styles = NumberStyles.Float;
			provider = CultureInfo.CreateSpecificCulture("fr-FR");
			duz = Duzina.Parse(unos, styles, provider);

			switch (mj_fin)
			{
				case "mm":
					Console.WriteLine("{0}mm je {1}m.", duz.mm, duz.Value);
					break;
				case "cm":
					Console.WriteLine("{0}cm je {1}m.", duz.cm, duz.Value);
					break;
				case "m":
					Console.WriteLine("{0}m je {1}m.", duz.m, duz.Value);
					break;
				case "km":
					Console.WriteLine("{0}km je {1}m.", duz.km, duz.Value);
					break;
				default:
					Console.WriteLine("Pogresan unos");
					break;
			}
			Console.ReadKey();

		}
	}
}
