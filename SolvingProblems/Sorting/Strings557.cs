namespace SolvingProblems.Sorting
{
	namespace SolvingProblems.Sorting
	{
		public class Strings557
		{
			public string ReverseString(string s)
			{
				var charArray = s.ToCharArray();
				var left = 0;
				var right = 0;
				while (right != s.Length)
				{
					var c = charArray[right];
					if (c == ' ')
					{
						SubArray(charArray, left, right);
						left = right + 1;
					}
				
					right++;
				}
				SubArray(charArray, left, right);

				return new string(charArray);
			}

			private static void SubArray(char[] s, int left, int right)
			{
				var groups = (right - left) / 2;

				for (var i = 0; i < groups; i++)
				{
					var start = left + i;
					var end = right - 1 - i;

					var buf = s[start];
					s[start] = s[end];
					s[end] = buf;
				}
			}
		}
	}
}