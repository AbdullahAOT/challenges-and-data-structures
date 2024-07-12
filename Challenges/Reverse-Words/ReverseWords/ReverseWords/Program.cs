namespace ReverseWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The string sentence: ");
            String sentence=Console.ReadLine();
            Console.WriteLine("The reversed word is: ");
            Console.WriteLine(ReverseWordsFunction(sentence));
        }
        public static String ReverseWordsFunction(String sentence)
        {
            List<String> words = new List<String>();
            String wordToAdd = "";
            String reversedWord = "";
            for(int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i] == ' ' || i == sentence.Length-1)
                {
                    if(i == sentence.Length-1 && sentence[i] != ' ')
                    {
                        wordToAdd += sentence[i];
                    }
                    words.Add(wordToAdd);
                    wordToAdd = "";
                    continue;
                }
                wordToAdd += sentence[i];
            }
            for(int i = words.Count-1; i >= 0; i--)
            {
                if(i == 0)
                {
                    reversedWord += words[i];
                    continue;
                }
                reversedWord += words[i] + " ";
            }
            return reversedWord;
        }
    }
}