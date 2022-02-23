using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTextEditor
{
    class StringHelper
    {
        public static int wordsCount(string text) {
            if (text.Length == 0) return 0;
            int wordsCount = 0;
            for (int i = 0; i < text.Length; i++) {
                if (!isAlphaNumeric(text[i])) {
                    if ((i + 1) < text.Length) {
                        if (isAlphaNumeric(text[i + 1])) {
                            wordsCount++;
                        }
                    }
                }
            }
            return wordsCount+1;
        }

        public static int linesCount(string text) {
            if (text.Length == 0) return 0;
            int linesCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='\n')
                {
                    linesCount++;
                }
            }
            return linesCount+1;
        }

        public static bool isAlphaNumeric(char c) {
            int numC = (char)c;
            if (numC >= 48 && numC <= 57) return true;
            if (numC >= 65 && numC <= 90) return true;
            if (numC >= 97 && numC <= 122) return true;
            return false;
        }
    }
}
