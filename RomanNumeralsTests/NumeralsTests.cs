using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTests;

public class NumeralsTests
{
    private Numerals _numerals;
    
    [SetUp]
    public void Setup()
    {
        //arrange
        _numerals = new Numerals();
    }

    [Test]
    public void when_I_convert_number_1_I_will_get_numeral_I()
    {
        //act
        var actual = _numerals.Convert(1);
        //assert
        Assert.That(actual, Is.EqualTo("I"));
    }

    [Test]
    public void when_I_convert_number_2_I_will_get_numeral_II()
    {
        var actual = _numerals.Convert(2);
        
        Assert.That(actual, Is.EqualTo("II"));
    }

    [Test]
    public void when_I_convert_number_3_I_will_get_numeral_III()
    {
        //act
        var actual = _numerals.Convert(3);
        //assert
        Assert.That(actual, Is.EqualTo("III"));
    }
    
    [Test]
    public void when_I_convert_number_4_I_will_get_numeral_IV()
    {
        //act
        var actual = _numerals.Convert(4);
        //assert
        Assert.That(actual, Is.EqualTo("IV"));
    }

    [Test]
    public void when_I_convert_number_5_I_will_get_numeral_V()
    {
        var actual = _numerals.Convert(5);

        Assert.That(actual,Is.EqualTo("V"));
    }
    
}