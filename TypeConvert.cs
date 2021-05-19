using System.Collections.Generic;
using System.IO;

namespace Calculator {
    public class TypeConvert: Types {
        protected override void Load() { 
            LstTypesOrders = new List<TypesOrder> {
                new Types("USD to UAH", "USD", "UAH", 27 ),
                new Types("Kilometer to Meter", "Kilometer:", "Meter:", 1000 ),
                new Types("Meter to Centimeter", "Meter:", "Centimeter:", 100),
                new Types("Inches to Meter", "Inches:", "Meter:", 0.0254),
                new Types("Pounds to Kilogram", "Pound:", "Kg:", 0.45)
            };
        }
    }
}