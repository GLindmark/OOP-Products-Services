using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Products_Services {
    public class Base {

        public string Name { get; set; }
    }
}



namespace OopProductsServicesProject {

    public class SalesItem {

        public int Id { get; set; }
        public string Name;

        public virtual decimal CalcSales() {//created but not used until Products and Services
            return decimal.MinusOne;//could have just thrown an error because it is not used here
        }//must be at the parent level because when the array is created on the Program class it can be used

        public SalesItem(int Id, string Name) {//constructor to initialize the Id and the name
            this.Id = Id;
            this.Name = Name;
        }
    }
}
