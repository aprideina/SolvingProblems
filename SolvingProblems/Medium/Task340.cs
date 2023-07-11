using System;
using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Medium;

public class Task340
{
    public int Run(string s, int k)
    {
        if (k == 0)
        {
            return 0;
        }

        var maxSubstring = 0;
        var _letters = new HashSet<char>(k);
        var sub = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (_letters.Contains(ch))
            {
                sub++;
            }
            else
            {
                if (_letters.Count >= k)
                {
                    maxSubstring = Math.Max(maxSubstring, sub);
                    _letters = new HashSet<char>(k);
                    sub = 0;
                    
                    for (var j = i ; j >= 0; j--)
                    {
                        if (_letters.Contains(s[j]))
                        {
                            sub++;
                        }
                        else
                        {
                            if (_letters.Count == k)
                            {
                                break;
                            }
                            _letters.Add(s[j]);
                            sub++;
                        }
                    }
                }
                else
                {
                    _letters.Add(s[i]);
                    sub++;
                }
            }
        }
        maxSubstring = Math.Max(maxSubstring, sub);
        return maxSubstring;
    }
}