using UserEnvironment.Models;
using Xunit;

namespace UserEnvironment.Tests.ModelTests
{
    public class PersonTests
    {
        [Fact]
        public void ItConstructs_Person_NoParameters()
        {
            var person = new Person();
            
            Assert.Equal("Not valid", person.FirstName);
            Assert.Equal("Not valid", person.LastName);
            Assert.Equal("Not valid", person.Address.Street);
            Assert.Equal("Not valid", person.Address.Street2);
            Assert.Equal("Not valid", person.Address.City);
            Assert.Equal("Not valid", person.Address.State);
            Assert.Equal("Not valid", person.Address.ZipCode);
        }
        
        [Fact]
        public void ItConstructs_Person_NoAddress()
        {
            var person = new Person("Swole", "Bigly");
            
            Assert.Equal("Swole", person.FirstName);
            Assert.Equal("Bigly", person.LastName);
            Assert.Equal("Not valid", person.Address.Street);
            Assert.Equal("Not valid", person.Address.Street2);
            Assert.Equal("Not valid", person.Address.City);
            Assert.Equal("Not valid", person.Address.State);
            Assert.Equal("Not valid", person.Address.ZipCode);
        }
        
        [Fact]
        public void ItConstructs_Person_WithAddress()
        {
            var address = new Address("5678 Baller Avenue", "Apt 420", "Slickville", "Arkansas", "34687");
            var person = new Person("Swole", "Bigly", address);
            
            Assert.Equal("Swole", person.FirstName);
            Assert.Equal("Bigly", person.LastName);
            Assert.Equal("5678 Baller Avenue", person.Address.Street);
            Assert.Equal("Apt 420", person.Address.Street2);
            Assert.Equal("Slickville", person.Address.City);
            Assert.Equal("Arkansas", person.Address.State);
            Assert.Equal("34687", person.Address.ZipCode);
        }
    }
}