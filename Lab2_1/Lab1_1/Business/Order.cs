using System;
using System.Collections.Generic;

namespace Lab1_1
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public List<Product> products { get; set; }
        public int ShopID { get; set; }
        public DateTime Created { get; set; }
        private int DaysValid { get; set; }

        //public Order(int ci, int si, List<Product> p)
 //       {
   //         Random random = new Random();
     //       ID = random.Next(1, 10000);
       //     CustomerID = ci;
         //   ShopID = si;
           // products = p;
            //Created = DateTime.Now;
        //}

        public Order() {
            Created = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("Order {0}   by customer {1}     from shop {2}  ", ID, CustomerID, ShopID);
        }

        public bool IsValid()
        {
            return Created.AddDays(DaysValid) < DateTime.Now;
        }
    }
}