using TDDLearning.Core;

namespace TDDLearning.Tests;

[TestFixture]
public class WordAnalyserTests
{
    private WordAnalyser _analyser;

    [SetUp]
    public void Setup()
    {
        _analyser = new WordAnalyser();
    }

    [Test]
    [TestCase(Description = "It finds the longest word in a simple sentence")]
    public void FindLongestWords_SimpleSentence_ReturnsLongestWord()
    {
        string input = "This is a fairly boring sentence.";
        var result = _analyser.FindLongestWords(input);
        Assert.That(result, Contains.Item("sentence"));
    }

    [Test]
    [TestCase(Description = "It finds multiple longest words that share same length")]
    public void FindLongestWords_SameLengthLongestWords_ReturnsLongestWords()
    {
        string input = "This is a fairly boring thing.";
        var result = _analyser.FindLongestWords(input);
        Assert.Multiple(() =>
        {
            Assert.That(result, Contains.Item("fairly"));
            Assert.That(result, Contains.Item("boring"));
        });
    }

    [Test]
    [TestCase(Description = "It returns 3 if asked how many `l` in `Hello world`")]
    public void CalculateLetterFrequency_HelloWorld_l_Returns3()
    {
        string input = "Hello world";
        var result = _analyser.CalculateLetterFrequency(input);
        Assert.That(result['l'], Is.EqualTo(3));
    }

    [Test]
    [TestCase(Description = "It returns 0 if trying to get a letter not in the string")]
    public void CalculateLetterFrequency_GetLetterNotInString_Returns0()
    {
        string input = "This is a fairly boring thing.";
        var result = _analyser.CalculateLetterFrequency(input);
        int zInInput = result.GetValueOrDefault('z');
        Assert.That(zInInput, Is.EqualTo(0));
    }
}
