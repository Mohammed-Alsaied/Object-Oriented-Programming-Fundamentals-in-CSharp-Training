using ACME.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int pruductId)
        {
            ProductId = pruductId;
        }

        public decimal? CurrentPrice { get; set; }// ? refer to Nullable value -> 0 is Valid price,Null not Valid Price
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        //public string ProductName { get; set; }

        //public override string ToString() => ProductName;

        // Building Reusable Componenet


        public string Log() =>
            $"{ProductId}:{ProductName} Detail:{ProductDescription} Status:{EntityState.ToString()}";
        private string _prductName;
        public string ProductName
        {
            get

            {
                //var stringHandler = new StringHandler();
                return _prductName.InsrtSpaces(); // Extension Method
            }

            set
            {
                _prductName = value;
            }
        }


        public override bool Validate()
        {
            var isValide = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValide = false;
            if (string.IsNullOrWhiteSpace(ProductDescription)) isValide = false;
            if (CurrentPrice == null) isValide = false;

            return isValide;
        }

        //public Product Retrieve(int productId)
        //{
        //    return new Product();
        //}

        //public List<Product> Retrieve()
        //{
        //    return new List<Product>();
        //}

        //public bool Save()
        //{
        //    return true;
        //}

    }
}
