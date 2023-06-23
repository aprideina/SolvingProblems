using System.Collections.Generic;

namespace SolvingProblems.Medium
{
	public class Task649
	{
		private const string Dire = "Dire";
		private const string Radiant = "Radiant";

		public string PredictPartyVictory(string senate)
		{
			//var dict = new Dictionary<char, int>()
			//{
			//	{ 'R', 0 },
			//	{ 'D', 0 },
			//};

			//int leftIndex = 0, rightIndex = 1;
			//while (true)
			//{
			//	char left = senate[leftIndex];
			//	char right = senate[rightIndex];

			//	while (rightIndex != senate.Length) 
			//	{
			//		dict[left]++;

			//		if (right != left) 
			//		{
			//		}

			//		rightIndex++;

			//	}

			//	var newString = string.Empty;
			//	for (var i = 0; i < senate.Length - 1; i++)
			//	{

			//		if (left != senate[i + 1])
			//		{
			//			dict[left]++;
			//		}
			//	}
			//}

			//return "";

			var queue = new Queue<char>(senate.ToCharArray());

			var step = 0;
			while (queue.Count != 1) 
			{
				var index = 1;
				var dict = new Dictionary<char, int>()
				{
					{ 'R', 0 },
					{ 'D', 0 },
				};

				var newQueue = new Queue<char>();
				foreach (var item in queue)
				{
					if (index++%2 != step)
					{
						newQueue.Enqueue(item);
						dict[item]++;
					}
				}

				queue = newQueue;

				step = step == 1 ? 1 : 0;
			}

			var last = queue.Dequeue();
			return last == 'R' ? "Radiant" : Dire;
		}
	}
}
