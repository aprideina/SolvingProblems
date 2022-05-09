namespace SolvingProblems.Sorting
{
	public class Strings344
	{
		public void ReverseString(char[] s)
		{
			var mid = s.Length / 2;

			for (int i = 0; i < mid; i++)
			{
				var buf = s[i];
				var end = s.Length - 1 - i;
				s[i] = s[end];
				s[end] = buf;
			}
		}
	}
}