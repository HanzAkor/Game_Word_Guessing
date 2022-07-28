using System.Text;

namespace Game 
{
  public class Game 
  { 
    public string _secretWord;
    public int _attemptCounter;
    public readonly string[] DICTIONARY = {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};

    public Random rand;
    public Game(string word = "Hello") {
      _secretWord = word;
      _attemptCounter = 10;
      this.rand = new Random();
    }
    public Game(Random rand, string word = "Hello") {
      _secretWord = word;
      _attemptCounter = 10;
      this.rand = rand;
    }
   
    public string GetWordToGuess(string _secretWord) {

      // string secretWord = "MAKERS";

      StringBuilder builder = new StringBuilder();
      
      for (int counter = 0; counter < _secretWord.Length; counter++) {
        char currentLetter = _secretWord[0];
        if (counter == 0) {
            builder.Append(currentLetter);
        } else {
            builder.Append("_");
        }
      }
    return builder.ToString();
    }  
  
    public int Counter(int _attemptCounter) {
      return _attemptCounter;
    }
  
    public string GetRandomWordFromDictionary() {
      return DICTIONARY[rand.Next(DICTIONARY.Length)];
    }
  }
}
