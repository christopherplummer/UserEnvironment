using UserEnvironment.Models;
using Xunit;

namespace UserEnvironment.Tests.ModelTests
{
    public class AddressTests
    {
        [Fact]
        public void ItConstructs_Address_WithNoParameters()
        {
            var address = new Address();
            
            Assert.Equal("Not valid", address.Street);
            Assert.Equal("Not valid", address.Street2);
            Assert.Equal("Not valid", address.City);
            Assert.Equal("Not valid", address.State);
            Assert.Equal("Not valid", address.ZipCode);
        }
        
        [Fact]
        public void ItConstructs_Address_WithNoStreet2()
        {
            var address = new Address("5678 Baller Avenue", "Slickville", "Arkansas", "34687");
            
            Assert.Equal("5678 Baller Avenue", address.Street);
            Assert.Equal("Slickville", address.City);
            Assert.Equal("", address.Street2);
            Assert.Equal("Arkansas", address.State);
            Assert.Equal("34687", address.ZipCode);
        }
        
        [Fact]
        public void ItConstructs_Address_WithStreet2()
        {
            var address = new Address("5678 Baller Avenue", "Apt 420", "Slickville", "Arkansas", "34687");
            
            Assert.Equal("5678 Baller Avenue", address.Street);
            Assert.Equal("Apt 420", address.Street2);
            Assert.Equal("Slickville", address.City);
            Assert.Equal("Arkansas", address.State);
            Assert.Equal("34687", address.ZipCode);
        }
    }
}