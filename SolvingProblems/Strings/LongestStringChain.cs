using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SolvingProblems.Core;

namespace SolvingProblems.Strings
{
    public class LongestStringChain : ISolvingProblemTaskWithResult<string[], int>
    {
        private class WordChain
        {
            public Guid Id { get; set; }

            public List<string> Chain { get; private set; }

            public int Length => Chain.Count;

            public int LastWordLength { get; private set; }

            public Regex Regex { get; private set; }

            public WordChain()
            {
                Chain = new List<string>();
                Id = Guid.NewGuid();
            }

            public WordChain(string word)
            {
                Chain = new List<string>();
                Id = Guid.NewGuid();

                AddWord(word);
            }

            public void AddWord(string word)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var ch in word)
                {
                    sb.Append($"\\w*{ch}{{1}}\\w*");
                }

                Regex = new Regex($"{sb}");

                Chain.Add(word);
                LastWordLength = word.Length;
            }

            public WordChain Clone() => new WordChain
            {
                Chain = new List<string>(Chain),
                Regex = new Regex(Regex.ToString()),
                LastWordLength = LastWordLength,
                Id = Guid.NewGuid()
            };
        }

        public int Run(string[] input)
        {
            var groupByLength = input
                .GroupBy(x => x.Length, (i, enumerable) => new
                {
                    Length = i,
                    Items = enumerable.ToList()
                })
                .ToDictionary(x => x.Length);

            var minimumLength = groupByLength.Keys.Min();
            var maximumLength = groupByLength.Keys.Max();

            var collection = new List<WordChain>();
            foreach (var group in groupByLength[minimumLength].Items)
            {
                collection.Add(new WordChain(group));
            }

            for(var i = minimumLength + 1; i <= maximumLength; i++)
            {
                foreach (var item in groupByLength[i].Items)
                {
                    var matches = collection
                        .Where(chain => chain.Regex.IsMatch(item) && item.Length == chain.LastWordLength + 1)
                        .ToList();

                    if (matches.Count == 0)
                    {
                        collection.Add(new WordChain(item));
                        continue;
                    }

                    foreach (var t in matches)
                    {
                        var wordChain = t.Clone();
                        wordChain.AddWord(item);

                        collection.Add(wordChain);
                    }
                }
            }

            return collection.Max(x=>x.Length);
        }

        public IEnumerable<TestCasesDto<string[], int>> TestCases()
        {
            yield return new TestCasesDto<string[], int>
            {
                Input = new[]{ "a", "b", "ba", "bca", "bda", "bdca" },
                Expected = 4
            };
            yield return new TestCasesDto<string[], int>
            {
                Input = new[]{ "xbc", "pcxbcf", "xb", "cxbc", "pcxbc" },
                Expected = 5
            };
            yield return new TestCasesDto<string[], int>
            {
                Input = new[]{ "a", "b", "ab", "bac" },
                Expected = 2
            };
            yield return new TestCasesDto<string[], int>
            {
                Input = new[]
                {
                    "ksqvsyq",
                    "ks","kss","czvh",
                    "zczpzvdhx","zczpzvh","zczpzvhx","zcpzvh","zczvh",
                    "gr","grukmj","ksqvsq","gruj","kssq","ksqsq",
                    "grukkmj","grukj","zczpzfvdhx","gru"
                },
                Expected = 7
            };
            yield return new TestCasesDto<string[], int>
            {
                Input = new[]
                {
                    "bdca", "bda", "ca", "dca", "a"
                },
                Expected = 4
            };
            yield return new TestCasesDto<string[], int>
            {
                Input = new[]
                {
                    "a", "b", "ba", "abc", "abd", "bdca"
                },
                Expected = 2
            };
            yield return new TestCasesDto<string[], int>
            {
                Input = new[]
                {
                    "a", "ab", "ac", "bd", "abc", "abd", "abdd"
                },
                Expected = 4
            };
        }
    }
}