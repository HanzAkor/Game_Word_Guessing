using NUnit.Framework;
using Game;
using System.Text;

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
    public void Game_GetRandomWordFromDictionary_ReturnsRandomWordFromDictionary() {
      Game game = new Game();
      Assert.AreEqual("MAKERS", game.GetRandomWordFromDictionary());
    }
  }
}