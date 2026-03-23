using TDDLearning.Core;
using StringManipulator = TDDLearning.Core.StringManipulator;


namespace TDDLearning.Tests;

public class StringManipulatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(Description = "Prints reversed string")]
    public void ReverseString_ReturnsReversedString()
    {
        string string1 = "";
        string string2 = "racecar";
        string string3 = "food";
        StringManipulator manipulator = new StringManipulator();

       

        Assert.Multiple(() =>
        {
            Assert.That(manipulator.ReverseString(string1), Is.EqualTo(""));
            Assert.That(manipulator.ReverseString(string2), Is.EqualTo("racecar"));
            Assert.That(manipulator.ReverseString(string3), Is.EqualTo("doof"));
        });
    }

    [Test]
    [TestCase(Description = "Check if input string is a palindromw")]
    public void IsPalindrome_ReturnsTrue()
    {
        string string1 = "";
        string string2 = "racecar";
        StringManipulator manipulator = new StringManipulator();



        Assert.Multiple(() =>
        {
            Assert.That(manipulator.IsPalindrome(string1), Is.EqualTo(true));
            Assert.That(manipulator.IsPalindrome(string2), Is.EqualTo(true));
        });
    }
}