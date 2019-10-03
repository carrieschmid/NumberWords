using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NumberToWords.Models {
    public class NumConverter {

        string[] OneToNinteen { get; }
        string[] TensMultiples { get; }

        public NumConverter () {
            OneToNinteen = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };
            TensMultiples = new string[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninty" };

        }
        public bool CheckInput (string input) {
            Regex reg = new Regex (@"[^0-9]");
            if (reg.IsMatch (input)) {
                return false;
            }
            return true;
        }

        public string Converter (string inputDigits) {
            int numLength = inputDigits.Length;
            string result = "";

            // check onesplace -- if not 0 -> set ones digit word
            // if existing, check tens, if == 1 use direct lookup of "teens section", otherwise look up "tens section"
            // if existing, check hundreds use direct lookup of "ones section" and add 'hundred'            
            string onesString;
            string tensString;
            string hundredsString;
            string thousandsString;
            string tenthousandsString;
            string hundredthousandsString;
            try {
                onesString = inputDigits[inputDigits.Length];
                tensString = inputDigits[inputDigits.Length - 1];
                hundredsString = inputDigits[inputDigits.Length - 2];
                thousandsString = inputDigits[inputDigits.Length - 3];
                tenthousandsString = inputDigits[inputDigits.Length - 4];
                hundredthousandsString = inputDigits[inputDigits.Length - 5];
            } catch (IndexOutOfRangeException) {
                // allow it
            }

            int ones = int.Parse (onesString);
            if (tensString != null)
            {
                int tens = int.Parse(tensString);
                if(tens == 1)
                {
                    int tensAndOnes = int.Parse(tensString+onesString);
                    result = OneToNinteen[tensAndOnes];
                }
                else
                {
                    result += TensMultiples[tens];
                }
            }
            else {
                result = OneToNinteen[ones];
            }

            // for (int i = inputDigits.Length - 1; i >= 0; i--) {
            //     string digitString = inputDigits[i].ToString ();
            //     int digitNum = int.Parse (digitString);
            //     result += " " + OneToNinteen[digitNum];

            //     if (i == 1) {
            //         string tensAndOnesString = inputDigits.Substring (1);
            //         int tensAndOnesDigits = int.Parse (tensAndOnesString);

            //         result += TensMultiples[digitNum];
            //     } else if (i == 2 && digitNum != 0) { }
            // }

            // return result;
        }

    }
}