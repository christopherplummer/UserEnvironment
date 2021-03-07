namespace UserEnvironment.Models
{
    public class Person
    {
        public Person()
        {
            FirstName = "Not valid";
            LastName = "Not valid";
            Address = new Address();
        }
        
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = new Address();
        }
        
        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Address Address { get; private set; }
    }
}