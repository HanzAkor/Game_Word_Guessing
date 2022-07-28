using System.Text;
using WordChooser;

namespace Game 
{
  public class Game 
  { 
    public string _secretWord;
    public int _attemptCounter;
    public WordChooser.WordChooser _wordChooser;

    public Game(string givenWord) 
    {
      _secretWord = givenWord;
      _attemptCounter = 10;
      _wordChooser = new WordChooser.WordChooser();
    }
    public Game() 
    {
      _wordChooser = new WordChooser.WordChooser();
      _secretWord = _wordChooser.GetRandomWordFromDictionary();
      _attemptCounter = 10;
    }

    public Game(WordChooser.WordChooser chooser) 
    {
      _wordChooser = chooser;
      _secretWord = _wordChooser.GetRandomWordFromDictionary();
      _attemptCounter = 10;
    }
   
    public string GetWordToGuess(string _secretWord) 
    {

      StringBuilder builder = new StringBuilder();
      
      for (int counter = 0; counter < _secretWord.Length; counter++) 
      {
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
  }
}
