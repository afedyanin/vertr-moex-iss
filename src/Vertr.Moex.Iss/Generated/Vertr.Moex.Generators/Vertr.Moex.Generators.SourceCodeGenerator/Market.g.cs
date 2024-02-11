namespace Vertr.Moex.Iss.Entities
{
    public partial class Market
    {
    
        /// <summary>
        /// Индексы фондового рынка
        /// </summary>
        public static readonly Market Stock_Index = new Market
        {
            Id = 5,
            MarketId = 5,
            Name = "index",
            Title = "Индексы фондового рынка",
            EngineId = 1,
            MarketPlace = "INDICES",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = false,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// Рынок акций
        /// </summary>
        public static readonly Market Stock_Shares = new Market
        {
            Id = 1,
            MarketId = 1,
            Name = "shares",
            Title = "Рынок акций",
            EngineId = 1,
            MarketPlace = "MXSE",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Рынок облигаций
        /// </summary>
        public static readonly Market Stock_Bonds = new Market
        {
            Id = 2,
            MarketId = 2,
            Name = "bonds",
            Title = "Рынок облигаций",
            EngineId = 1,
            MarketPlace = "MXSE",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = true,
            HasExtraYields = true,
            HasDelay = true,
        };


        /// <summary>
        /// Режим переговорных сделок
        /// </summary>
        public static readonly Market Stock_Ndm = new Market
        {
            Id = 4,
            MarketId = 4,
            Name = "ndm",
            Title = "Режим переговорных сделок",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = true,
            HasExtraYields = true,
            HasDelay = true,
        };


        /// <summary>
        /// ОТС
        /// </summary>
        public static readonly Market Stock_Otc = new Market
        {
            Id = 29,
            MarketId = 29,
            Name = "otc",
            Title = "ОТС",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = false,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// РЕПО с ЦК
        /// </summary>
        public static readonly Market Stock_Ccp = new Market
        {
            Id = 27,
            MarketId = 27,
            Name = "ccp",
            Title = "РЕПО с ЦК",
            EngineId = 1,
            MarketPlace = "MXSE",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Депозиты с ЦК
        /// </summary>
        public static readonly Market Stock_Deposit = new Market
        {
            Id = 35,
            MarketId = 35,
            Name = "deposit",
            Title = "Депозиты с ЦК",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = false,
            HasTrades = false,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// Рынок сделок РЕПО
        /// </summary>
        public static readonly Market Stock_Repo = new Market
        {
            Id = 3,
            MarketId = 3,
            Name = "repo",
            Title = "Рынок сделок РЕПО",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Квал. инвесторы
        /// </summary>
        public static readonly Market Stock_Qnv = new Market
        {
            Id = 28,
            MarketId = 28,
            Name = "qnv",
            Title = "Квал. инвесторы",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Мультивалютный рынок смешанных активов
        /// </summary>
        public static readonly Market Stock_Mamc = new Market
        {
            Id = 36,
            MarketId = 36,
            Name = "mamc",
            Title = "Мультивалютный рынок смешанных активов",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Иностранные ц.б.
        /// </summary>
        public static readonly Market Stock_Foreignshares = new Market
        {
            Id = 47,
            MarketId = 47,
            Name = "foreignshares",
            Title = "Иностранные ц.б.",
            EngineId = 1,
            MarketPlace = "MXSE",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Иностранные ц.б. РПС
        /// </summary>
        public static readonly Market Stock_Foreignndm = new Market
        {
            Id = 49,
            MarketId = 49,
            Name = "foreignndm",
            Title = "Иностранные ц.б. РПС",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// MOEX Board
        /// </summary>
        public static readonly Market Stock_Moexboard = new Market
        {
            Id = 33,
            MarketId = 33,
            Name = "moexboard",
            Title = "MOEX Board",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = false,
            HasTrades = false,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ
        /// </summary>
        public static readonly Market Stock_Gcc = new Market
        {
            Id = 46,
            MarketId = 46,
            Name = "gcc",
            Title = "РЕПО с ЦК с КСУ",
            EngineId = 1,
            MarketPlace = "MXSE",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Рынок кредитов
        /// </summary>
        public static readonly Market Stock_Credit = new Market
        {
            Id = 54,
            MarketId = 54,
            Name = "credit",
            Title = "Рынок кредитов",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = false,
            HasCandles = true,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Биржевые сделки с ЦК
        /// </summary>
        public static readonly Market Currency_Selt = new Market
        {
            Id = 10,
            MarketId = 10,
            Name = "selt",
            Title = "Биржевые сделки с ЦК",
            EngineId = 3,
            MarketPlace = "MXCX",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Поставочные фьючерсы
        /// </summary>
        public static readonly Market Currency_Futures = new Market
        {
            Id = 34,
            MarketId = 34,
            Name = "futures",
            Title = "Поставочные фьючерсы",
            EngineId = 3,
            MarketPlace = "MXCX",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Валютный фиксинг
        /// </summary>
        public static readonly Market Currency_Index = new Market
        {
            Id = 41,
            MarketId = 41,
            Name = "index",
            Title = "Валютный фиксинг",
            EngineId = 3,
            MarketPlace = "FIXING",
            IsOtc = false,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Внебиржевой
        /// </summary>
        public static readonly Market Currency_Otc = new Market
        {
            Id = 45,
            MarketId = 45,
            Name = "otc",
            Title = "Внебиржевой",
            EngineId = 3,
            MarketPlace = "MXCX",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Срочные инструменты
        /// </summary>
        public static readonly Market Futures_Main = new Market
        {
            Id = 12,
            MarketId = 12,
            Name = "main",
            Title = "Срочные инструменты",
            EngineId = 4,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// ФОРТС
        /// </summary>
        public static readonly Market Futures_Forts = new Market
        {
            Id = 22,
            MarketId = 22,
            Name = "forts",
            Title = "ФОРТС",
            EngineId = 4,
            MarketPlace = "FORTS",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Опционы ФОРТС
        /// </summary>
        public static readonly Market Futures_Options = new Market
        {
            Id = 24,
            MarketId = 24,
            Name = "options",
            Title = "Опционы ФОРТС",
            EngineId = 4,
            MarketPlace = "OPTIONS",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Фьючерсы IQS
        /// </summary>
        public static readonly Market Futures_Fortsiqs = new Market
        {
            Id = 37,
            MarketId = 37,
            Name = "fortsiqs",
            Title = "Фьючерсы IQS",
            EngineId = 4,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = false,
            HasHistory = false,
            HasCandles = false,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Опционы IQS
        /// </summary>
        public static readonly Market Futures_Optionsiqs = new Market
        {
            Id = 38,
            MarketId = 38,
            Name = "optionsiqs",
            Title = "Опционы IQS",
            EngineId = 4,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = false,
            HasHistory = false,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Индексы ГКО/ОФЗ
        /// </summary>
        public static readonly Market State_Index = new Market
        {
            Id = 9,
            MarketId = 9,
            Name = "index",
            Title = "Индексы ГКО/ОФЗ",
            EngineId = 2,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// Облигации ГЦБ
        /// </summary>
        public static readonly Market State_Bonds = new Market
        {
            Id = 6,
            MarketId = 6,
            Name = "bonds",
            Title = "Облигации ГЦБ",
            EngineId = 2,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Междилерское РЕПО
        /// </summary>
        public static readonly Market State_Repo = new Market
        {
            Id = 7,
            MarketId = 7,
            Name = "repo",
            Title = "Междилерское РЕПО",
            EngineId = 2,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Внесистемные сделки
        /// </summary>
        public static readonly Market State_Ndm = new Market
        {
            Id = 8,
            MarketId = 8,
            Name = "ndm",
            Title = "Внесистемные сделки",
            EngineId = 2,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Облигации
        /// </summary>
        public static readonly Market Offboard_Bonds = new Market
        {
            Id = 39,
            MarketId = 39,
            Name = "bonds",
            Title = "Облигации",
            EngineId = 7,
            MarketPlace = "",
            IsOtc = true,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = false,
            HasTrades = false,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Акции
        /// </summary>
        public static readonly Market Otc_Shares = new Market
        {
            Id = 1257,
            MarketId = 1257,
            Name = "shares",
            Title = "Акции",
            EngineId = 1012,
            MarketPlace = "",
            IsOtc = true,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Облигации
        /// </summary>
        public static readonly Market Otc_Bonds = new Market
        {
            Id = 1013,
            MarketId = 1013,
            Name = "bonds",
            Title = "Облигации",
            EngineId = 1012,
            MarketPlace = "",
            IsOtc = true,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Акции с ЦК
        /// </summary>
        public static readonly Market Otc_Sharesndm = new Market
        {
            Id = 1262,
            MarketId = 1262,
            Name = "sharesndm",
            Title = "Акции с ЦК",
            EngineId = 1012,
            MarketPlace = "",
            IsOtc = true,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Облигации c ЦК
        /// </summary>
        public static readonly Market Otc_Ndm = new Market
        {
            Id = 1014,
            MarketId = 1014,
            Name = "ndm",
            Title = "Облигации c ЦК",
            EngineId = 1012,
            MarketPlace = "",
            IsOtc = true,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Квоты облигации
        /// </summary>
        public static readonly Market Quotes_Bonds = new Market
        {
            Id = 1279,
            MarketId = 1279,
            Name = "bonds",
            Title = "Квоты облигации",
            EngineId = 1282,
            MarketPlace = "",
            IsOtc = true,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = false,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// Режим переговорных сделок (нерезиденты)
        /// </summary>
        public static readonly Market Stock_Nonresndm = new Market
        {
            Id = 1015,
            MarketId = 1015,
            Name = "nonresndm",
            Title = "Режим переговорных сделок (нерезиденты)",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = true,
            HasExtraYields = true,
            HasDelay = true,
        };


        /// <summary>
        /// Рынок РЕПО (нерезиденты)
        /// </summary>
        public static readonly Market Stock_Nonresrepo = new Market
        {
            Id = 1017,
            MarketId = 1017,
            Name = "nonresrepo",
            Title = "Рынок РЕПО (нерезиденты)",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Рынок РЕПО с ЦК (нерезиденты)
        /// </summary>
        public static readonly Market Stock_Nonresccp = new Market
        {
            Id = 1019,
            MarketId = 1019,
            Name = "nonresccp",
            Title = "Рынок РЕПО с ЦК (нерезиденты)",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = true,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Секция стандартных контрактов АО НТБ
        /// </summary>
        public static readonly Market Commodity_Futures = new Market
        {
            Id = 18,
            MarketId = 18,
            Name = "futures",
            Title = "Секция стандартных контрактов АО НТБ",
            EngineId = 5,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Интервенции по зерну
        /// </summary>
        public static readonly Market Interventions_Grain = new Market
        {
            Id = 20,
            MarketId = 20,
            Name = "grain",
            Title = "Интервенции по зерну",
            EngineId = 6,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = false,
            HasHistory = false,
            HasCandles = false,
            HasOrderBook = false,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// Торги сахаром
        /// </summary>
        public static readonly Market Agro_Sugar = new Market
        {
            Id = 51,
            MarketId = 51,
            Name = "sugar",
            Title = "Торги сахаром",
            EngineId = 9,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// Аукционы НТБ
        /// </summary>
        public static readonly Market Agro_Auctions = new Market
        {
            Id = 1031,
            MarketId = 1031,
            Name = "auctions",
            Title = "Аукционы НТБ",
            EngineId = 9,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = false,
            HasCandles = false,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// Закупочные аукционы НТБ
        /// </summary>
        public static readonly Market Agro_Buyauctions = new Market
        {
            Id = 1084,
            MarketId = 1084,
            Name = "buyauctions",
            Title = "Закупочные аукционы НТБ",
            EngineId = 9,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = false,
            HasHistoryTradesFiles = false,
            HasTrades = true,
            HasHistory = false,
            HasCandles = false,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = false,
        };


        /// <summary>
        /// Standard
        /// </summary>
        public static readonly Market Stock_Standard = new Market
        {
            Id = 23,
            MarketId = 23,
            Name = "standard",
            Title = "Standard",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


        /// <summary>
        /// Classica
        /// </summary>
        public static readonly Market Stock_Classica = new Market
        {
            Id = 25,
            MarketId = 25,
            Name = "classica",
            Title = "Classica",
            EngineId = 1,
            MarketPlace = "",
            IsOtc = false,
            HasHistoryFiles = true,
            HasHistoryTradesFiles = true,
            HasTrades = true,
            HasHistory = true,
            HasCandles = true,
            HasOrderBook = true,
            HasTradingSession = false,
            HasExtraYields = false,
            HasDelay = true,
        };


     
        public static Market[] All = new Market[] { Stock_Index, Stock_Shares, Stock_Bonds, Stock_Ndm, Stock_Otc, Stock_Ccp, Stock_Deposit, Stock_Repo, Stock_Qnv, Stock_Mamc, Stock_Foreignshares, Stock_Foreignndm, Stock_Moexboard, Stock_Gcc, Stock_Credit, Currency_Selt, Currency_Futures, Currency_Index, Currency_Otc, Futures_Main, Futures_Forts, Futures_Options, Futures_Fortsiqs, Futures_Optionsiqs, State_Index, State_Bonds, State_Repo, State_Ndm, Offboard_Bonds, Otc_Shares, Otc_Bonds, Otc_Sharesndm, Otc_Ndm, Quotes_Bonds, Stock_Nonresndm, Stock_Nonresrepo, Stock_Nonresccp, Commodity_Futures, Interventions_Grain, Agro_Sugar, Agro_Auctions, Agro_Buyauctions, Stock_Standard, Stock_Classica,  };


    }
}