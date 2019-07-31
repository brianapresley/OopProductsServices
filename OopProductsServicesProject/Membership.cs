using System;
using System.Collections.Generic;
using System.Text;

namespace OopProductsServicesProject {
    public class Membership : ProServNames {

        public int Fee { get; set; }
        public int Units { get; set; }

        public override decimal CalcSales() {
            return Fee * Units;
        }

        public Membership(int ID, string Names, int Fee, int Units) : base(ID, Names) {
            this.Fee = Fee;
            this.Units = Units;
        }

    }
}
