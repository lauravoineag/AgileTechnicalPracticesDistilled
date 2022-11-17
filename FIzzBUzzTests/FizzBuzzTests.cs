using FIzzBUzz;
using NUnit.Framework;


namespace FixBuzzTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    //1
    public void when_I_FIzzBuzz_1_I_will_get_string_1()
    {
        //arrange 4
        var fizzBuzz = new FizzBuzz();
        //act 3
        var actual = fizzBuzz.Execute(1);
        //assert 2
        Assert.That(actual, Is.EqualTo("1"));
    }

    [Test]
    //1
    public void when_I_FIzzBuzz_2_I_will_get_string_2()
    {
        //arrange 4
        var fizzBuzz = new FizzBuzz();
        //act 3
        var actual = fizzBuzz.Execute(2);
        //assert 2
        Assert.That(actual, Is.EqualTo("2"));
    }

    [Test]
    //1
    public void when_I_FIzzBuzz_3_I_will_get_string_Fizz()
    {
        //arrange 4
        var fizzBuzz = new FizzBuzz();
        //act 3
        var actual = fizzBuzz.Execute(3);
        //assert 2
        Assert.That(actual, Is.EqualTo("Fizz"));
    }

    [Test]
    public void when_I_FizzBuzz_4_I_will_get_string_4()
    {
        //arrange
        var fizzBuzz = new FizzBuzz();
        //act
        var actual = fizzBuzz.Execute(4);
        //assert
        Assert.That(actual, Is.EqualTo("4"));
    }

    [Test]
    public void when_I_FizzBuzz_5_I_will_get_string_Buzz()
    {
        //arrange
        var fizzBuzz = new FizzBuzz();
        //act
        var actual = fizzBuzz.Execute(5);
        //assert
        Assert.That(actual, Is.EqualTo("Buzz"));
    }
    
    [Test]
    public void when_I_FizzBuzz_6_I_will_get_string_Buzz()
    {
        //arrange
        var fizzBuzz = new FizzBuzz();
        //act
        var actual = fizzBuzz.Execute(5);
        //assert
        Assert.That(actual, Is.EqualTo("Buzz"));
    }
    
    // [Test]
    // public void when_I_FizzBuzz_15_I_will_get_string_FizzBuzz()
    // {
    //     //arrange
    //     var fizzBuzz = new FizzBuzz();
    //     //act
    //     var actual = fizzBuzz.Execute(15);
    //     //assert
    //     Assert.That(actual, Is.EqualTo("FizzBuzz"));
    // }
}