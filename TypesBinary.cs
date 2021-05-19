using System.Collections.Generic;
using System.IO;
namespace Calculator {
    public class TypesBinary:Types {
        protected override void Load() {
            LstTypesOrders = new List<TypesOrder> {
                new Types("Bin", ":", ":", 0)
              , new Types("Oct", ":", ":", 0)
              , new Types("Dec", ":", ":", 0)
              , new Types("Hex", ":", ":", 0)
            };
        }
    }
}