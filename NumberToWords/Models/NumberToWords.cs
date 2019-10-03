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

        public List<string> GroupDigits (string input) 
        {
            int length = input.Length;
            List<string> groupedDigits = new List<string> ();
            string threeDigits = "";
            for (int i = 0; i < input.Length; i++) {
                if (i % 3 == 0 && i != 0) {
                    groupedDigits.Add (threeDigits);
                    threeDigits = input[i].ToString ();
                } else {
                    threeDigits += input[i].ToString ();
                }
            }
            return groupedDigits;
        }

        public string ConvertAll(List<string> groupedDigits)
        {
            string result = "";
            int groupsCount = groupedDigits.Count;
            for(int i = 0; i < groupsCount; i++)
            {
                if(groupsCount == 1)
                {
                    result = Convert(groupsCount[0]);
                }
            }
        }

        public string Converter (string inputDigits) {
            int numLength = inputDigits.Length;
            string result = "";

            char onesString = ';';
            char tensString = ';';
            char hundredsString = ';';

            try {
                onesString = inputDigits[inputDigits.Length - 1];
                tensString = inputDigits[inputDigits.Length - 2];
                hundredsString = inputDigits[inputDigits.Length - 3];;
            } catch (IndexOutOfRangeException) {
                // allow it
            }

            int ones = int.Parse (onesString.ToString ());
            if (tensString != ';' && tensString != '0') {
                int tens = int.Parse (tensString.ToString ());
                if (tens == 1) {
                    int tensAndOnes = int.Parse (tensString.ToString () + onesString.ToString ());
                    result = OneToNinteen[tensAndOnes];
                } else {
                    result = OneToNinteen[ones];
                    result = TensMultiples[tens] + " " + result;
                }
            } else {
                result = OneToNinteen[ones];
            }
            if (hundredsString != ';') {
                int hundreds = int.Parse (hundredsString.ToString ());
                result = OneToNinteen[hundreds] + " hundred " + result;
            }

            return result;
        }

    }
}