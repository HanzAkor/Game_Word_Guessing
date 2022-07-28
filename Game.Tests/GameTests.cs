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
    [TestCase(0, "MAKERS")]
    [TestCase(1, "CANDIES")]
    [TestCase(2, "DEVELOPER")]
    [TestCase(3, "LONDON")]
    public void Game_GetRandomWordFromDictionary_ReturnsRandomWordFromDictionary(int index, string word) {
      Random fake_rand = Substitute.For<Random>();
      fake_rand.Next(4).Returns(index);
      Game game = new Game(fake_rand);
      string result = game.GetRandomWordFromDictionary();
      Console.WriteLine(result);
      Assert.AreEqual(word, result);
    }
  }
}