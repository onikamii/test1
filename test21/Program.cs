using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test21
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
		public static string HoopCount(int n)
		{
			if (n >= 10) { return "Great, now move on to tricks"; }
			else { return "Keep at it until you get it"; }
		}
		public static char GetChar(int charcode)
		{
			return Convert.ToChar(charcode);
		}
		public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
		{
			return ((mpg * fuelLeft) >= distanceToPump) ? true : false;
			throw new NotImplementedException();
		}
		public bool IsEven(double n)
		{
			return (n % 2 == 0) ? true : false;
		}
		public static bool Hero(int bullets, int dragons)
		{
			return (dragons * 2 <= bullets) ? true : false;
		}
		public static int RentalCarCost(int d)
		{
			if (d > 6) return d * 40 - 50;
			else if (d > 2) return d * 40 - 20;
			else return d * 40;
		}
	}
}
