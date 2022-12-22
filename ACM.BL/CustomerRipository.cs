using System.Linq;

namespace ACM.BL
{
    public class CustomerRipository // Cooporation Relation the Class used Instance from another Class
    {
        public CustomerRipository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        // Retrieve one Customer
        public Customer Retrieve(int customerId)
        {
            // Code that retrived the defined customer.

            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId)
                                                                .ToList();
            };
            return customer;
        }

        //Retrieve All Customers
        //public List<Customer> Retrieve()
        //{
        //    // Code that retrived all of the customers
        //    return new List<Customer>();
        //}


        public bool Save(Customer customer)
        {
            // Code that saves the defined customer
            var success = true;
            if (customer.HasChanges)
            {
                if (customer.Isvalid)
                {
                    if (customer.IsNew)
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
