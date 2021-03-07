using UserEnvironment.Models;
using Xunit;

namespace UserEnvironment.Tests.ModelTests
{
    public class UserTests
    {
        [Fact]
        public void ItConstructs_User_NoParameters()
        {
            var user = new User();
            
            Assert.Equal("Not valid", user.UserName);
            Assert.Equal("Not valid", user.Password);
            Assert.Equal("Not valid", user.Person.FirstName);
            Assert.Equal("Not valid", user.Person.LastName);
            Assert.Equal("Not valid", user.Person.Address.Street);
            Assert.Equal("Not valid", user.Person.Address.Street2);
            Assert.Equal("Not valid", user.Person.Address.City);
            Assert.Equal("Not valid", user.Person.Address.State);
            Assert.Equal("Not valid", user.Person.Address.ZipCode);
        }
        
        [Fact]
        public void ItConstructs_User_NoPerson()
        {
            var user = new User("SwoleGuy", "Bigly6458");
            
            Assert.Equal("SwoleGuy", user.UserName);
            Assert.Equal("Bigly6458", user.Password);
            Assert.Equal("Not valid", user.Person.FirstName);
            Assert.Equal("Not valid", user.Person.LastName);
            Assert.Equal("Not valid", user.Person.Address.Street);
            Assert.Equal("Not valid", user.Person.Address.Street2);
            Assert.Equal("Not valid", user.Person.Address.City);
            Assert.Equal("Not valid", user.Person.Address.State);
            Assert.Equal("Not valid", user.Person.Address.ZipCode);
        }
        
        [Fact]
        public void ItConstructs_User_WithPerson()
        {
            var address = new Address("5678 Baller Avenue", "Apt 420", "Slickville", "Arkansas", "34687");
            var person = new Person("Swole", "Bigly", address);
            var user = new User("SwoleGuy", "Bigly6458", person);
            
            Assert.Equal("SwoleGuy", user.UserName);
            Assert.Equal("Bigly6458", user.Password);
            Assert.Equal("Swole", user.Person.FirstName);
            Assert.Equal("Bigly", user.Person.LastName);
            Assert.Equal("5678 Baller Avenue", user.Person.Address.Street);
            Assert.Equal("Apt 420", user.Person.Address.Street2);
            Assert.Equal("Slickville", user.Person.Address.City);
            Assert.Equal("Arkansas", user.Person.Address.State);
            Assert.Equal("34687", user.Person.Address.ZipCode);
        }
    }
}