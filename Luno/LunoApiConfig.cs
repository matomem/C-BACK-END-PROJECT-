namespace CryptoExchange.Backend.Luno;

public sealed class LunoApiConfig
{
    public string ApiKey { get; set; } = string.Empty;
    public string ApiSecret { get; set; } = string.Empty;
    public string BaseUrl { get; set; } = "https://api.luno.com";
}
