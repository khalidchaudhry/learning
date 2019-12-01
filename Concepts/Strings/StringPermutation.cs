﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class StringPermutation
    {
        public List<string> StringPermutations(string s)
        {
            List<string> result = new List<string>();
            StringPermutations("", s, result);
            return result;
        }

        private void StringPermutations(string prefix, string suffix, List<String> results)
        {
            if (suffix.Length == 0)
            {
                results.Add(prefix);
            }
            else
            {
                for (int i = 0; i < suffix.Length; i++)
                {
                  StringPermutations(prefix + suffix[i], suffix.Substring(0, i) + suffix.Substring(i + 1),results);
                }
            }
        }



    }
}
