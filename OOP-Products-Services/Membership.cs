using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Products_Services {
    public class Membership : Base {

        public int Fee { get; set; };
        public int Units { get; set; };

        public override decimal CalcSales()

        public Memership(int Id, string Name, int Fee, int Units)
            : base(Id, Name) {
            this.Fee = Fee;
            this.Units = Units;
        }
    }
}
