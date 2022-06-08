using System;
using System.Collections.Generic;
using System.Text;

namespace New
{
    class Store 
    {

        public Product[] products;

        public void AddProduct(Product product)
        {

            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;

        }
        public int PhoneCount()

        {
            var count = 0;
            foreach (var item in products)
            {
               
                    if (item is Phone)
                    {
                        count++;
                    }

            }
            return count;
        }

        public int GetNotebookCount()

        {
            var count = 0;
            foreach(var item in products)
            {
               
                if(item is Notebook)
                    {
                        count++;
                    }
                
            }
            return count;
        }





    }
}
