using NUnit.Framework;
using Task4;

[TestFixture]
public class DateTests
{
    [Test]
    public void TestDateDifference()
    {
        //Arrange
        Date date1 = new Date(1, 1, 2020);
        Date date2 = new Date(20, 1, 2020);
        
        //Act
        int difference = date1 - date2;
        
        //Assert
        Assert.AreEqual(-19, difference);
        TestContext.WriteLine($"TestDateDifference: Difference btw {date1} and {date2}" +
                              $"is {difference}");
    }

    [Test]
    public void TestAddDays()
    {
        //Arrange
        Date date = new Date(1, 1, 2024);
        
        //Act
        Date newDate = date + 10;
        
        //Assert
        Assert.AreEqual(11, newDate.Day);
        Assert.AreEqual(1, newDate.Month);
        Assert.AreEqual(2024, newDate.Year);
        TestContext.WriteLine($"TestAddDays: New date after addining 10 daye to {date} is " +
                              $"{newDate}");
    }

    [Test]
    public void TestAddDays_LeapYear()
    {
        //Arrange
        Date date = new Date(28, 2, 2024);
        
        //Act
        Date newDate = date + 2;
        
        //Assert
        Assert.AreEqual(1, newDate.Day);
        Assert.AreEqual(3, newDate.Month);
        Assert.AreEqual(2024, newDate.Year);
        TestContext.WriteLine($"TestAddDays_LeapYear: New date after adding 2 days to " +
                              $" {date} is {newDate}");
    }

    [Test]
    public void TestAddDays_EndOfYear()
    {
        //Arrange
        Date date = new Date(31, 12, 2023);
        
        //Act
        Date newDate = date + 1;
        
        //Assert
        Assert.AreEqual(1, newDate.Day);
        Assert.AreEqual(1, newDate.Month);
        Assert.AreEqual(2024, newDate.Year);
        TestContext.WriteLine($"TestAddDays_EndOfYear: New date after adding 1 dat to " +
                              $" {date} is {newDate}");

    }
}