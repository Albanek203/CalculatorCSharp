using System;
using System.Linq;

namespace Calculator {
    public struct BinConvertor: IBinConvertor {
        private string CheckCorrectInputBin(string binaryNumber) {
            foreach (var item in binaryNumber) {
                if (char.IsLetter(item)) return "Letter";
                if (item != 48 && item != 49) return "Digit";
            }
            return "Ok";
        }
        private string CheckCorrectInputDec(string decimalNumber) {
            return decimalNumber.Any(char.IsLetter) ? "Letter" : "Ok";
        }
        public string ConvertBinToOct(string binaryNumber) {
            return CheckCorrectInputBin(binaryNumber) == "Ok" ?
                Convert.ToString(Convert.ToInt32(ConvertBinToDec(binaryNumber)), 8) : "Incorrect data entry";
        }
        public string ConvertBinToDec(string binaryNumber) {
            return CheckCorrectInputBin(binaryNumber) == "Ok" ? Convert.ToInt32(binaryNumber, 2).ToString() :
                "Incorrect data entry";
        }
        public string ConvertBinToHex(string binaryNumber) {
            return CheckCorrectInputBin(binaryNumber) == "Ok" ? Convert.ToInt32(binaryNumber, 2).ToString("X") :
                "Incorrect data entry";
        }
        public string ConvertDecToBin(string decimalNumber) {
            if (CheckCorrectInputDec(decimalNumber) != "Ok") return "Incorrect data entry";
            int.TryParse(decimalNumber, out var dec);
            return Convert.ToString(dec, 2);
        }
        public string ConvertDecToOct(string decimalNumber) {
            return CheckCorrectInputDec(decimalNumber) == "Ok" ? ConvertBinToOct(ConvertDecToBin(decimalNumber)) :
                "Incorrect data entry";
        }
        public string ConvertDecToHex(string decimalNumber) {
            if (CheckCorrectInputDec(decimalNumber) != "Ok") return "Incorrect data entry";
            int.TryParse(decimalNumber, out var dec);
            return $"{dec:X2}";
        }
        public string ConvertOctToBin(string octalNumber) {
            return ConvertDecToBin(ConvertOctToDec(octalNumber));
        }
        public string ConvertOctToDec(string octalNumber) {
            int.TryParse(octalNumber, out var oct);
            var dec = 0;
            var i = 0;
            while (oct > 0) {
                dec += oct % 10 * (int) Math.Pow(8, i);
                oct /= 10;
                i++;
            }
            return dec.ToString();
        }
        public string ConvertOctToHex(string octalNumber) {
            return ConvertDecToHex(ConvertOctToDec(octalNumber));
        }
        public string ConvertHexToBin(string hexNumber) {
            return string.Join(string.Empty
                             , hexNumber.Select(c => Convert.ToString(Convert.ToUInt32(c.ToString(), 16), 2)
                                                            .PadLeft(4, '0')));
        }
        public string ConvertHexToOct(string hexNumber) {
            return Convert.ToString(Convert.ToInt32(hexNumber, 16), 8);
        }
        public string ConvertHexToDec(string hexNumber) {
            return Convert.ToInt32(hexNumber, 16).ToString();
        }
    }
}