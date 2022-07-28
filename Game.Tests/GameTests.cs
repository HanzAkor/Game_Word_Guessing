using NUnit.Framework;
using Game;
using System.Text;
using NSubstitute;

namespace Game.Tests {
  [TestFixture]
  public class GameTests {
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess() {
      Game game = new Game("MAKERS");
      Assert.AreEqual("M_____", game.GetWordToGuess("MAKERS"));
    }

    [Test]
    public void Game_Counter_GetRemainingAttempts() {
      Game game = new Game();
      Assert.AreEqual(10, game.Counter(10));
    }

    [Test]
    [TestCase("MAKERS")]
    [TestCase("CANDIES")]
    [TestCase("DEVELOPER")]
    [TestCase("LONDON")]
    public void Game_GetRandomWordFromDictionary_ReturnsRandomWordFromDictionary(string word) 
    {
      WordChooser.WordChooser fake_chooser = Substitute.For<WordChooser.WordChooser>();
      fake_chooser.GetRandomWordFromDictionary().Returns(word);
      Game game = new Game(fake_chooser);
      string result = game._secretWord;
      Assert.AreEqual(word, result);
    }

    // [Test]
    // public void WordToGuess_ReturnsRandomWordFromWordChooser()
    // {
    //   WordChooser.WordChooser mockWordChooser = Substitute.For<WordChooser.WordChooser>();
    //   mockWordChooser.GetRandomWordFromDictionary().Returns("DEVELOPER");

    //   Game game = new Game(mockWordChooser);

    //   Assert.AreEqual(game.GetWordToGuess(game._secretWord), "D________");
    // }
  }
}
