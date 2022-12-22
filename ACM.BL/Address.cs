namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;

        }

        public int AddressId { get; private set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }

        public bool Validate()
        {
            var IsValid = true;
            //if (string.IsNullOrWhiteSpace(StreetLine1)) IsValid = false;
            //if (string.IsNullOrWhiteSpace(StreetLine2)) IsValid = false;
            //if (string.IsNullOrWhiteSpace(City)) IsValid = false;
            //if (string.IsNullOrWhiteSpace(State)) IsValid = false;
            //if (string.IsNullOrWhiteSpace(Country)) IsValid = false;
            //if (AddressType == null) IsValid = false;
            if (PostalCode == null) IsValid = false;

            {

            }

            return IsValid;

        }
    }
}
