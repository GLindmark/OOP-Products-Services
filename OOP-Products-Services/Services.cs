using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Products_Services {
    public class Services : Base {

        public int Rate { get; set; }
        public int Hours { get; set; }

        public int TotalServiceSales() {
            return Rate * Hours;
        }    

    }
}

namespace OopProductsServicesProject {

    public class Service : SalesItem {

        public int Rate { get; set; }
        public int Hours { get; set; }

        public override decimal CalcSales() {//has to be Override to use parent, but this uses Rate and Hours
            return Rate * Hours;
        }

        public Service(int Id, string Name, int Rate, int Hours)
            : base(Id, Name) {//uses base constructor
            this.Rate = Rate;//adds Rate and Hours to the body of the constructor
            this.Hours = Hours;
        }
    }
}
