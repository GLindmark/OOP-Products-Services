﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Products_Services {
    public class Products : Base {

        public decimal Price { get; set; }
        public int Units { get; set; }

        public int TotalProductSales() {
            return Price * Units
        }


    }

}

/*
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
The output needs only show the grand total of all sales
*/
