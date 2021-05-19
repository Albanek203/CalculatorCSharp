namespace Calculator {
    internal interface IBinConvertor {
        string ConvertBinToOct(string binaryNumber);
        string ConvertBinToDec(string binaryNumber);
        string ConvertBinToHex(string binaryNumber);
        string ConvertDecToBin(string decimalNumber);
         string ConvertDecToOct(string decimalNumber);
         string ConvertDecToHex(string decimalNumber);
         string ConvertOctToBin(string octalNumber);
         string ConvertOctToDec(string octalNumber);
         string ConvertOctToHex(string octalNumber);
         string ConvertHexToBin(string hexNumber);
         string ConvertHexToOct(string hexNumber);
         string ConvertHexToDec(string hexNumber);
    }
}
