namespace JogoForca.interfaces
{
    internal interface IApiService
    {
        public T Get<T>(string? url) where T : class;
    }
}
