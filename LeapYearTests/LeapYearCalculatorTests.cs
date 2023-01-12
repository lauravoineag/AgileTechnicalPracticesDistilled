
using LeapYear;
using NUnit.Framework;

namespace LeapYearTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void when_I_pass_in_2023_then_I_will_get_false()
    {
        //Arrange
        var leapYearCalc = new LeapYearCalc();
        //Act
        var actual = leapYearCalc.IsLeapYear(2023);
        //Assert
        Assert.That(actual, Is.EqualTo(false));
    }
    
    [Test]
    public void when_I_pass_in_2024_then_I_will_get_true()
    {
        //Arrange
        var leapYearCalc = new LeapYearCalc();
        //Act
        var actual = leapYearCalc.IsLeapYear(2024);
        //Assert
        Assert.That(actual, Is.EqualTo(true));
    } 
}
    