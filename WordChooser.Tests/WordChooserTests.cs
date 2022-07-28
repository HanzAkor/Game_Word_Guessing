using NUnit.Framework;
using WordChooser;
using System.Text;
using NSubstitute;
namespace WordChooser.Tests;


public class Tests
{
    [Test]
    [TestCase(0, "MAKERS")]
    [TestCase(1, "CANDIES")]
    [TestCase(2, "DEVELOPER")]
    [TestCase(3, "LONDON")]
    public void WordChooser_GetRandomWordFromDictionary_ReturnsRandomWordFromDictionary(int index, string word) 
    {
      Random fake_rand = Substitute.For<Random>();
      fake_rand.Next(4).Returns(index);
      WordChooser word_chooser = new WordChooser(fake_rand);
      string result = word_chooser.GetRandomWordFromDictionary();
      Assert.AreEqual(word, result);
    }
}