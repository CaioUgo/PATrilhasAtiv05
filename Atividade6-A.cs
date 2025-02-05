using System;

namespace fire
{
	class Program
	{
		public static void Main(string[] args)
		{
			var date = DateTime.Now;
			Console.WriteLine(date);
			
			Console.Write("\n\rPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
