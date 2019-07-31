using System;
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProject {
    public class ProServNames {

        public int ID { get; set; }
        public string Names;

        public virtual decimal CalcSales() {
            return decimal.MinusOne;
        }

        public ProServNames(int ID, string Names) {
            this.ID = ID;
            this.Names = Names;
        }
        


    }
}
