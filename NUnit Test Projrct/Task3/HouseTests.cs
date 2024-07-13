using NUnit.Framework;
using Task3;


[TestFixture]
public class HouseTests
{
    [Test]
    public void AddressClone_CreatesShallowCopyTest()
    {
        // Arrange
        Address original = new Address { Street = "Main St", City = "Springfield", Country = "USA" };        
        
        // Act 
        Address clone = original.Clone();
        
        //Assert
        Assert.AreEqual(original.Street, clone.Street);
        Assert.AreEqual(original.City, clone.City);
        Assert.AreEqual(original.Country, clone.Country);
        Assert.AreNotSame(original, clone);
        TestContext.WriteLine($"TestAddressClone_CreatesShallowCopy: \nOriginal adress is {original}. " +
                              $" \nClone address is {clone}");
    }

    [Test]
    public void TestHouseClone_CreatesShallowCopy()
    {
        // Arrange
        Address address = new Address{ Street = "Main St", City = "Springfield", Country = "USA" };
        House original = new House { Rooms = 3, Address = address };
        
        //Act
        House clone = original.DeepClone();
        
        //Assert
        Assert.AreEqual(original.Rooms, clone.Rooms);
        Assert.AreEqual(original.Address.Street, clone.Address.Street);
        Assert.AreEqual(original.Address.City, clone.Address.City);
        Assert.AreEqual(original.Address.Country, clone.Address.Country);
        Assert.AreNotSame(original, clone);
        Assert.AreNotSame(original.Address, clone.Address);
        TestContext.WriteLine($"TestHouseClone_CreatesShallowCopy: " +
                              $"\nOriginal house address is: {original.Address}. " +
                              $"\nClone house address is: {clone.Address}");
    }

    [Test]
    public void TestHouseDeepClone_ChangesToOriginalDoNotAffectClone()
    {
        //Arrange
        Address address = new Address{ Street = "Main St", City = "Springfield", Country = "USA" };
        House original = new House { Rooms = 3, Address = address };

        //Act
        House clone = original.DeepClone();
        original.Address.Street = "Changed st";
        original.Rooms = 5;
        
        //Asserts
        Assert.AreNotEqual(original.Address.Street, clone.Address.Street, "The street addresses should be different after modification.");
        Assert.AreNotEqual(original.Rooms, clone.Rooms, "The number of rooms should be different after modification.");
        Assert.AreEqual("Main St", clone.Address.Street, "The street address of the clone should remain unchanged.");
        Assert.AreEqual(3, clone.Rooms, "The number of rooms in the clone should remain unchanged.");
        
        TestContext.WriteLine($"HouseDeepClone_ChangesToOriginalDoNotAffectClone: " +
                              $"\nOriginal house address is: {original.Address} and {original.Rooms} rooms." +
                              $" \nClone house address is {clone.Address} and {clone.Rooms}");

    }
}