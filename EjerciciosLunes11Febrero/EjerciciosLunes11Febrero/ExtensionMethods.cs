using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class ExtensionMethods
    {

        public static string reverseSentence(this string sentence)
        {
            char[] charSentence = sentence.ToCharArray();
            Array.Reverse(charSentence);
            return new string(charSentence);
        }

    }
}
