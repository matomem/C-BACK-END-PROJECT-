using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CryptoExchange.Backend.Luno
{
    // Data models for Luno API responses will go here
    // Example:
    // public class Ticker
    // {
    //     public string pair { get; set; }
    //     public string timestamp { get; set; }
    //     public string bid { get; set; }
    //     public string ask { get; set; }
    //     public string last_trade { get; set; }
    //     public string rolling_24_hour_volume { get; set; }
    //     public string status { get; set; }
    // }

    public class LunoApiConfig
    {
        // Configuration properties will go here (e.g., ApiKey, ApiSecret, BaseUrl)
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public string BaseUrl { get; set; }
    }

    public class Ticker
    {
        [JsonPropertyName("pair")]
        public string Pair { get; set; }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        [JsonPropertyName("bid")]
        public string Bid { get; set; }

        [JsonPropertyName("ask")]
        public string Ask { get; set; }

        [JsonPropertyName("last_trade")]
        public string LastTrade { get; set; }

        [JsonPropertyName("rolling_24_hour_volume")]
        public string Rolling24HourVolume { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class ListTickersResponse
    {
        [JsonPropertyName("tickers")]
        public List<Ticker> Tickers { get; set; }
    }

    public class AccountBalance
    {
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        [JsonPropertyName("asset")]
        public string Asset { get; set; }

        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("reserved")]
        public string Reserved { get; set; }

        [JsonPropertyName("unconfirmed")]
        public string Unconfirmed { get; set; }
    }

    public class ListBalancesResponse
    {
        [JsonPropertyName("balance")]
        public List<AccountBalance> Balance { get; set; }
    }

    // Models for Orders (using v2 structure as it's more detailed)
    public class Order
    {
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        [JsonPropertyName("client_order_id")]
        public string ClientOrderId { get; set; }

        [JsonPropertyName("pair")]
        public string Pair { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } // e.g., LIMIT

        [JsonPropertyName("side")]
        public string Side { get; set; } // e.g., BUY, SELL

        [JsonPropertyName("status")]
        public string Status { get; set; } // e.g., PENDING, COMPLETE

        [JsonPropertyName("limit_price")]
        public string LimitPrice { get; set; }

        [JsonPropertyName("limit_volume")]
        public string LimitVolume { get; set; }

        [JsonPropertyName("creation_timestamp")]
        public long CreationTimestamp { get; set; }

        [JsonPropertyName("completed_timestamp")]
        public long? CompletedTimestamp { get; set; } // Nullable

        [JsonPropertyName("fee_base")]
        public string FeeBase { get; set; }

        [JsonPropertyName("fee_counter")]
        public string FeeCounter { get; set; }

        // Add other relevant fields from v2 API if needed
    }

    public class ListOrdersResponse
    {
        [JsonPropertyName("orders")]
        public List<Order> Orders { get; set; }
    }
} 