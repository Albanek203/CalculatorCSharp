using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    struct TypeConvertion {
        public string sTypeName;
        public string sFromName;
        public string sToName;
        public double dCoef;
        public TypeConvertion(string sType, string sFrom, string sTo, double coef) {
            sTypeName = sType;
            sFromName = sFrom;
            sToName = sTo;
            dCoef = coef;
        }
        public TypeConvertion[] TypesConvert() {
            TypeConvertion[] m_aTypes;
            m_aTypes = new TypeConvertion[] {
                new TypeConvertion("USD to UAH", "USD", "UAH", 27 ),
                new TypeConvertion("Kilometer to Meter", "Kilometer:", "Meter:", 1000 ),
                new TypeConvertion("Meter to Centimeter", "Meter:", "Centimeter:", 100),
                new TypeConvertion("Inches to Meter", "Inches:", "Meter:", 0.0254),
                new TypeConvertion("Pounds to Kilogram", "Pound:", "Kg:", 0.45)
            };
            return m_aTypes;
        }
        public TypeConvertion[] TypeConvertionsBin() {
            TypeConvertion[] m_aTypesBin;
            m_aTypesBin = new TypeConvertion[] {
                new TypeConvertion("Binary to Octal", "Binary:", "Octal:", 28 ),
                new TypeConvertion("Binary to Decimal", "Binary:", "Decimal:", 210 ),
                new TypeConvertion("Binary to Hex", "Binary:", "Hex:", 216 ),

                new TypeConvertion("Octal to Binary", "Octal:", "Binary:", 82 ),
                new TypeConvertion("Octal to Decimal", "Octal:", "Decimal:", 810 ),
                new TypeConvertion("Octal to Hex", "Octal:", "Hex:", 816 ),

                new TypeConvertion("Decimal to Binary", "Decimal:", "Binary:", 102 ),
                new TypeConvertion("Decimal to Octal", "Decimal:", "Octal:", 108 ),
                new TypeConvertion("Decimal to Hex", "Decimal:", "Hex:", 1016 ),                

                new TypeConvertion("Hex to Binary", "Hex:", "Binary:", 162 ),
                new TypeConvertion("Hex to Octal", "Hex:", "Octal:", 168 ),
                new TypeConvertion("Hex to Decimal", "Hex:", "Decimal:", 1610 )
            };
            return m_aTypesBin;
        }
        public TypeConvertion[] TypeConvertionsBinBottom() {
            TypeConvertion[] m_aTypesBinBottom;
            m_aTypesBinBottom = new TypeConvertion[] {
                new TypeConvertion("Bin", ":", ":", 0 ),
                new TypeConvertion("Oct", ":", ":", 0 ),
                new TypeConvertion("Dec", ":", ":", 0 ),
                new TypeConvertion("Hex", ":", ":", 0 )
            };
            return m_aTypesBinBottom;
        }
        public TypeConvertion[] Operation() {
            TypeConvertion[] operation;
            operation = new TypeConvertion[] {
                new TypeConvertion("Plus", ":", ":", 0 ),
                new TypeConvertion("Minus", ":", ":", 1 ),
                new TypeConvertion("Multiplic.", ":", ":", 2 ),
                new TypeConvertion("Division", ":", ":", 3 )
            };
            return operation;
        }
        public TypeConvertion[] BinOperation() {
            TypeConvertion[] binOperation;
            binOperation = new TypeConvertion[] {
                new TypeConvertion("AND", ":", ":", 0 ),
                new TypeConvertion("OR", ":", ":", 0 ),
                new TypeConvertion("XOR", ":", ":", 0 ),
                new TypeConvertion("<<", ":", ":", 0 ),
                new TypeConvertion(">>", ":", ":", 0 )
            };
            return binOperation;
        }
        private string CheckCorrectInputBin(string binaryNumber) {
            for(int i = 0; i < binaryNumber.Length; i++) {
                if(Char.IsLetter(binaryNumber[i]))
                    return "Letter";
                else if((int)binaryNumber[i] != 48 && (int)binaryNumber[i] != 49) {
                    return "Digit";
                }
            }
            return "Ok";
        }
        private string CheckCorrectInputDec(string decimalNumber) {
            for(int i = 0; i < decimalNumber.Length; i++) {
                if(Char.IsLetter(decimalNumber[i]))
                    return "Letter";
            }
            return "Ok";
        }
        public string ConvertBinToOct(string binaryNumber) {
            if(CheckCorrectInputBin(binaryNumber) == "Ok")
                return Convert.ToString(Convert.ToInt32(ConvertBinToDec(binaryNumber)), 8);
            else
                return "Incorrect data entry";
        }
        public string ConvertBinToDec(string binaryNumber) {
            if(CheckCorrectInputBin(binaryNumber) == "Ok")
                return Convert.ToInt32(binaryNumber, 2).ToString();
            else
                return "Incorrect data entry";
        }
        public string ConvertBinToHex(string binaryNumber) {
            if(CheckCorrectInputBin(binaryNumber) == "Ok")
                return Convert.ToInt32(binaryNumber, 2).ToString("X");
            else
                return "Incorrect data entry";
        }
        public string ConvertDecToBin(string decimalNumber) {
            if(CheckCorrectInputDec(decimalNumber) == "Ok") {
                int.TryParse(decimalNumber, out var dec);
                return Convert.ToString(dec, 2);
            }
            else
                return "Incorrect data entry";
        }
        public string ConvertDecToOct(string decimalNumber) {
            if(CheckCorrectInputDec(decimalNumber) == "Ok") 
                return ConvertBinToOct(ConvertDecToBin(decimalNumber));            
            else
                return "Incorrect data entry";
        }
        public string ConvertDecToHex(string decimalNumber) {
            if(CheckCorrectInputDec(decimalNumber) == "Ok") {
                int.TryParse(decimalNumber, out var dec);
                return $"{dec:X2}";
            }else 
                return "Incorrect data entry";

        }
        public string ConvertOctToBin(string octalNumber) {
            return ConvertDecToBin(ConvertOctToDec(octalNumber));            
        }
        public string ConvertOctToDec(string octalNumber) {
            int.TryParse(octalNumber, out var oct);
            var dec = 0;
            var i = 0;
            while(oct > 0) {
                dec += oct % 10 * (int)Math.Pow(8, i);
                oct /= 10;
                i++;
            }
            return dec.ToString();
        }
        public string ConvertOctToHex(string octalNumber) {
            return ConvertDecToHex(ConvertOctToDec(octalNumber));
        }
        public string ConvertHexToBin(string hexNumber) {
            return String.Join(String.Empty, hexNumber.Select(c => Convert.ToString(Convert.ToUInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        }
        public string ConvertHexToOct(string hexNumber) { 
            return Convert.ToString(Convert.ToInt32(hexNumber, 16), 8);
        }
        public string ConvertHexToDec(string hexNumber) {
            return Convert.ToInt32(hexNumber, 16).ToString();
        }
    };
}