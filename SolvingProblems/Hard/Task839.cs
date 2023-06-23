using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SolvingProblems.Hard
{
	public class Task839
	{
		public int NumSimilarGroups(string[] strs)
		{
			var items = new List<Item>();

			foreach (var item in strs)
			{
				items.Add(new Item(item));
			}

			return 0;
		}
	}

	public class Item : IEquatable<Item>
	{
		public string _value = string.Empty;

		public Dictionary<char, int> Word { get; set; }

		public Item(string item) 
		{
			_value = item;
			Word = new Dictionary<char, int>();
			int index = 0;
			foreach (var i in item)
			{
				if (Word.ContainsKey(i))
				{
					Word[i] += index++;
				}
				else
				{
					Word.Add(i, index++);
				}
			}
		}

		public bool Equals([AllowNull] Item other)
		{
			if(other._value == this._value)
			{
				return true;
			}
			var dif = 0;
			foreach (var key in Word.Keys)
			{
				if(other.Word[key] != Word[key])
				{
					dif++;
				}

				if (dif > 2) {
					return false;
				}
			}
			return true;
		}
	}
}
