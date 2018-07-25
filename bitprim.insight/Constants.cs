namespace bitprim.insight
{
    internal class Constants
    {
        public class Cache
        {
            public const int BLOCKCHAIN_HEIGHT_CACHE_ENTRY_SIZE = 1;
            public const int BLOCK_CACHE_CONFIRMATIONS = 6;
            public const int BLOCK_CACHE_ENTRY_SIZE = 10;
            public const int BLOCK_CACHE_SUMMARY_SIZE = 5;
            public const int CURRENT_PRICE_CACHE_ENTRY_SIZE = 1;
            public const int MAX_BLOCKCHAIN_HEIGHT_AGE_IN_SECONDS = 300; //5 Minutes
            public const string BLOCKCHAIN_HEIGHT_CACHE_KEY = "blockchain_height";
            public const string CURRENT_PRICE_CACHE_KEY = "current_price";
            public const string LONG_CACHE_PROFILE_NAME = "Long";
            public const string SHORT_CACHE_PROFILE_NAME = "Short";
        }
        
        public const int MAX_DELAY = 2;
        public const int MAX_RETRIES = 3;
        public const int SEED_DELAY = 100;
        public const int TRANSACTION_VERSION_PROTOCOL = 1;
        public const string BITSTAMP_BCCUSD = "bchusd";
        public const string BITSTAMP_BTCUSD = "btcusd";
        public const string BITSTAMP_LTCUSD = "ltcusd";
        public const string BITSTAMP_CURRENCY_PAIR_PLACEHOLDER = "{currency_pair}";
        public const string BITSTAMP_URL = "https://www.bitstamp.net/api/v2/ticker/" + BITSTAMP_CURRENCY_PAIR_PLACEHOLDER;
        public const string GET_BEST_BLOCK_HASH = "getBestBlockHash";
        public const string GET_DIFFICULTY = "getDifficulty";
        public const string GET_LAST_BLOCK_HASH = "getLastBlockHash";

        public const int WIN_HTTP_EXCEPTION_ERR_NUMBER = -2147012865;
    }
}
