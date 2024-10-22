namespace JogoForca.providers
{
    public class Game
    {
        public void New(Word word, Player p)
        {
            string newWord = word.Generate();
            string secret = "".PadRight(newWord.Length, '_');
            string input = "";

            while (newWord != secret && p.life > 0)
            {
                Console.WriteLine("Tentativas restantes: " + p.life);

                input = p.MakeATry();

                if (input == "")
                {
                    continue;
                }

                if (!newWord.ToLower().Contains(input.ToLower()) || secret.ToLower().Contains(input.ToLower()))
                {
                    p.LoseLife();
                    continue;
                }

                secret = AttemptLetter(newWord, secret, input);
                Console.WriteLine(secret);
            }
        }

        static private string AttemptLetter(string word, string secret, string letter)
        {
            string aux = secret;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString().ToLower() == letter.ToLower())
                {
                    aux = aux.Remove(i, 1).Insert(i, word[i].ToString());
                }
            }

            return aux;
        }
    }
}
