using System;

//Create a system that calculates total of all products and services sold; Should create a base class that contains the names  

/*# Object-oriented programming
​
Your task is to create a report that displays the total sales of products and services.
​
Product
==================
Id int (optional)
Name string
Price decimal
Units int
​
Service
==================
Id int (optional)
Name string
Rate int
Hours int
​
The company has three products: 
1. Basic Widget     - Price: $10 each; Units: 2500
2. Advanced Widget  - Price: $25 each; Units: 1500
3. Supreme Widget   - Price: $50 each; Units: 1000
​
The company has three services:
1. Basic Support    - Rate: $25/hr; Hours 1000
2. Priority Support - Rate: $50/hr; Hours 550
3. 24x7 Support     - Rate: $100/hr; Hours 750
​
The output needs only show the grand total of all sales */

namespace OopProductsServicesProject {
    class Program {
        static void Main(string[] args) {

            var pBW = new Products(1, "Basic Widget", 10, 2500);
            var pAW = new Products(2, "Advanced Widget", 25, 1500);
            var pSW = new Products(3, "Supreme Widget", 50, 1000);

            var sBS = new Services(11, "Basic Support", 25, 1000);
            var sPS = new Services(12, "Priority Support", 50, 550);
            var s247 = new Services(13, "24x7 Support", 100, 750);

            var sales = new ProServNames[] {
                pBW, pAW, pSW, sBS, sPS, s247,

                new Membership(21, "Basic Membership", 100, 1500), //Instead of creating a new variable, create the instance inside the array
                new Membership(22, "Advanced Membership", 200, 700),
                new Membership(23, "Premier Membership", 400, 300)

            };

            var total = 0M;

            foreach (var sale in sales) {
                total += sale.CalcSales();
            }

            Console.WriteLine($"Total sales is ${total}");
        }
    }
}
