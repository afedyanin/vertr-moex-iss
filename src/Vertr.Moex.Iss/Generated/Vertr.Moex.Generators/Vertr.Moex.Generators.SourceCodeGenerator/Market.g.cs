namespace Vertr.Moex.Iss.Entities
{
    public partial class Market
    {
    
        /// <summary>
        /// Индексы фондового рынка
        /// </summary>
        public static readonly Market Index = new Market
        {
            Id = 5,
            MarketId = 5,
            Name = "index",
            Title = "Индексы фондового рынка",
            EngineId = 1,
            MarketPlace = "INDICES"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = False,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// Рынок акций
        /// </summary>
        public static readonly Market Shares = new Market
        {
            Id = 1,
            MarketId = 1,
            Name = "shares",
            Title = "Рынок акций",
            EngineId = 1,
            MarketPlace = "MXSE"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Рынок облигаций
        /// </summary>
        public static readonly Market Bonds = new Market
        {
            Id = 2,
            MarketId = 2,
            Name = "bonds",
            Title = "Рынок облигаций",
            EngineId = 1,
            MarketPlace = "MXSE"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = True,
            HasExtraYields = True,
            HasDelay = True,
        };


        /// <summary>
        /// Режим переговорных сделок
        /// </summary>
        public static readonly Market Ndm = new Market
        {
            Id = 4,
            MarketId = 4,
            Name = "ndm",
            Title = "Режим переговорных сделок",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = True,
            HasExtraYields = True,
            HasDelay = True,
        };


        /// <summary>
        /// ОТС
        /// </summary>
        public static readonly Market Otc = new Market
        {
            Id = 29,
            MarketId = 29,
            Name = "otc",
            Title = "ОТС",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = False,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// РЕПО с ЦК
        /// </summary>
        public static readonly Market Ccp = new Market
        {
            Id = 27,
            MarketId = 27,
            Name = "ccp",
            Title = "РЕПО с ЦК",
            EngineId = 1,
            MarketPlace = "MXSE"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Депозиты с ЦК
        /// </summary>
        public static readonly Market Deposit = new Market
        {
            Id = 35,
            MarketId = 35,
            Name = "deposit",
            Title = "Депозиты с ЦК",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = False,
            HasTrades = False,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// Рынок сделок РЕПО
        /// </summary>
        public static readonly Market Repo = new Market
        {
            Id = 3,
            MarketId = 3,
            Name = "repo",
            Title = "Рынок сделок РЕПО",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Квал. инвесторы
        /// </summary>
        public static readonly Market Qnv = new Market
        {
            Id = 28,
            MarketId = 28,
            Name = "qnv",
            Title = "Квал. инвесторы",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Мультивалютный рынок смешанных активов
        /// </summary>
        public static readonly Market Mamc = new Market
        {
            Id = 36,
            MarketId = 36,
            Name = "mamc",
            Title = "Мультивалютный рынок смешанных активов",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Иностранные ц.б.
        /// </summary>
        public static readonly Market Foreignshares = new Market
        {
            Id = 47,
            MarketId = 47,
            Name = "foreignshares",
            Title = "Иностранные ц.б.",
            EngineId = 1,
            MarketPlace = "MXSE"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Иностранные ц.б. РПС
        /// </summary>
        public static readonly Market Foreignndm = new Market
        {
            Id = 49,
            MarketId = 49,
            Name = "foreignndm",
            Title = "Иностранные ц.б. РПС",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// MOEX Board
        /// </summary>
        public static readonly Market Moexboard = new Market
        {
            Id = 33,
            MarketId = 33,
            Name = "moexboard",
            Title = "MOEX Board",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = False,
            HasTrades = False,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ
        /// </summary>
        public static readonly Market Gcc = new Market
        {
            Id = 46,
            MarketId = 46,
            Name = "gcc",
            Title = "РЕПО с ЦК с КСУ",
            EngineId = 1,
            MarketPlace = "MXSE"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Рынок кредитов
        /// </summary>
        public static readonly Market Credit = new Market
        {
            Id = 54,
            MarketId = 54,
            Name = "credit",
            Title = "Рынок кредитов",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = False,
            HasCandles = True,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Биржевые сделки с ЦК
        /// </summary>
        public static readonly Market Selt = new Market
        {
            Id = 10,
            MarketId = 10,
            Name = "selt",
            Title = "Биржевые сделки с ЦК",
            EngineId = 3,
            MarketPlace = "MXCX"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Поставочные фьючерсы
        /// </summary>
        public static readonly Market Futures = new Market
        {
            Id = 34,
            MarketId = 34,
            Name = "futures",
            Title = "Поставочные фьючерсы",
            EngineId = 3,
            MarketPlace = "MXCX"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Валютный фиксинг
        /// </summary>
        public static readonly Market Index = new Market
        {
            Id = 41,
            MarketId = 41,
            Name = "index",
            Title = "Валютный фиксинг",
            EngineId = 3,
            MarketPlace = "FIXING"
            IsOtc = False,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Внебиржевой
        /// </summary>
        public static readonly Market Otc = new Market
        {
            Id = 45,
            MarketId = 45,
            Name = "otc",
            Title = "Внебиржевой",
            EngineId = 3,
            MarketPlace = "MXCX"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Срочные инструменты
        /// </summary>
        public static readonly Market Main = new Market
        {
            Id = 12,
            MarketId = 12,
            Name = "main",
            Title = "Срочные инструменты",
            EngineId = 4,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// ФОРТС
        /// </summary>
        public static readonly Market Forts = new Market
        {
            Id = 22,
            MarketId = 22,
            Name = "forts",
            Title = "ФОРТС",
            EngineId = 4,
            MarketPlace = "FORTS"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Опционы ФОРТС
        /// </summary>
        public static readonly Market Options = new Market
        {
            Id = 24,
            MarketId = 24,
            Name = "options",
            Title = "Опционы ФОРТС",
            EngineId = 4,
            MarketPlace = "OPTIONS"
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Фьючерсы IQS
        /// </summary>
        public static readonly Market Fortsiqs = new Market
        {
            Id = 37,
            MarketId = 37,
            Name = "fortsiqs",
            Title = "Фьючерсы IQS",
            EngineId = 4,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = False,
            HasHistory = False,
            HasCandles = False,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Опционы IQS
        /// </summary>
        public static readonly Market Optionsiqs = new Market
        {
            Id = 38,
            MarketId = 38,
            Name = "optionsiqs",
            Title = "Опционы IQS",
            EngineId = 4,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = False,
            HasHistory = False,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Индексы ГКО/ОФЗ
        /// </summary>
        public static readonly Market Index = new Market
        {
            Id = 9,
            MarketId = 9,
            Name = "index",
            Title = "Индексы ГКО/ОФЗ",
            EngineId = 2,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// Облигации ГЦБ
        /// </summary>
        public static readonly Market Bonds = new Market
        {
            Id = 6,
            MarketId = 6,
            Name = "bonds",
            Title = "Облигации ГЦБ",
            EngineId = 2,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Междилерское РЕПО
        /// </summary>
        public static readonly Market Repo = new Market
        {
            Id = 7,
            MarketId = 7,
            Name = "repo",
            Title = "Междилерское РЕПО",
            EngineId = 2,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Внесистемные сделки
        /// </summary>
        public static readonly Market Ndm = new Market
        {
            Id = 8,
            MarketId = 8,
            Name = "ndm",
            Title = "Внесистемные сделки",
            EngineId = 2,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Облигации
        /// </summary>
        public static readonly Market Bonds = new Market
        {
            Id = 39,
            MarketId = 39,
            Name = "bonds",
            Title = "Облигации",
            EngineId = 7,
            MarketPlace = ""
            IsOtc = True,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = False,
            HasTrades = False,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Акции
        /// </summary>
        public static readonly Market Shares = new Market
        {
            Id = 1257,
            MarketId = 1257,
            Name = "shares",
            Title = "Акции",
            EngineId = 1012,
            MarketPlace = ""
            IsOtc = True,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Облигации
        /// </summary>
        public static readonly Market Bonds = new Market
        {
            Id = 1013,
            MarketId = 1013,
            Name = "bonds",
            Title = "Облигации",
            EngineId = 1012,
            MarketPlace = ""
            IsOtc = True,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Акции с ЦК
        /// </summary>
        public static readonly Market Sharesndm = new Market
        {
            Id = 1262,
            MarketId = 1262,
            Name = "sharesndm",
            Title = "Акции с ЦК",
            EngineId = 1012,
            MarketPlace = ""
            IsOtc = True,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Облигации c ЦК
        /// </summary>
        public static readonly Market Ndm = new Market
        {
            Id = 1014,
            MarketId = 1014,
            Name = "ndm",
            Title = "Облигации c ЦК",
            EngineId = 1012,
            MarketPlace = ""
            IsOtc = True,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Квоты облигации
        /// </summary>
        public static readonly Market Bonds = new Market
        {
            Id = 1279,
            MarketId = 1279,
            Name = "bonds",
            Title = "Квоты облигации",
            EngineId = 1282,
            MarketPlace = ""
            IsOtc = True,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = False,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// Режим переговорных сделок (нерезиденты)
        /// </summary>
        public static readonly Market Nonresndm = new Market
        {
            Id = 1015,
            MarketId = 1015,
            Name = "nonresndm",
            Title = "Режим переговорных сделок (нерезиденты)",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = True,
            HasExtraYields = True,
            HasDelay = True,
        };


        /// <summary>
        /// Рынок РЕПО (нерезиденты)
        /// </summary>
        public static readonly Market Nonresrepo = new Market
        {
            Id = 1017,
            MarketId = 1017,
            Name = "nonresrepo",
            Title = "Рынок РЕПО (нерезиденты)",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Рынок РЕПО с ЦК (нерезиденты)
        /// </summary>
        public static readonly Market Nonresccp = new Market
        {
            Id = 1019,
            MarketId = 1019,
            Name = "nonresccp",
            Title = "Рынок РЕПО с ЦК (нерезиденты)",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = True,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Секция стандартных контрактов АО НТБ
        /// </summary>
        public static readonly Market Futures = new Market
        {
            Id = 18,
            MarketId = 18,
            Name = "futures",
            Title = "Секция стандартных контрактов АО НТБ",
            EngineId = 5,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Интервенции по зерну
        /// </summary>
        public static readonly Market Grain = new Market
        {
            Id = 20,
            MarketId = 20,
            Name = "grain",
            Title = "Интервенции по зерну",
            EngineId = 6,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = False,
            HasHistory = False,
            HasCandles = False,
            HasOrderBook = False,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// Торги сахаром
        /// </summary>
        public static readonly Market Sugar = new Market
        {
            Id = 51,
            MarketId = 51,
            Name = "sugar",
            Title = "Торги сахаром",
            EngineId = 9,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// Аукционы НТБ
        /// </summary>
        public static readonly Market Auctions = new Market
        {
            Id = 1031,
            MarketId = 1031,
            Name = "auctions",
            Title = "Аукционы НТБ",
            EngineId = 9,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = False,
            HasCandles = False,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// Закупочные аукционы НТБ
        /// </summary>
        public static readonly Market Buyauctions = new Market
        {
            Id = 1084,
            MarketId = 1084,
            Name = "buyauctions",
            Title = "Закупочные аукционы НТБ",
            EngineId = 9,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = False,
            HasHistoryTradesFiles = False,
            HasTrades = True,
            HasHistory = False,
            HasCandles = False,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = False,
        };


        /// <summary>
        /// Standard
        /// </summary>
        public static readonly Market Standard = new Market
        {
            Id = 23,
            MarketId = 23,
            Name = "standard",
            Title = "Standard",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


        /// <summary>
        /// Classica
        /// </summary>
        public static readonly Market Classica = new Market
        {
            Id = 25,
            MarketId = 25,
            Name = "classica",
            Title = "Classica",
            EngineId = 1,
            MarketPlace = ""
            IsOtc = False,
            HasHistoryFiles = True,
            HasHistoryTradesFiles = True,
            HasTrades = True,
            HasHistory = True,
            HasCandles = True,
            HasOrderBook = True,
            HasTradingSession = False,
            HasExtraYields = False,
            HasDelay = True,
        };


     
        public static Market[] All = new Market[] { Index, Shares, Bonds, Ndm, Otc, Ccp, Deposit, Repo, Qnv, Mamc, Foreignshares, Foreignndm, Moexboard, Gcc, Credit, Selt, Futures, Index, Otc, Main, Forts, Options, Fortsiqs, Optionsiqs, Index, Bonds, Repo, Ndm, Bonds, Shares, Bonds, Sharesndm, Ndm, Bonds, Nonresndm, Nonresrepo, Nonresccp, Futures, Grain, Sugar, Auctions, Buyauctions, Standard, Classica,  };


    }
}