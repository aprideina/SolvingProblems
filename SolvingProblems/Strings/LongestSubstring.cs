using System;
using System.Collections.Generic;

namespace SolvingProblems.Strings
{
    public static class LongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var indexCharacters = new Dictionary<char, int>(s.Length);
            int left = 0, right = 1, length = 1, maxLength = 1;

            if (s.Length == 0)
            {
                return 0;
            }

            var firstCharacter = s[left];
            indexCharacters[firstCharacter] = 1;
            
            while (right < s.Length)
            {
                var endCharacter = s[right];
                var existKey = indexCharacters.TryGetValue(endCharacter, out var index);

                if (existKey && index > left)
                {
                    maxLength = Math.Max(length, maxLength);

                    left = index;
                    indexCharacters[endCharacter] = right + 1;

                    right++;
                    length = right - left;

                    continue;
                }

                indexCharacters[endCharacter] = right + 1;
                right++;
                length++;
            }

            return Math.Max(length, maxLength);
        }
    }
}