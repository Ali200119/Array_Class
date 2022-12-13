using System;
namespace Class
{
	public class Factorial
	{
		public Factorial(int number)
		{
			int result = 1;

			for (int i = 1; i <= number; i++)
			{
				result *= i;
			}

			Console.WriteLine(result);
		}
	}
}

