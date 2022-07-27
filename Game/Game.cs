using System;
using System.Text;

namespace Game 
{
  public class Game 
  { 
    public string secretWord;
    public Game(string word) {
      this.secretWord = word;
    }
    public string GetWordToGuess() {
      StringBuilder builder = new StringBuilder();
      for (int counter = 0; counter < this.secretWord.Length; counter++) {
        char currentLetter = secretWord[0];
        if (counter == 0) {
            builder.Append(currentLetter);
        } else {
            builder.Append("_");
        }
      }
    return builder.ToString();
    }  
  }
}
