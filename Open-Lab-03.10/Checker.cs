using System;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int idk = 0;
            foreach (char letters in str)
            { if (letters == letter)
                    idk++;
            }

            return idk;
        } 
    }
}
