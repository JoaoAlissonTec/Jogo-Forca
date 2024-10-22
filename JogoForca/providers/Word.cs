using JogoForca.models;
namespace JogoForca.providers
{
    public class Word
    {
        private string? _word;

        public string Generate()
        {
            API api = new API();
            _word = api.Get<RandomWord>("https://api.dicionario-aberto.net/random").word;
            _word = System.Text.RegularExpressions.Regex.Replace(_word, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ\s]+?", string.Empty);

            return _word;
        }
    }
}
