﻿using System;

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
            return result.Trim();
        }

        internal string StartOfWord(string v1, int v2)
        {
            return v1.Substring(0, v2);
        }

        internal string FirstWord(string something)
        {
            char empty = ' ';
            int position = something.IndexOf(empty);
            return something.Substring(0, position);
        }

        internal string Titleize(string something)
        {   
            string[] anarray = something.Split(' ');
            string astring = "";
            int i;
            if (anarray[0] == "the")
            {
                anarray[0] = "The";
                astring += anarray[0] + " ";
                i = 1;
            }
            else
            {
                i = 0;
            }
                for (int y = i; y < anarray.Length; y++)
                {

                        if (anarray[y] != "and" && anarray[y] != "over" && anarray[y] != "the")
                        {


                            anarray[y] = anarray[y].Substring(0, 1).ToUpper() + anarray[y].Substring(1);
                            astring += anarray[y] + " ";
                        }
                        else
                        {
                            astring += anarray[y] + " ";

                   
                }


                
            }


            return astring.Trim();




        }


    }
}