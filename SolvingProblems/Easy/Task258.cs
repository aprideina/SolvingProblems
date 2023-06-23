using System.Collections.Generic;

namespace SolvingProblems.Easy
{
	public class Task258
	{
		private const int V = 10;

		public int AddDigits(int num)
		{
			if(num < V)
			{
				return num;
			}

			var length = num.ToString().Length;
			while (length != 1) 
			{
				var firstPow = (int)System.Math.Pow(V, length - 1);
				var secondPow = (int)System.Math.Pow(V, length - 2);

				int f = num / firstPow;
				int s = (num - f * firstPow) / secondPow;
				var sum = Sum(f, s);

				num -= f * firstPow + s * secondPow;
				num += sum * secondPow;

				length--;
			}
			return num;
		}

		private int Sum(int i, int j)
		{
			var res = i + j;
			if (res >= V) {
				return Sum(res / V, res % V);
			}

			return res;
		}
	}
}
