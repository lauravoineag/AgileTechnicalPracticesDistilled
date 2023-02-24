using NUnit.Framework;
using SimpleMarsRover;

namespace SimpleMarsRoverTests;

public class MarsRoverTests
{
    private MarsRover _marsRover;
    
    [SetUp]
    public void Setup()
    {
        //arrange
        _marsRover = new(3);
    }

    [Test]
    public void when_I_pass_M_I_receive_0_1_N_()
    {
        
        //act
        var expected = "0:1:N";
        var actual = _marsRover.Execute("M");
        //assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void when_I_pass_in_MM_I_receive_0_2_N_()
    {
        //arrange
        //act
        var expected = "0:2:N";
        var actual = _marsRover.Execute("MM");
        //assert
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void when_I_pass_in_MMM_I_receive_0_0_N_()
    {
        //arrange
        //act
        var expected = "0:0:N";
        var actual = _marsRover.Execute("MMM");
        //assert
        Assert.AreEqual(expected, actual);
    }
}