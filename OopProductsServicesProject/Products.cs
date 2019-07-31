using System;
using System.Collections.Generic;
using System.Text;

//Products -- ID (int) Name (String) Price (Decimal) Units sold (int) Basic, Advanced, Supreme Widgets

namespace OopProductsServicesProject {

    public class Products : ProServNames {

        public decimal Price { get; set; }
        public int Units { get; set; }

        public override decimal CalcSales() {
            return Price * Units;
        }
        public Products(int ID, string Names, decimal Price, int Units) : base (ID, Names) {
            this.Price = Price;
            this.Units = Units;
        }       
    }
}
