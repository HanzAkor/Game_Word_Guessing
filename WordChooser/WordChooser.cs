using System;
using System.Text;

namespace WordChooser
{

  public class WordChooser
  {
    public readonly string[] DICTIONARY = {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};
    public Random rand;
    public WordChooser(Random rand) 
    {
      this.rand = rand;
    }

    public WordChooser()
    {
      this.rand = new Random();
    }

    public virtual string GetRandomWordFromDictionary() 
    {
      return DICTIONARY[rand.Next(DICTIONARY.Length)];
    }
  }
}
