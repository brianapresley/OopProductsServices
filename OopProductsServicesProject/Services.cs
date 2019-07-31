using System;
using System.Collections.Generic;
using System.Text;

//Services -- ID(int), Name(string), Rate(int), Hours(int), Basic Support/Priority Support/24x7 Support

namespace OopProductsServicesProject {

    public class Services : ProServNames {

        public int Rate { get; set; }
        public int Hours { get; set; }

        public override decimal CalcSales() {
            return Rate * Hours;
        }
        public Services(int ID, string Names, decimal Price, int Units) : base(ID, Names) {
            this.Rate = Rate;
            this.Hours = Hours;
        }

    }
}
