using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text.RegularExpressions;

namespace TDD_pr2
{
    public class TddStr
    {
        public int cifracount(string stroka)
        {
            int a=0;
            foreach(char c in stroka)
            {
                if (char.IsDigit(c))
                {
                    a++;
                    break;
                }
            }
            return a;
        }

        public int countpodcombcount(string stroka, string comb)
        {
            int count = new Regex(comb).Matches(stroka).Count;
            return count;
        }

        public int cifracountpodr(string stroka)
        {
            List<int> all = new List<int>();
            int count = 0;
            foreach(char c in stroka)
            {
                if(char.IsDigit(c))
                {
                    count++;
                }
                if(!char.IsDigit(c))
                {
                    all.Add(count);
                    count = 0;
                }
            }
            all.Sort();
            return all.Max();
        }
        public int simbolcount(string stroka)
        {
            return stroka.Length;
        }

        

        public int wordcount(string stroka)
        {
            int words = Regex.Split(stroka, " ").Count();
            return words;
        }

        public string word(string stroka)
        {
            string word = stroka.Split(' ').OrderBy(w => w.Length).FirstOrDefault();
            return word;
        }

        public string ninesimbol(string stroka, int simbol)
        {
            int number = 1;
            string b = "";
            foreach (char c in stroka)
            {
                if (number == simbol)
                {
                    b = Convert.ToString(c);
                    break;
                }
                number++;
            }
            return b;
        }
    }
}