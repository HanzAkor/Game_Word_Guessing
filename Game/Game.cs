using System.Text;

namespace Game 
{
  public class Game 
  { 
    private string _secretWord;
    private int _attemptCounter = 10;

    public readonly string[] DICTIONARY = {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};
    public Game(string word = "Hello") {
      _secretWord = word;
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
      Random rand = new Random();
      return DICTIONARY[rand.Next(DICTIONARY.Length)];
    }
  }
}
