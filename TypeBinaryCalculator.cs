using System.Collections.Generic;
using System.IO;

namespace Calculator {
    public class TypeBinaryCalculator:Types {
        protected override void Load() { 
            LstTypesOrders = new List<TypesOrder> {
                new Types("Binary to Octal", "Binary:", "Octal:", 28)
              , new Types("Binary to Decimal", "Binary:", "Decimal:", 210)
              , new Types("Binary to Hex", "Binary:", "Hex:", 216)
              , new Types("Octal to Binary", "Octal:", "Binary:", 82)
              , new Types("Octal to Decimal", "Octal:", "Decimal:", 810)
              , new Types("Octal to Hex", "Octal:", "Hex:", 816)
              , new Types("Decimal to Binary", "Decimal:", "Binary:", 102)
              , new Types("Decimal to Octal", "Decimal:", "Octal:", 108)
              , new Types("Decimal to Hex", "Decimal:", "Hex:", 1016)
              , new Types("Hex to Binary", "Hex:", "Binary:", 162)
              , new Types("Hex to Octal", "Hex:", "Octal:", 168)
              , new Types("Hex to Decimal", "Hex:", "Decimal:", 1610)
            };
            
            
        }
    }
}