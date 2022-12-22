using System;

namespace ACM.BL
{
    public class ProductRipository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if (productId == 2)
            {
                product.CurrentPrice = 15.96M;
                product.ProductName = "Sunflowers";
                product.ProductDescription = "simple";

            }

            Object myObject = new Object();
            Console.WriteLine($"Object:{myObject.ToString()}");
            Console.WriteLine($"Product:{product.ToString()}");
            return product;

        }


        public bool Save(Product product)
        {
            // Code that saves the defined customer
            var success = true;
            if (product.HasChanges)
            {
                if (product.Isvalid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
