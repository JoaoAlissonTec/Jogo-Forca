using JogoForca.providers;
namespace JogoForca
{
    public class App
    {
        public static void Initialize()
        {
            Word word = new();
            Player p1 = new();

            Game game = new();
            
            game.New(word, p1);
        }
    }
}
