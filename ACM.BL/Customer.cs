using ACME.Common;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0) // Defualt Constructor
        {

        }

        public Customer(int customerId) // Parameters Constructor
        {
            CustomerId = customerId;
            AddressList = new List<Address>(); // Composition Relation 
        }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        //public Address HomeAddress { get; set; }
        //public Address WorkAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }// usee this if no logic code to apply


        public string FullName //use this if logic code want to aplly
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }

        }

        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }

        //public string Log()
        //{
        //    var LogString = CustomerId + ": " +
        //                    FullName + " " +
        //                    "Email: " + EmailAddress + " " +
        //                    "Status: " + EntityState.ToString();
        //    return LogString;
        //}
        public string Log() =>
            $"{CustomerId}:{FullName} Email:{EmailAddress} Status:{EntityState.ToString()}";

        public override string ToString() => FirstName;
        public static int InstanceCount { get; set; }
        // Static Modifier used if the members belongs to Class not Object or Instancs of Class



        // Validate the Customer Data.
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
