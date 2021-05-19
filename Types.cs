using System.Collections.Generic;
using System.IO;

namespace Calculator {
    public class Types: TypesOrder {
        protected List<TypesOrder> LstTypesOrders;
        protected Types() {
            Load();
            STypeName    = null;
            SFromName    = null;
            SToName      = null;
            DCoefficient = 0;            
        }
        public Types(string sTypeName, string sFromName, string sToName, double dCoefficient){
            this.STypeName    = sTypeName;
            this.SFromName    = sFromName;
            this.SToName      = sToName;
            this.DCoefficient = dCoefficient;
        }
        public List<TypesOrder> GetTypes() => LstTypesOrders;
        protected virtual void Load() {}
    }
}