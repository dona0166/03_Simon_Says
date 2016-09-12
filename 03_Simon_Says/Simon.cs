using System;

namespace _03_Simon_Says
{
    internal class Simon
    {
        internal string Echo(string v)
        {
        
            return v.ToLower();
        }

        internal string Shout(string v)
        {
            return v.ToUpper();

        }

        
        internal string Repeat(string v)
        {
            return v + " " + v;
        }
        string result;
        internal string Repeat(string v , int n)
        {
                for (int i = 0; i < n; i++)
                {
                    result += v + " ";
                }
            return result;
        }

        internal string StartOfWord(string v1, int v2)
        {
            return v1.Substring(0, v2);
        }

        internal string FirstWord(string something)
        {
            char empty = ' ';
            int position = something.IndexOf(empty);
            return something.Substring(0, position-1);
        }

        internal string 


    }
}