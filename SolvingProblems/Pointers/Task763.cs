using System;
using System.Collections.Generic;
using System.Linq;
using SolvingProblems.Core;

namespace SolvingProblems.Pointers;

public class Task763 : ISolvingProblemTaskWithResult<string, IList<int>>
{
    public IList<int> Run(string s)
    {
        if (s.Length == 1)
        {
            return new List<int>(1){ 1 };
        }

        var letters = new Dictionary<char, Info>(); // char - appearance
        var words = new Dictionary<int, int>(); // index left - index right
        
        for (var i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (!letters.ContainsKey(ch))
            {
                letters.Add(ch, new Info
                {
                    Index = i,
                    Left = i,
                    Right = i
                });
            }
            else
            {
                letters[ch].Left = Math.Min(letters[ch].Left, i);
                letters[ch].Right = Math.Max(letters[ch].Right, i);
            }

            letters[ch].Count++;
            if (letters[ch].Count > 1)
            {
                var nextRight = i;
                var nextLeft = letters[ch].Left;
                var left = nextLeft;
                var keys = words.Keys.Where(l => l >= left && l < nextRight);
                foreach (var key in keys)
                {
                    nextLeft = Math.Min(key, nextLeft);
                    words.Remove(key);
                }
                words.Add(nextLeft, nextRight);
                for (var j = nextLeft; j < nextRight; j++)
                {
                    letters[s[j]].Left = nextLeft;
                    letters[s[j]].Right = nextRight;
                }
            }
            else
            {
                words.Add(letters[ch].Left, letters[ch].Right);
            }
        }

        var result = words.OrderBy(pair => pair.Key).Select(pair => pair.Value - pair.Key + 1).ToList();
        return result;
    }

    private class Info
    {
        public int Index { get; set; }

        public int Count { get; set; }
        
        public int Left { get; set; }
        
        public int Right { get; set; }
    }

    public IEnumerable<TestCasesDto<string, IList<int>>> TestCases()
    {
        yield return new TestCasesDto<string, IList<int>>
        {
            Input = "aaabb",
            Expected = new List<int>(2) { 3, 2 }
        };
        yield return new TestCasesDto<string, IList<int>>
        {
            Input = "aaabba",
            Expected = new List<int>(1) { 6 }
        };
        yield return new TestCasesDto<string, IList<int>>
        {
            Input = "aaabbc",
            Expected = new List<int>(3) { 3, 2, 1 }
        };
        yield return new TestCasesDto<string, IList<int>>
        {
            Input = "ababcbacadefegdehijhklij",
            Expected = new List<int>(3) { 9, 7, 8 }
        };
        yield return new TestCasesDto<string, IList<int>>
        {
            Input = "eccbbbbdec",
            Expected = new List<int>(1) { 10 }
        };
        yield return new TestCasesDto<string, IList<int>>
        {
            Input = "eaaaabaaec",
            Expected = new List<int>(2) { 9,1 }
        };
    }
}