namespace UserEnvironment.Models
{
    public class Address
    {
        public Address()
        {
            Street = "Not valid";
            Street2 = "Not valid";
            City = "Not valid";
            State = "Not valid";
            ZipCode = "Not valid";
        }
        
        public Address(string street, string city, string state, string zipCode)
        {
            Street = street;
            Street2 = "";
            City = city;
            State = state;
            ZipCode = zipCode;
        }
        
        public Address(string street, string street2, string city, string state, string zipCode)
        {
            Street = street;
            Street2 = street2;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string Street { get; private set; }
        public string Street2 { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
    }
}