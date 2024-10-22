namespace JogoForca.providers
{
    public class Player
    {
        public int life { get; private set; }

        public Player() {
            life = 5;
        }

        public void LoseLife()
        {
            life--;
        }

        public string MakeATry()
        {
            Console.WriteLine("Digite uma letra: ");
            return Console.ReadLine()!;
        }
    }
}
