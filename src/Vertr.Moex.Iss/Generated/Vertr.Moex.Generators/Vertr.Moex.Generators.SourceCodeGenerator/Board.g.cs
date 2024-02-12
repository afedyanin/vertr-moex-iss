namespace Vertr.Moex.Iss.Entities
{
    public partial class Board
    {
    
        /// <summary>
        /// Т+: Паи - безадрес.
        /// </summary>
        public static readonly Board TQIF = new Board
        {
            Id = 177,
            BoardId = "TQIF",
            Title = "Т+: Паи - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: ETF - безадрес.
        /// </summary>
        public static readonly Board TQTF = new Board
        {
            Id = 178,
            BoardId = "TQTF",
            Title = "Т+: ETF - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Акции и ДР - безадрес.
        /// </summary>
        public static readonly Board TQBR = new Board
        {
            Id = 129,
            BoardId = "TQBR",
            Title = "Т+: Акции и ДР - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: А2-Акции и паи - безадрес.
        /// </summary>
        public static readonly Board TQBS = new Board
        {
            Id = 130,
            BoardId = "TQBS",
            Title = "Т+: А2-Акции и паи - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Б-Акции и паи - безадрес.
        /// </summary>
        public static readonly Board TQNL = new Board
        {
            Id = 131,
            BoardId = "TQNL",
            Title = "Т+: Б-Акции и паи - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: В-Акции и ДР - безадрес.
        /// </summary>
        public static readonly Board TQLV = new Board
        {
            Id = 132,
            BoardId = "TQLV",
            Title = "Т+: В-Акции и ДР - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: И-Акции - безадрес.
        /// </summary>
        public static readonly Board TQLI = new Board
        {
            Id = 133,
            BoardId = "TQLI",
            Title = "Т+: И-Акции - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Акции, паи и ДР внесписочные - безадрес.
        /// </summary>
        public static readonly Board TQNE = new Board
        {
            Id = 134,
            BoardId = "TQNE",
            Title = "Т+: Акции, паи и ДР внесписочные - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Акции Д - безадрес.
        /// </summary>
        public static readonly Board TQDE = new Board
        {
            Id = 158,
            BoardId = "TQDE",
            Title = "Т+: Акции Д - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Акции ПИР - безадрес.
        /// </summary>
        public static readonly Board TQPI = new Board
        {
            Id = 401,
            BoardId = "TQPI",
            Title = "Т+: Акции ПИР - безадрес.",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: ETF (USD) - безадрес.
        /// </summary>
        public static readonly Board TQTD = new Board
        {
            Id = 225,
            BoardId = "TQTD",
            Title = "Т+: ETF (USD) - безадрес.",
            BoardGroupId = 156,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: ПАИ (USD) - безадрес.
        /// </summary>
        public static readonly Board TQFD = new Board
        {
            Id = 429,
            BoardId = "TQFD",
            Title = "Т+: ПАИ (USD) - безадрес.",
            BoardGroupId = 156,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Акции ПИР (USD) - безадрес.
        /// </summary>
        public static readonly Board TQPD = new Board
        {
            Id = 431,
            BoardId = "TQPD",
            Title = "Т+: Акции ПИР (USD) - безадрес.",
            BoardGroupId = 156,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: А1-Акции и паи - безадрес.
        /// </summary>
        public static readonly Board EQBR = new Board
        {
            Id = 1,
            BoardId = "EQBR",
            Title = "Основной режим: А1-Акции и паи - безадрес.",
            BoardGroupId = 6,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: А2-Акции и паи - безадрес.
        /// </summary>
        public static readonly Board EQBS = new Board
        {
            Id = 2,
            BoardId = "EQBS",
            Title = "Основной режим: А2-Акции и паи - безадрес.",
            BoardGroupId = 6,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: Б-Акции и паи - безадрес.
        /// </summary>
        public static readonly Board EQNL = new Board
        {
            Id = 4,
            BoardId = "EQNL",
            Title = "Основной режим: Б-Акции и паи - безадрес.",
            BoardGroupId = 6,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: В-Акции и РДР - безадрес.
        /// </summary>
        public static readonly Board EQLV = new Board
        {
            Id = 3,
            BoardId = "EQLV",
            Title = "Основной режим: В-Акции и РДР - безадрес.",
            BoardGroupId = 6,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: Акции Д - безадрес.
        /// </summary>
        public static readonly Board EQDE = new Board
        {
            Id = 117,
            BoardId = "EQDE",
            Title = "Основной режим: Акции Д - безадрес.",
            BoardGroupId = 6,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: И-Акции - безадрес.
        /// </summary>
        public static readonly Board EQLI = new Board
        {
            Id = 28,
            BoardId = "EQLI",
            Title = "Основной режим: И-Акции - безадрес.",
            BoardGroupId = 6,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: Акции и паи внесписочные - безадрес.
        /// </summary>
        public static readonly Board EQNE = new Board
        {
            Id = 5,
            BoardId = "EQNE",
            Title = "Основной режим: Акции и паи внесписочные - безадрес.",
            BoardGroupId = 6,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Поставка по СК (акции)
        /// </summary>
        public static readonly Board SPEQ = new Board
        {
            Id = 281,
            BoardId = "SPEQ",
            Title = "Поставка по СК (акции)",
            BoardGroupId = 125,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Неполные лоты (акции) - безадрес.
        /// </summary>
        public static readonly Board SMAL = new Board
        {
            Id = 36,
            BoardId = "SMAL",
            Title = "Т+: Неполные лоты (акции) - безадрес.",
            BoardGroupId = 21,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Крупные пакеты - Акции - безадрес.
        /// </summary>
        public static readonly Board TQDP = new Board
        {
            Id = 305,
            BoardId = "TQDP",
            Title = "Крупные пакеты - Акции - безадрес.",
            BoardGroupId = 42,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Крупные пакеты - Акции - безадрес.
        /// </summary>
        public static readonly Board EQDP = new Board
        {
            Id = 100,
            BoardId = "EQDP",
            Title = "Крупные пакеты - Акции - безадрес.",
            BoardGroupId = 42,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т0: ETF (USD) - безадрес.
        /// </summary>
        public static readonly Board EQTD = new Board
        {
            Id = 260,
            BoardId = "EQTD",
            Title = "Т0: ETF (USD) - безадрес.",
            BoardGroupId = 99,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Акции и ДР (EUR) - безадрес.
        /// </summary>
        public static readonly Board TQBE = new Board
        {
            Id = 313,
            BoardId = "TQBE",
            Title = "Т+: Акции и ДР (EUR) - безадрес.",
            BoardGroupId = 157,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: ETF (EUR) - безадрес.
        /// </summary>
        public static readonly Board TQTE = new Board
        {
            Id = 314,
            BoardId = "TQTE",
            Title = "Т+: ETF (EUR) - безадрес.",
            BoardGroupId = 157,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: ПАИ (EUR) - безадрес.
        /// </summary>
        public static readonly Board TQFE = new Board
        {
            Id = 441,
            BoardId = "TQFE",
            Title = "Т+: ПАИ (EUR) - безадрес.",
            BoardGroupId = 157,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Акции ПИР (EUR) - безадрес.
        /// </summary>
        public static readonly Board TQPE = new Board
        {
            Id = 443,
            BoardId = "TQPE",
            Title = "Т+: Акции ПИР (EUR) - безадрес.",
            BoardGroupId = 157,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: ПАИ (CNY) - безадрес.
        /// </summary>
        public static readonly Board TQTY = new Board
        {
            Id = 1216,
            BoardId = "TQTY",
            Title = "Т+: ПАИ (CNY) - безадрес.",
            BoardGroupId = 1215,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Акции ПИР (CNY) - безадрес.
        /// </summary>
        public static readonly Board TQPY = new Board
        {
            Id = 1217,
            BoardId = "TQPY",
            Title = "Т+: Акции ПИР (CNY) - безадрес.",
            BoardGroupId = 1215,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т0: ETF (EUR) - безадрес.
        /// </summary>
        public static readonly Board EQTU = new Board
        {
            Id = 315,
            BoardId = "EQTU",
            Title = "Т0: ETF (EUR) - безадрес.",
            BoardGroupId = 159,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: ПАИ (HKD) - безадрес.
        /// </summary>
        public static readonly Board TQTH = new Board
        {
            Id = 1239,
            BoardId = "TQTH",
            Title = "Т+: ПАИ (HKD) - безадрес.",
            BoardGroupId = 1238,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Акции ПИР (HKD) - безадрес.
        /// </summary>
        public static readonly Board TQPH = new Board
        {
            Id = 1240,
            BoardId = "TQPH",
            Title = "Т+: Акции ПИР (HKD) - безадрес.",
            BoardGroupId = 1238,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// ЦК - режим основных торгов - безадрес.
        /// </summary>
        public static readonly Board EQCC = new Board
        {
            Id = 95,
            BoardId = "EQCC",
            Title = "ЦК - режим основных торгов - безадрес.",
            BoardGroupId = 30,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Гособлигации - безадрес.
        /// </summary>
        public static readonly Board TQOB = new Board
        {
            Id = 135,
            BoardId = "TQOB",
            Title = "Т+: Гособлигации - безадрес.",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: А2-Облигации - безадрес.
        /// </summary>
        public static readonly Board TQOS = new Board
        {
            Id = 136,
            BoardId = "TQOS",
            Title = "Т+: А2-Облигации - безадрес.",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Б-Облигации - безадрес.
        /// </summary>
        public static readonly Board TQNO = new Board
        {
            Id = 137,
            BoardId = "TQNO",
            Title = "Т+: Б-Облигации - безадрес.",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: В-Облигации - безадрес.
        /// </summary>
        public static readonly Board TQOV = new Board
        {
            Id = 138,
            BoardId = "TQOV",
            Title = "Т+: В-Облигации - безадрес.",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации внесписочные - безадрес.
        /// </summary>
        public static readonly Board TQNB = new Board
        {
            Id = 139,
            BoardId = "TQNB",
            Title = "Т+: Облигации внесписочные - безадрес.",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации внеспис. в ин.валюте - безадрес.
        /// </summary>
        public static readonly Board TQUS = new Board
        {
            Id = 140,
            BoardId = "TQUS",
            Title = "Т+: Облигации внеспис. в ин.валюте - безадрес.",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации - безадрес.
        /// </summary>
        public static readonly Board TQCB = new Board
        {
            Id = 349,
            BoardId = "TQCB",
            Title = "Т+: Облигации - безадрес.",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации Д - безадрес.
        /// </summary>
        public static readonly Board TQRD = new Board
        {
            Id = 361,
            BoardId = "TQRD",
            Title = "Т+: Облигации Д - безадрес.",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+ Облигации ПИР - безадрес.
        /// </summary>
        public static readonly Board TQIR = new Board
        {
            Id = 377,
            BoardId = "TQIR",
            Title = "Т+ Облигации ПИР - безадрес.",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации (USD) - безадрес.
        /// </summary>
        public static readonly Board TQOD = new Board
        {
            Id = 226,
            BoardId = "TQOD",
            Title = "Т+: Облигации (USD) - безадрес.",
            BoardGroupId = 193,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации Д (USD) - безадрес.
        /// </summary>
        public static readonly Board TQUD = new Board
        {
            Id = 363,
            BoardId = "TQUD",
            Title = "Т+: Облигации Д (USD) - безадрес.",
            BoardGroupId = 193,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации ПИР (USD) - безадрес.
        /// </summary>
        public static readonly Board TQIU = new Board
        {
            Id = 383,
            BoardId = "TQIU",
            Title = "Т+: Облигации ПИР (USD) - безадрес.",
            BoardGroupId = 193,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// T+: ETC - безадрес.
        /// </summary>
        public static readonly Board TQTC = new Board
        {
            Id = 179,
            BoardId = "TQTC",
            Title = "T+: ETC - безадрес.",
            BoardGroupId = 68,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т0 Облигации - безадрес.
        /// </summary>
        public static readonly Board EQOB = new Board
        {
            Id = 8,
            BoardId = "EQOB",
            Title = "Т0 Облигации - безадрес.",
            BoardGroupId = 7,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: А2-Облигации - безадрес.
        /// </summary>
        public static readonly Board EQOS = new Board
        {
            Id = 9,
            BoardId = "EQOS",
            Title = "Основной режим: А2-Облигации - безадрес.",
            BoardGroupId = 7,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: Б-Облигации - безадрес.
        /// </summary>
        public static readonly Board EQNO = new Board
        {
            Id = 7,
            BoardId = "EQNO",
            Title = "Основной режим: Б-Облигации - безадрес.",
            BoardGroupId = 7,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: В-Облигации - безадрес.
        /// </summary>
        public static readonly Board EQOV = new Board
        {
            Id = 29,
            BoardId = "EQOV",
            Title = "Основной режим: В-Облигации - безадрес.",
            BoardGroupId = 7,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: Облигации Д - безадрес.
        /// </summary>
        public static readonly Board EQDB = new Board
        {
            Id = 93,
            BoardId = "EQDB",
            Title = "Основной режим: Облигации Д - безадрес.",
            BoardGroupId = 7,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: Облигации внесписочные - безадрес.
        /// </summary>
        public static readonly Board EQNB = new Board
        {
            Id = 6,
            BoardId = "EQNB",
            Title = "Основной режим: Облигации внесписочные - безадрес.",
            BoardGroupId = 7,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: Облигации внеспис. в ин.валюте - безадрес.
        /// </summary>
        public static readonly Board EQUS = new Board
        {
            Id = 88,
            BoardId = "EQUS",
            Title = "Основной режим: Облигации внеспис. в ин.валюте - безадрес.",
            BoardGroupId = 7,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: Облигации (EUR) - безадрес.
        /// </summary>
        public static readonly Board EQEO = new Board
        {
            Id = 165,
            BoardId = "EQEO",
            Title = "Основной режим: Облигации (EUR) - безадрес.",
            BoardGroupId = 7,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Поставка по ОФЗ
        /// </summary>
        public static readonly Board SPOB = new Board
        {
            Id = 119,
            BoardId = "SPOB",
            Title = "Поставка по ОФЗ",
            BoardGroupId = 105,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// T0 ETC - безадрес.
        /// </summary>
        public static readonly Board EQTC = new Board
        {
            Id = 176,
            BoardId = "EQTC",
            Title = "T0 ETC - безадрес.",
            BoardGroupId = 69,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Облигации (USD) - безадрес.
        /// </summary>
        public static readonly Board EQEU = new Board
        {
            Id = 37,
            BoardId = "EQEU",
            Title = "Облигации (USD) - безадрес.",
            BoardGroupId = 67,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Облигации (GBP) - безадрес.
        /// </summary>
        public static readonly Board EQGO = new Board
        {
            Id = 228,
            BoardId = "EQGO",
            Title = "Облигации (GBP) - безадрес.",
            BoardGroupId = 67,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Облигации (CNY) - безадрес.
        /// </summary>
        public static readonly Board EQYO = new Board
        {
            Id = 229,
            BoardId = "EQYO",
            Title = "Облигации (CNY) - безадрес.",
            BoardGroupId = 67,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Выкуп: Аукцион - безадрес.
        /// </summary>
        public static readonly Board AUBB = new Board
        {
            Id = 122,
            BoardId = "AUBB",
            Title = "Выкуп: Аукцион - безадрес.",
            BoardGroupId = 122,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Размещение: Аукцион - безадрес.
        /// </summary>
        public static readonly Board AUCT = new Board
        {
            Id = 121,
            BoardId = "AUCT",
            Title = "Размещение: Аукцион - безадрес.",
            BoardGroupId = 123,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Крупные пакеты: Облигации - безадрес.
        /// </summary>
        public static readonly Board TQDB = new Board
        {
            Id = 227,
            BoardId = "TQDB",
            Title = "Крупные пакеты: Облигации - безадрес.",
            BoardGroupId = 77,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации (EUR) - безадрес.
        /// </summary>
        public static readonly Board TQOE = new Board
        {
            Id = 357,
            BoardId = "TQOE",
            Title = "Т+: Облигации (EUR) - безадрес.",
            BoardGroupId = 207,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации Д (EUR) - безадрес
        /// </summary>
        public static readonly Board TQED = new Board
        {
            Id = 365,
            BoardId = "TQED",
            Title = "Т+: Облигации Д (EUR) - безадрес",
            BoardGroupId = 207,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации ПИР (EUR) - безадрес.
        /// </summary>
        public static readonly Board TQIE = new Board
        {
            Id = 389,
            BoardId = "TQIE",
            Title = "Т+: Облигации ПИР (EUR) - безадрес.",
            BoardGroupId = 207,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Крупные пакеты – Облигации (USD) - безадрес.
        /// </summary>
        public static readonly Board TQDU = new Board
        {
            Id = 323,
            BoardId = "TQDU",
            Title = "Крупные пакеты – Облигации (USD) - безадрес.",
            BoardGroupId = 167,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации (CNY) - безадрес.
        /// </summary>
        public static readonly Board TQOY = new Board
        {
            Id = 1101,
            BoardId = "TQOY",
            Title = "Т+: Облигации (CNY) - безадрес.",
            BoardGroupId = 245,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Облигации ПИР (CNY) - безадрес.
        /// </summary>
        public static readonly Board TQIY = new Board
        {
            Id = 395,
            BoardId = "TQIY",
            Title = "Т+: Облигации ПИР (CNY) - безадрес.",
            BoardGroupId = 245,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион: адресные заявки
        /// </summary>
        public static readonly Board PACT = new Board
        {
            Id = 407,
            BoardId = "PACT",
            Title = "Аукцион: адресные заявки",
            BoardGroupId = 257,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО-М - адрес.
        /// </summary>
        public static readonly Board RPMO = new Board
        {
            Id = 24,
            BoardId = "RPMO",
            Title = "РЕПО-М - адрес.",
            BoardGroupId = 201,
            EngineId = 1,
            MarketId = 3,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО: Акции и паи - адрес.
        /// </summary>
        public static readonly Board RPEQ = new Board
        {
            Id = 34,
            BoardId = "RPEQ",
            Title = "РЕПО: Акции и паи - адрес.",
            BoardGroupId = 1,
            EngineId = 1,
            MarketId = 3,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО c акциями - адрес.
        /// </summary>
        public static readonly Board RPMA = new Board
        {
            Id = 23,
            BoardId = "RPMA",
            Title = "РЕПО c акциями - адрес.",
            BoardGroupId = 95,
            EngineId = 1,
            MarketId = 3,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО в ин. валюте (USD) - адрес.
        /// </summary>
        public static readonly Board RPEU = new Board
        {
            Id = 35,
            BoardId = "RPEU",
            Title = "РЕПО в ин. валюте (USD) - адрес.",
            BoardGroupId = 94,
            EngineId = 1,
            MarketId = 3,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО c акциями (USD) - адрес.
        /// </summary>
        public static readonly Board RPUA = new Board
        {
            Id = 162,
            BoardId = "RPUA",
            Title = "РЕПО c акциями (USD) - адрес.",
            BoardGroupId = 94,
            EngineId = 1,
            MarketId = 3,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО c облигациями (USD) - адрес.
        /// </summary>
        public static readonly Board RPUO = new Board
        {
            Id = 163,
            BoardId = "RPUO",
            Title = "РЕПО c облигациями (USD) - адрес.",
            BoardGroupId = 94,
            EngineId = 1,
            MarketId = 3,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО в ин. валюте (EUR) - адрес.
        /// </summary>
        public static readonly Board RPEO = new Board
        {
            Id = 164,
            BoardId = "RPEO",
            Title = "РЕПО в ин. валюте (EUR) - адрес.",
            BoardGroupId = 90,
            EngineId = 1,
            MarketId = 3,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО в ин.валюте (CNY) - адрес.
        /// </summary>
        public static readonly Board RPEY = new Board
        {
            Id = 254,
            BoardId = "RPEY",
            Title = "РЕПО в ин.валюте (CNY) - адрес.",
            BoardGroupId = 2,
            EngineId = 1,
            MarketId = 3,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО c облигациями (GBP) - адрес.
        /// </summary>
        public static readonly Board RPGO = new Board
        {
            Id = 238,
            BoardId = "RPGO",
            Title = "РЕПО c облигациями (GBP) - адрес.",
            BoardGroupId = 2,
            EngineId = 1,
            MarketId = 3,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО с ЦК - адрес.
        /// </summary>
        public static readonly Board RPCC = new Board
        {
            Id = 96,
            BoardId = "RPCC",
            Title = "РЕПО с ЦК - адрес.",
            BoardGroupId = 31,
            EngineId = 1,
            MarketId = 3,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Облигации (USD) - адрес.
        /// </summary>
        public static readonly Board PTEU = new Board
        {
            Id = 154,
            BoardId = "PTEU",
            Title = "РПС с ЦК: Облигации (USD) - адрес.",
            BoardGroupId = 193,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Паи - адрес.
        /// </summary>
        public static readonly Board PTIF = new Board
        {
            Id = 173,
            BoardId = "PTIF",
            Title = "РПС с ЦК: Паи - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: ETC - адрес.
        /// </summary>
        public static readonly Board PTTC = new Board
        {
            Id = 175,
            BoardId = "PTTC",
            Title = "РПС с ЦК: ETC - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: ETF - адрес.
        /// </summary>
        public static readonly Board PTTF = new Board
        {
            Id = 174,
            BoardId = "PTTF",
            Title = "РПС с ЦК: ETF - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Акции и ДР - адрес.
        /// </summary>
        public static readonly Board PTEQ = new Board
        {
            Id = 142,
            BoardId = "PTEQ",
            Title = "РПС с ЦК: Акции и ДР - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: А2-Акции и паи - адрес.
        /// </summary>
        public static readonly Board PTES = new Board
        {
            Id = 143,
            BoardId = "PTES",
            Title = "РПС С ЦК: А2-Акции и паи - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: Б-Акции и паи - адрес.
        /// </summary>
        public static readonly Board PTNL = new Board
        {
            Id = 144,
            BoardId = "PTNL",
            Title = "РПС С ЦК: Б-Акции и паи - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: В-Акции и ДР - адрес.
        /// </summary>
        public static readonly Board PTLV = new Board
        {
            Id = 145,
            BoardId = "PTLV",
            Title = "РПС С ЦК: В-Акции и ДР - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: И-Акции - адрес.
        /// </summary>
        public static readonly Board PTLI = new Board
        {
            Id = 146,
            BoardId = "PTLI",
            Title = "РПС С ЦК: И-Акции - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: Акции, паи и ДР внесписочные - адрес.
        /// </summary>
        public static readonly Board PTNE = new Board
        {
            Id = 147,
            BoardId = "PTNE",
            Title = "РПС С ЦК: Акции, паи и ДР внесписочные - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: Б-Облигации - адрес.
        /// </summary>
        public static readonly Board PTNO = new Board
        {
            Id = 150,
            BoardId = "PTNO",
            Title = "РПС С ЦК: Б-Облигации - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: Облигации в ин.валюте - адрес.
        /// </summary>
        public static readonly Board PTUS = new Board
        {
            Id = 153,
            BoardId = "PTUS",
            Title = "РПС С ЦК: Облигации в ин.валюте - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Акции Д - адрес.
        /// </summary>
        public static readonly Board PTDE = new Board
        {
            Id = 161,
            BoardId = "PTDE",
            Title = "РПС с ЦК: Акции Д - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Акции ПИР - адрес.
        /// </summary>
        public static readonly Board PTPI = new Board
        {
            Id = 405,
            BoardId = "PTPI",
            Title = "РПС с ЦК: Акции ПИР - адрес.",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: ETF (USD) - адрес.
        /// </summary>
        public static readonly Board PSTD = new Board
        {
            Id = 234,
            BoardId = "PSTD",
            Title = "РПС: ETF (USD) - адрес.",
            BoardGroupId = 74,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: ПАИ (USD) - адресн.
        /// </summary>
        public static readonly Board PSFD = new Board
        {
            Id = 437,
            BoardId = "PSFD",
            Title = "РПС: ПАИ (USD) - адресн.",
            BoardGroupId = 74,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Акции ПИР (USD) - адресн.
        /// </summary>
        public static readonly Board PSPD = new Board
        {
            Id = 439,
            BoardId = "PSPD",
            Title = "РПС: Акции ПИР (USD) - адресн.",
            BoardGroupId = 74,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Паи - адрес.
        /// </summary>
        public static readonly Board PSIF = new Board
        {
            Id = 170,
            BoardId = "PSIF",
            Title = "РПС: Паи - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: ETC - адрес.
        /// </summary>
        public static readonly Board PSTC = new Board
        {
            Id = 172,
            BoardId = "PSTC",
            Title = "РПС: ETC - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: ETF - адрес.
        /// </summary>
        public static readonly Board PSTF = new Board
        {
            Id = 171,
            BoardId = "PSTF",
            Title = "РПС: ETF - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Акции - адрес.
        /// </summary>
        public static readonly Board PSEQ = new Board
        {
            Id = 11,
            BoardId = "PSEQ",
            Title = "РПС: Акции - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: А2-Акции и паи - адрес.
        /// </summary>
        public static readonly Board PSES = new Board
        {
            Id = 12,
            BoardId = "PSES",
            Title = "РПС: А2-Акции и паи - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Б-Акции и паи - адрес.
        /// </summary>
        public static readonly Board PSNL = new Board
        {
            Id = 15,
            BoardId = "PSNL",
            Title = "РПС: Б-Акции и паи - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: В-Акции и ДР - адрес.
        /// </summary>
        public static readonly Board PSLV = new Board
        {
            Id = 32,
            BoardId = "PSLV",
            Title = "РПС: В-Акции и ДР - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Акции Д - адрес.
        /// </summary>
        public static readonly Board PSDE = new Board
        {
            Id = 118,
            BoardId = "PSDE",
            Title = "РПС: Акции Д - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: И-Акции - адрес.
        /// </summary>
        public static readonly Board PSLI = new Board
        {
            Id = 31,
            BoardId = "PSLI",
            Title = "РПС: И-Акции - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Акции, паи и ДР внесписочные - адрес.
        /// </summary>
        public static readonly Board PSNE = new Board
        {
            Id = 14,
            BoardId = "PSNE",
            Title = "РПС: Акции, паи и ДР внесписочные - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: А2-Облигации - адрес.
        /// </summary>
        public static readonly Board PSOS = new Board
        {
            Id = 18,
            BoardId = "PSOS",
            Title = "РПС: А2-Облигации - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Б-Облигации - адрес.
        /// </summary>
        public static readonly Board PSNO = new Board
        {
            Id = 16,
            BoardId = "PSNO",
            Title = "РПС: Б-Облигации - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: В-Облигации - адрес.
        /// </summary>
        public static readonly Board PSOV = new Board
        {
            Id = 33,
            BoardId = "PSOV",
            Title = "РПС: В-Облигации - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации внесписочные - адрес.
        /// </summary>
        public static readonly Board PSNB = new Board
        {
            Id = 13,
            BoardId = "PSNB",
            Title = "РПС: Облигации внесписочные - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации в ин.валюте - адрес.
        /// </summary>
        public static readonly Board PSUS = new Board
        {
            Id = 89,
            BoardId = "PSUS",
            Title = "РПС: Облигации в ин.валюте - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Акции ПИР - адрес.
        /// </summary>
        public static readonly Board PSPI = new Board
        {
            Id = 403,
            BoardId = "PSPI",
            Title = "РПС: Акции ПИР - адрес.",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации (GBP) - адрес.
        /// </summary>
        public static readonly Board PSGO = new Board
        {
            Id = 235,
            BoardId = "PSGO",
            Title = "РПС: Облигации (GBP) - адрес.",
            BoardGroupId = 106,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Размещение - адрес.
        /// </summary>
        public static readonly Board PSAU = new Board
        {
            Id = 98,
            BoardId = "PSAU",
            Title = "Размещение - адрес.",
            BoardGroupId = 107,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Размещение (USD) - адрес.
        /// </summary>
        public static readonly Board PAUS = new Board
        {
            Id = 99,
            BoardId = "PAUS",
            Title = "Размещение (USD) - адрес.",
            BoardGroupId = 107,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Размещение (EUR) - адрес.
        /// </summary>
        public static readonly Board PAEU = new Board
        {
            Id = 159,
            BoardId = "PAEU",
            Title = "Размещение (EUR) - адрес.",
            BoardGroupId = 107,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Размещение (CNY) - адрес.
        /// </summary>
        public static readonly Board PACY = new Board
        {
            Id = 237,
            BoardId = "PACY",
            Title = "Размещение (CNY) - адрес.",
            BoardGroupId = 107,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Размещение (GBP) - адрес.
        /// </summary>
        public static readonly Board PAGB = new Board
        {
            Id = 169,
            BoardId = "PAGB",
            Title = "Размещение (GBP) - адрес.",
            BoardGroupId = 107,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Выкуп - адрес.
        /// </summary>
        public static readonly Board PSBB = new Board
        {
            Id = 120,
            BoardId = "PSBB",
            Title = "Выкуп - адрес.",
            BoardGroupId = 108,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Выкуп (EUR) - адрес.
        /// </summary>
        public static readonly Board PSBE = new Board
        {
            Id = 278,
            BoardId = "PSBE",
            Title = "Выкуп (EUR) - адрес.",
            BoardGroupId = 121,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Анонимный РПС - адрес.
        /// </summary>
        public static readonly Board OTCB = new Board
        {
            Id = 282,
            BoardId = "OTCB",
            Title = "Анонимный РПС - адрес.",
            BoardGroupId = 126,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Анонимный РПС (USD) - адрес.
        /// </summary>
        public static readonly Board OTCU = new Board
        {
            Id = 353,
            BoardId = "OTCU",
            Title = "Анонимный РПС (USD) - адрес.",
            BoardGroupId = 203,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Анонимный РПС (EUR) - адрес.
        /// </summary>
        public static readonly Board OTCE = new Board
        {
            Id = 355,
            BoardId = "OTCE",
            Title = "Анонимный РПС (EUR) - адрес.",
            BoardGroupId = 205,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: ETF (USD) - адрес.
        /// </summary>
        public static readonly Board PTTD = new Board
        {
            Id = 231,
            BoardId = "PTTD",
            Title = "РПС с ЦК: ETF (USD) - адрес.",
            BoardGroupId = 73,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Паи (USD) - адресн.
        /// </summary>
        public static readonly Board PTFD = new Board
        {
            Id = 433,
            BoardId = "PTFD",
            Title = "РПС с ЦК: Паи (USD) - адресн.",
            BoardGroupId = 73,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Акции ПИР (USD) - адресн.
        /// </summary>
        public static readonly Board PTPD = new Board
        {
            Id = 435,
            BoardId = "PTPD",
            Title = "РПС с ЦК: Акции ПИР (USD) - адресн.",
            BoardGroupId = 73,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Выкуп (USD) - адрес.
        /// </summary>
        public static readonly Board PSBU = new Board
        {
            Id = 277,
            BoardId = "PSBU",
            Title = "Выкуп (USD) - адрес.",
            BoardGroupId = 124,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Выкуп (CNY) - адрес.
        /// </summary>
        public static readonly Board PSBY = new Board
        {
            Id = 1290,
            BoardId = "PSBY",
            Title = "Выкуп (CNY) - адрес.",
            BoardGroupId = 1289,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Облигации (EUR) - адрес.
        /// </summary>
        public static readonly Board PTOE = new Board
        {
            Id = 359,
            BoardId = "PTOE",
            Title = "РПС с ЦК: Облигации (EUR) - адрес.",
            BoardGroupId = 209,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Д Облигации (EUR) - адрес.
        /// </summary>
        public static readonly Board PTED = new Board
        {
            Id = 369,
            BoardId = "PTED",
            Title = "РПС с ЦК: Д Облигации (EUR) - адрес.",
            BoardGroupId = 209,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Облигации ПИР (EUR) - адрес.
        /// </summary>
        public static readonly Board PTIE = new Board
        {
            Id = 393,
            BoardId = "PTIE",
            Title = "РПС с ЦК: Облигации ПИР (EUR) - адрес.",
            BoardGroupId = 209,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Акции и ДР (расч. в EUR) - адрес.
        /// </summary>
        public static readonly Board PSSE = new Board
        {
            Id = 316,
            BoardId = "PSSE",
            Title = "РПС: Акции и ДР (расч. в EUR) - адрес.",
            BoardGroupId = 160,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: ETF (расч. в EUR) - адрес.
        /// </summary>
        public static readonly Board PSTE = new Board
        {
            Id = 317,
            BoardId = "PSTE",
            Title = "РПС: ETF (расч. в EUR) - адрес.",
            BoardGroupId = 160,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: ПАИ (EUR) - адрес.
        /// </summary>
        public static readonly Board PSFE = new Board
        {
            Id = 449,
            BoardId = "PSFE",
            Title = "РПС: ПАИ (EUR) - адрес.",
            BoardGroupId = 160,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Акции ПИР (EUR) - адрес.
        /// </summary>
        public static readonly Board PSPE = new Board
        {
            Id = 451,
            BoardId = "PSPE",
            Title = "РПС: Акции ПИР (EUR) - адрес.",
            BoardGroupId = 160,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Акции и ДР (EUR) - адрес.
        /// </summary>
        public static readonly Board PTSE = new Board
        {
            Id = 318,
            BoardId = "PTSE",
            Title = "РПС с ЦК: Акции и ДР (EUR) - адрес.",
            BoardGroupId = 163,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: ETF (EUR) - адрес.
        /// </summary>
        public static readonly Board PTTE = new Board
        {
            Id = 319,
            BoardId = "PTTE",
            Title = "РПС с ЦК: ETF (EUR) - адрес.",
            BoardGroupId = 163,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Паи (EUR) - адрес.
        /// </summary>
        public static readonly Board PTFE = new Board
        {
            Id = 445,
            BoardId = "PTFE",
            Title = "РПС с ЦК: Паи (EUR) - адрес.",
            BoardGroupId = 163,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Акции ПИР (EUR) - адрес.
        /// </summary>
        public static readonly Board PTPE = new Board
        {
            Id = 447,
            BoardId = "PTPE",
            Title = "РПС с ЦК: Акции ПИР (EUR) - адрес.",
            BoardGroupId = 163,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Облигации - адрес.
        /// </summary>
        public static readonly Board PTOB = new Board
        {
            Id = 148,
            BoardId = "PTOB",
            Title = "РПС с ЦК: Облигации - адрес.",
            BoardGroupId = 282,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: А2-Облигации - адрес.
        /// </summary>
        public static readonly Board PTOS = new Board
        {
            Id = 149,
            BoardId = "PTOS",
            Title = "РПС С ЦК: А2-Облигации - адрес.",
            BoardGroupId = 282,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: В-Облигации - адрес.
        /// </summary>
        public static readonly Board PTOV = new Board
        {
            Id = 151,
            BoardId = "PTOV",
            Title = "РПС С ЦК: В-Облигации - адрес.",
            BoardGroupId = 282,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС С ЦК: Облигации внесписочные - адрес.
        /// </summary>
        public static readonly Board PTNB = new Board
        {
            Id = 152,
            BoardId = "PTNB",
            Title = "РПС С ЦК: Облигации внесписочные - адрес.",
            BoardGroupId = 282,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Д Облигации - адрес.
        /// </summary>
        public static readonly Board PTDB = new Board
        {
            Id = 367,
            BoardId = "PTDB",
            Title = "РПС с ЦК: Д Облигации - адрес.",
            BoardGroupId = 282,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Облигации ПИР - адрес.
        /// </summary>
        public static readonly Board PTIR = new Board
        {
            Id = 381,
            BoardId = "PTIR",
            Title = "РПС с ЦК: Облигации ПИР - адрес.",
            BoardGroupId = 282,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Облигации (USD) - адрес.
        /// </summary>
        public static readonly Board PTOD = new Board
        {
            Id = 232,
            BoardId = "PTOD",
            Title = "РПС с ЦК: Облигации (USD) - адрес.",
            BoardGroupId = 283,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Д Облигации (USD) - адрес.
        /// </summary>
        public static readonly Board PTUD = new Board
        {
            Id = 371,
            BoardId = "PTUD",
            Title = "РПС с ЦК: Д Облигации (USD) - адрес.",
            BoardGroupId = 283,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Облигации ПИР (USD) - адрес.
        /// </summary>
        public static readonly Board PTIU = new Board
        {
            Id = 387,
            BoardId = "PTIU",
            Title = "РПС с ЦК: Облигации ПИР (USD) - адрес.",
            BoardGroupId = 283,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации - адрес.
        /// </summary>
        public static readonly Board PSOB = new Board
        {
            Id = 17,
            BoardId = "PSOB",
            Title = "РПС: Облигации - адрес.",
            BoardGroupId = 284,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации Д - адрес.
        /// </summary>
        public static readonly Board PSDB = new Board
        {
            Id = 92,
            BoardId = "PSDB",
            Title = "РПС: Облигации Д - адрес.",
            BoardGroupId = 284,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации ПИР - адрес.
        /// </summary>
        public static readonly Board PSIR = new Board
        {
            Id = 379,
            BoardId = "PSIR",
            Title = "РПС: Облигации ПИР - адрес.",
            BoardGroupId = 284,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации (USD) - адрес.
        /// </summary>
        public static readonly Board PSEU = new Board
        {
            Id = 30,
            BoardId = "PSEU",
            Title = "РПС: Облигации (USD) - адрес.",
            BoardGroupId = 285,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации Д (USD) - адрес.
        /// </summary>
        public static readonly Board PSUD = new Board
        {
            Id = 375,
            BoardId = "PSUD",
            Title = "РПС: Облигации Д (USD) - адрес.",
            BoardGroupId = 285,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации ПИР (USD) - адрес.
        /// </summary>
        public static readonly Board PSIU = new Board
        {
            Id = 385,
            BoardId = "PSIU",
            Title = "РПС: Облигации ПИР (USD) - адрес.",
            BoardGroupId = 285,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации (EUR) - адрес.
        /// </summary>
        public static readonly Board PSEO = new Board
        {
            Id = 160,
            BoardId = "PSEO",
            Title = "РПС: Облигации (EUR) - адрес.",
            BoardGroupId = 286,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации Д (EUR) - адрес.
        /// </summary>
        public static readonly Board PSED = new Board
        {
            Id = 373,
            BoardId = "PSED",
            Title = "РПС: Облигации Д (EUR) - адрес.",
            BoardGroupId = 286,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации ПИР (EUR) - адрес.
        /// </summary>
        public static readonly Board PSIE = new Board
        {
            Id = 391,
            BoardId = "PSIE",
            Title = "РПС: Облигации ПИР (EUR) - адрес.",
            BoardGroupId = 286,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации (CNY) - адрес.
        /// </summary>
        public static readonly Board PSYO = new Board
        {
            Id = 236,
            BoardId = "PSYO",
            Title = "РПС: Облигации (CNY) - адрес.",
            BoardGroupId = 247,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Облигации ПИР (CNY) - адрес.
        /// </summary>
        public static readonly Board PSIY = new Board
        {
            Id = 397,
            BoardId = "PSIY",
            Title = "РПС: Облигации ПИР (CNY) - адрес.",
            BoardGroupId = 247,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Облигации ПИР (CNY) - адрес.
        /// </summary>
        public static readonly Board PTIY = new Board
        {
            Id = 399,
            BoardId = "PTIY",
            Title = "РПС с ЦК: Облигации ПИР (CNY) - адрес.",
            BoardGroupId = 249,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Облигации (CNY) - адрес.
        /// </summary>
        public static readonly Board PTOY = new Board
        {
            Id = 1151,
            BoardId = "PTOY",
            Title = "РПС с ЦК: Облигации (CNY) - адрес.",
            BoardGroupId = 249,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: ПАИ (CNY) - адрес.
        /// </summary>
        public static readonly Board PSTY = new Board
        {
            Id = 1219,
            BoardId = "PSTY",
            Title = "РПС: ПАИ (CNY) - адрес.",
            BoardGroupId = 1218,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Акции ПИР (CNY) - адрес.
        /// </summary>
        public static readonly Board PSPY = new Board
        {
            Id = 1220,
            BoardId = "PSPY",
            Title = "РПС: Акции ПИР (CNY) - адрес.",
            BoardGroupId = 1218,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Паи (CNY) - адрес.
        /// </summary>
        public static readonly Board PTTY = new Board
        {
            Id = 1222,
            BoardId = "PTTY",
            Title = "РПС с ЦК: Паи (CNY) - адрес.",
            BoardGroupId = 1221,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Акции ПИР (CNY) - адрес.
        /// </summary>
        public static readonly Board PTPY = new Board
        {
            Id = 1223,
            BoardId = "PTPY",
            Title = "РПС с ЦК: Акции ПИР (CNY) - адрес.",
            BoardGroupId = 1221,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: ПАИ (HKD) - адресн.
        /// </summary>
        public static readonly Board PSTH = new Board
        {
            Id = 1242,
            BoardId = "PSTH",
            Title = "РПС: ПАИ (HKD) - адресн.",
            BoardGroupId = 1241,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Акции ПИР (HKD) - адресн.
        /// </summary>
        public static readonly Board PSPH = new Board
        {
            Id = 1243,
            BoardId = "PSPH",
            Title = "РПС: Акции ПИР (HKD) - адресн.",
            BoardGroupId = 1241,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Паи (HKD) - адресн.
        /// </summary>
        public static readonly Board PTTH = new Board
        {
            Id = 1245,
            BoardId = "PTTH",
            Title = "РПС с ЦК: Паи (HKD) - адресн.",
            BoardGroupId = 1244,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Акции ПИР (HKD) - адресн.
        /// </summary>
        public static readonly Board PTPH = new Board
        {
            Id = 1246,
            BoardId = "PTPH",
            Title = "РПС с ЦК: Акции ПИР (HKD) - адресн.",
            BoardGroupId = 1244,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК - адрес.
        /// </summary>
        public static readonly Board PSCC = new Board
        {
            Id = 97,
            BoardId = "PSCC",
            Title = "РПС с ЦК - адрес.",
            BoardGroupId = 32,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Индексы фондового рынка
        /// </summary>
        public static readonly Board SNDX = new Board
        {
            Id = 44,
            BoardId = "SNDX",
            Title = "Индексы фондового рынка",
            BoardGroupId = 9,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Индексы РТС
        /// </summary>
        public static readonly Board RTSI = new Board
        {
            Id = 102,
            BoardId = "RTSI",
            Title = "Индексы РТС",
            BoardGroupId = 9,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// INAV
        /// </summary>
        public static readonly Board INAV = new Board
        {
            Id = 265,
            BoardId = "INAV",
            Title = "INAV",
            BoardGroupId = 104,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Money Market IndeX
        /// </summary>
        public static readonly Board MMIX = new Board
        {
            Id = 312,
            BoardId = "MMIX",
            Title = "Money Market IndeX",
            BoardGroupId = 155,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Индексы НТБ
        /// </summary>
        public static readonly Board AGRO = new Board
        {
            Id = 1029,
            BoardId = "AGRO",
            Title = "Индексы НТБ",
            BoardGroupId = 1028,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Ценовой фиксинг
        /// </summary>
        public static readonly Board INPF = new Board
        {
            Id = 1154,
            BoardId = "INPF",
            Title = "Ценовой фиксинг",
            BoardGroupId = 1153,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Индексы СПФИ
        /// </summary>
        public static readonly Board SDII = new Board
        {
            Id = 500,
            BoardId = "SDII",
            Title = "Индексы СПФИ",
            BoardGroupId = 287,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Standard: дневная сессия - безадрес.
        /// </summary>
        public static readonly Board STMR = new Board
        {
            Id = 104,
            BoardId = "STMR",
            Title = "Standard: дневная сессия - безадрес.",
            BoardGroupId = 36,
            EngineId = 1,
            MarketId = 23,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Standard: вечерняя сессия - безадрес.
        /// </summary>
        public static readonly Board SDMR = new Board
        {
            Id = 105,
            BoardId = "SDMR",
            Title = "Standard: вечерняя сессия - безадрес.",
            BoardGroupId = 36,
            EngineId = 1,
            MarketId = 23,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Standard: дневная сессия - адрес.
        /// </summary>
        public static readonly Board STAD = new Board
        {
            Id = 108,
            BoardId = "STAD",
            Title = "Standard: дневная сессия - адрес.",
            BoardGroupId = 41,
            EngineId = 1,
            MarketId = 23,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Standard: вечерняя сессия - адрес.
        /// </summary>
        public static readonly Board SDAD = new Board
        {
            Id = 109,
            BoardId = "SDAD",
            Title = "Standard: вечерняя сессия - адрес.",
            BoardGroupId = 41,
            EngineId = 1,
            MarketId = 23,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Standard: сделки репо, дневная сессия - адрес.
        /// </summary>
        public static readonly Board STRP = new Board
        {
            Id = 106,
            BoardId = "STRP",
            Title = "Standard: сделки репо, дневная сессия - адрес.",
            BoardGroupId = 40,
            EngineId = 1,
            MarketId = 23,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Standard: сделки репо, вечерняя сессия - адрес.
        /// </summary>
        public static readonly Board SDRP = new Board
        {
            Id = 107,
            BoardId = "SDRP",
            Title = "Standard: сделки репо, вечерняя сессия - адрес.",
            BoardGroupId = 40,
            EngineId = 1,
            MarketId = 23,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Classica - безадрес.
        /// </summary>
        public static readonly Board CLMR = new Board
        {
            Id = 112,
            BoardId = "CLMR",
            Title = "Classica - безадрес.",
            BoardGroupId = 43,
            EngineId = 1,
            MarketId = 25,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Classica - адрес.
        /// </summary>
        public static readonly Board CLAD = new Board
        {
            Id = 113,
            BoardId = "CLAD",
            Title = "Classica - адрес.",
            BoardGroupId = 44,
            EngineId = 1,
            MarketId = 25,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 1 день (USD) - безадрес.
        /// </summary>
        public static readonly Board EQRD = new Board
        {
            Id = 239,
            BoardId = "EQRD",
            Title = "РЕПО с ЦК 1 день (USD) - безадрес.",
            BoardGroupId = 92,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 1 день (EUR) - безадрес.
        /// </summary>
        public static readonly Board EQRE = new Board
        {
            Id = 240,
            BoardId = "EQRE",
            Title = "РЕПО с ЦК 1 день (EUR) - безадрес.",
            BoardGroupId = 93,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 7 дн. - безадрес.
        /// </summary>
        public static readonly Board EQWP = new Board
        {
            Id = 241,
            BoardId = "EQWP",
            Title = "РЕПО с ЦК 7 дн. - безадрес.",
            BoardGroupId = 76,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 7 дней (USD) - безадрес.
        /// </summary>
        public static readonly Board EQWD = new Board
        {
            Id = 245,
            BoardId = "EQWD",
            Title = "РЕПО с ЦК 7 дней (USD) - безадрес.",
            BoardGroupId = 78,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 7 дней (EUR) - безадрес.
        /// </summary>
        public static readonly Board EQWE = new Board
        {
            Id = 246,
            BoardId = "EQWE",
            Title = "РЕПО с ЦК 7 дней (EUR) - безадрес.",
            BoardGroupId = 79,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 1 день - безадрес.
        /// </summary>
        public static readonly Board EQRP = new Board
        {
            Id = 123,
            BoardId = "EQRP",
            Title = "РЕПО с ЦК 1 день - безадрес.",
            BoardGroupId = 50,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 1 мес.(RUB) - безадрес.
        /// </summary>
        public static readonly Board EQMP = new Board
        {
            Id = 298,
            BoardId = "EQMP",
            Title = "РЕПО с ЦК 1 мес.(RUB) - безадрес.",
            BoardGroupId = 142,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 1 мес. (USD) - безадрес.
        /// </summary>
        public static readonly Board EQMD = new Board
        {
            Id = 299,
            BoardId = "EQMD",
            Title = "РЕПО с ЦК 1 мес. (USD) - безадрес.",
            BoardGroupId = 143,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 1 мес. (EUR) - безадрес.
        /// </summary>
        public static readonly Board EQME = new Board
        {
            Id = 300,
            BoardId = "EQME",
            Title = "РЕПО с ЦК 1 мес. (EUR) - безадрес.",
            BoardGroupId = 144,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 3 мес. (RUB) - безадрес.
        /// </summary>
        public static readonly Board EQTP = new Board
        {
            Id = 301,
            BoardId = "EQTP",
            Title = "РЕПО с ЦК 3 мес. (RUB) - безадрес.",
            BoardGroupId = 145,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 3 мес. (USD) - безадрес.
        /// </summary>
        public static readonly Board ETQD = new Board
        {
            Id = 302,
            BoardId = "ETQD",
            Title = "РЕПО с ЦК 3 мес. (USD) - безадрес.",
            BoardGroupId = 146,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 3 мес. (EUR) - безадрес.
        /// </summary>
        public static readonly Board EQTE = new Board
        {
            Id = 303,
            BoardId = "EQTE",
            Title = "РЕПО с ЦК 3 мес. (EUR) - безадрес.",
            BoardGroupId = 147,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК: Урегулирование - безадрес.
        /// </summary>
        public static readonly Board LIQR = new Board
        {
            Id = 304,
            BoardId = "LIQR",
            Title = "РЕПО с ЦК: Урегулирование - безадрес.",
            BoardGroupId = 148,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 1 день (CNY) - безадрес.
        /// </summary>
        public static readonly Board EQRY = new Board
        {
            Id = 309,
            BoardId = "EQRY",
            Title = "РЕПО с ЦК 1 день (CNY) - безадрес.",
            BoardGroupId = 152,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК (CNY) - адрес.
        /// </summary>
        public static readonly Board PSRY = new Board
        {
            Id = 310,
            BoardId = "PSRY",
            Title = "РЕПО с ЦК (CNY) - адрес.",
            BoardGroupId = 153,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 7 дней (CNY) - безадрес.
        /// </summary>
        public static readonly Board EQWY = new Board
        {
            Id = 1117,
            BoardId = "EQWY",
            Title = "РЕПО с ЦК 7 дней (CNY) - безадрес.",
            BoardGroupId = 1116,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 1 мес. (CNY) - безадрес.
        /// </summary>
        public static readonly Board EQMY = new Board
        {
            Id = 1119,
            BoardId = "EQMY",
            Title = "РЕПО с ЦК 1 мес. (CNY) - безадрес.",
            BoardGroupId = 1118,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК 3 мес. (CNY) - безадрес
        /// </summary>
        public static readonly Board EQTY = new Board
        {
            Id = 1121,
            BoardId = "EQTY",
            Title = "РЕПО с ЦК 3 мес. (CNY) - безадрес",
            BoardGroupId = 1120,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК - адрес.
        /// </summary>
        public static readonly Board PSRP = new Board
        {
            Id = 125,
            BoardId = "PSRP",
            Title = "РЕПО с ЦК - адрес.",
            BoardGroupId = 65,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК (USD) - адрес.
        /// </summary>
        public static readonly Board PSRD = new Board
        {
            Id = 242,
            BoardId = "PSRD",
            Title = "РЕПО с ЦК (USD) - адрес.",
            BoardGroupId = 91,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК (EUR) - адрес.
        /// </summary>
        public static readonly Board PSRE = new Board
        {
            Id = 243,
            BoardId = "PSRE",
            Title = "РЕПО с ЦК (EUR) - адрес.",
            BoardGroupId = 96,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион с ЦК 1 день - безадрес.
        /// </summary>
        public static readonly Board FKRP = new Board
        {
            Id = 325,
            BoardId = "FKRP",
            Title = "Аукцион с ЦК 1 день - безадрес.",
            BoardGroupId = 169,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион с ЦК 1 неделя - безадрес.
        /// </summary>
        public static readonly Board FKOW = new Board
        {
            Id = 327,
            BoardId = "FKOW",
            Title = "Аукцион с ЦК 1 неделя - безадрес.",
            BoardGroupId = 171,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион с ЦК 2 недели - безадрес.
        /// </summary>
        public static readonly Board FKSW = new Board
        {
            Id = 329,
            BoardId = "FKSW",
            Title = "Аукцион с ЦК 2 недели - безадрес.",
            BoardGroupId = 173,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион с ЦК 5 недель - безадрес.
        /// </summary>
        public static readonly Board FKFW = new Board
        {
            Id = 499,
            BoardId = "FKFW",
            Title = "Аукцион с ЦК 5 недель - безадрес.",
            BoardGroupId = 281,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион с ЦК 1 месяц - безадрес.
        /// </summary>
        public static readonly Board FKOM = new Board
        {
            Id = 331,
            BoardId = "FKOM",
            Title = "Аукцион с ЦК 1 месяц - безадрес.",
            BoardGroupId = 175,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион с ЦК 2 месяца - безадрес.
        /// </summary>
        public static readonly Board FKSM = new Board
        {
            Id = 333,
            BoardId = "FKSM",
            Title = "Аукцион с ЦК 2 месяца - безадрес.",
            BoardGroupId = 177,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион с ЦК 3 месяца - безадрес.
        /// </summary>
        public static readonly Board FKTM = new Board
        {
            Id = 335,
            BoardId = "FKTM",
            Title = "Аукцион с ЦК 3 месяца - безадрес.",
            BoardGroupId = 179,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион с ЦК 6 месяцев - безадрес.
        /// </summary>
        public static readonly Board FKUM = new Board
        {
            Id = 337,
            BoardId = "FKUM",
            Title = "Аукцион с ЦК 6 месяцев - безадрес.",
            BoardGroupId = 181,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион с ЦК 1 год - безадрес.
        /// </summary>
        public static readonly Board FKOY = new Board
        {
            Id = 339,
            BoardId = "FKOY",
            Title = "Аукцион с ЦК 1 год - безадрес.",
            BoardGroupId = 183,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 1 день - безадрес.
        /// </summary>
        public static readonly Board FRRP = new Board
        {
            Id = 501,
            BoardId = "FRRP",
            Title = "Аукцион РЕПО с ЦК 1 день - безадрес.",
            BoardGroupId = 288,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 1 неделя - безадрес.
        /// </summary>
        public static readonly Board FROW = new Board
        {
            Id = 502,
            BoardId = "FROW",
            Title = "Аукцион РЕПО с ЦК 1 неделя - безадрес.",
            BoardGroupId = 289,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 2 недели - безадрес.
        /// </summary>
        public static readonly Board FRSW = new Board
        {
            Id = 513,
            BoardId = "FRSW",
            Title = "Аукцион РЕПО с ЦК 2 недели - безадрес.",
            BoardGroupId = 296,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 5 недель - безадрес.
        /// </summary>
        public static readonly Board FRFW = new Board
        {
            Id = 514,
            BoardId = "FRFW",
            Title = "Аукцион РЕПО с ЦК 5 недель - безадрес.",
            BoardGroupId = 297,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 1 месяц - безадрес.
        /// </summary>
        public static readonly Board FROM = new Board
        {
            Id = 503,
            BoardId = "FROM",
            Title = "Аукцион РЕПО с ЦК 1 месяц - безадрес.",
            BoardGroupId = 290,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 3 месяца - безадрес.
        /// </summary>
        public static readonly Board FRTM = new Board
        {
            Id = 504,
            BoardId = "FRTM",
            Title = "Аукцион РЕПО с ЦК 3 месяца - безадрес.",
            BoardGroupId = 291,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 1 день - безадрес.
        /// </summary>
        public static readonly Board FSRP = new Board
        {
            Id = 1248,
            BoardId = "FSRP",
            Title = "Аукцион обр.РЕПО с ЦК 1 день - безадрес.",
            BoardGroupId = 1247,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 1 неделя - безадрес.
        /// </summary>
        public static readonly Board FSOW = new Board
        {
            Id = 1250,
            BoardId = "FSOW",
            Title = "Аукцион обр.РЕПО с ЦК 1 неделя - безадрес.",
            BoardGroupId = 1249,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 2 недели - безадрес.
        /// </summary>
        public static readonly Board FSSW = new Board
        {
            Id = 1252,
            BoardId = "FSSW",
            Title = "Аукцион обр.РЕПО с ЦК 2 недели - безадрес.",
            BoardGroupId = 1251,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 1 месяц - безадрес.
        /// </summary>
        public static readonly Board FSOM = new Board
        {
            Id = 1254,
            BoardId = "FSOM",
            Title = "Аукцион обр.РЕПО с ЦК 1 месяц - безадрес.",
            BoardGroupId = 1253,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 5 недель - безадрес.
        /// </summary>
        public static readonly Board FSFW = new Board
        {
            Id = 1256,
            BoardId = "FSFW",
            Title = "Аукцион обр.РЕПО с ЦК 5 недель - безадрес.",
            BoardGroupId = 1255,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Для квал. инвесторов - безадрес.
        /// </summary>
        public static readonly Board TQQI = new Board
        {
            Id = 167,
            BoardId = "TQQI",
            Title = "Т+: Для квал. инвесторов - безадрес.",
            BoardGroupId = 63,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Основной режим: Для квал. инвесторов - безадрес.
        /// </summary>
        public static readonly Board EQQI = new Board
        {
            Id = 155,
            BoardId = "EQQI",
            Title = "Основной режим: Для квал. инвесторов - безадрес.",
            BoardGroupId = 60,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РПС: Для квал. инвесторов - адрес.
        /// </summary>
        public static readonly Board PSQI = new Board
        {
            Id = 156,
            BoardId = "PSQI",
            Title = "РПС: Для квал. инвесторов - адрес.",
            BoardGroupId = 61,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РПС с ЦК: Для квал. инвесторов - адрес.
        /// </summary>
        public static readonly Board PTQI = new Board
        {
            Id = 168,
            BoardId = "PTQI",
            Title = "РПС с ЦК: Для квал. инвесторов - адрес.",
            BoardGroupId = 64,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО: Для квал. инвесторов - адрес.
        /// </summary>
        public static readonly Board RPQI = new Board
        {
            Id = 157,
            BoardId = "RPQI",
            Title = "РЕПО: Для квал. инвесторов - адрес.",
            BoardGroupId = 62,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО: Для квал. инвесторов (USD) - адрес.
        /// </summary>
        public static readonly Board RPUQ = new Board
        {
            Id = 166,
            BoardId = "RPUQ",
            Title = "РЕПО: Для квал. инвесторов (USD) - адрес.",
            BoardGroupId = 62,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Для квал. инвесторов (USD) - безадрес.
        /// </summary>
        public static readonly Board TQQD = new Board
        {
            Id = 255,
            BoardId = "TQQD",
            Title = "Т+: Для квал. инвесторов (USD) - безадрес.",
            BoardGroupId = 87,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Репортинг внебиржевых сделок (6264-У)
        /// </summary>
        public static readonly Board SOTC = new Board
        {
            Id = 183,
            BoardId = "SOTC",
            Title = "Репортинг внебиржевых сделок (6264-У)",
            BoardGroupId = 71,
            EngineId = 1,
            MarketId = 29,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// MOEX Board
        /// </summary>
        public static readonly Board MXBD = new Board
        {
            Id = 244,
            BoardId = "MXBD",
            Title = "MOEX Board",
            BoardGroupId = 72,
            EngineId = 1,
            MarketId = 33,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Депозиты с ЦК - безадрес.
        /// </summary>
        public static readonly Board TDEP = new Board
        {
            Id = 258,
            BoardId = "TDEP",
            Title = "Депозиты с ЦК - безадрес.",
            BoardGroupId = 97,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Депозиты с ЦК - адрес.
        /// </summary>
        public static readonly Board NDEP = new Board
        {
            Id = 259,
            BoardId = "NDEP",
            Title = "Депозиты с ЦК - адрес.",
            BoardGroupId = 98,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Депозиты с ЦК (USD) - адрес.
        /// </summary>
        public static readonly Board NDPU = new Board
        {
            Id = 266,
            BoardId = "NDPU",
            Title = "Депозиты с ЦК (USD) - адрес.",
            BoardGroupId = 109,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Депозиты с ЦК (EUR) - адрес.
        /// </summary>
        public static readonly Board NDPE = new Board
        {
            Id = 292,
            BoardId = "NDPE",
            Title = "Депозиты с ЦК (EUR) - адрес.",
            BoardGroupId = 136,
            EngineId = 1,
            MarketId = 35,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Депозиты с ЦК (USD) - безадрес.
        /// </summary>
        public static readonly Board TDPU = new Board
        {
            Id = 267,
            BoardId = "TDPU",
            Title = "Депозиты с ЦК (USD) - безадрес.",
            BoardGroupId = 110,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Депозиты с ЦК (EUR) - безадрес.
        /// </summary>
        public static readonly Board TDPE = new Board
        {
            Id = 293,
            BoardId = "TDPE",
            Title = "Депозиты с ЦК (EUR) - безадрес.",
            BoardGroupId = 137,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Депозиты с ЦК (CNY) - безадрес. 
        /// </summary>
        public static readonly Board TDPY = new Board
        {
            Id = 1143,
            BoardId = "TDPY",
            Title = "Депозиты с ЦК (CNY) - безадрес. ",
            BoardGroupId = 1142,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Депозиты с ЦК (CNY) - адрес.
        /// </summary>
        public static readonly Board NDPY = new Board
        {
            Id = 1145,
            BoardId = "NDPY",
            Title = "Депозиты с ЦК (CNY) - адрес.",
            BoardGroupId = 1144,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Депозиты с ЦК - Аукцион
        /// </summary>
        public static readonly Board ADEP = new Board
        {
            Id = 341,
            BoardId = "ADEP",
            Title = "Депозиты с ЦК - Аукцион",
            BoardGroupId = 185,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Продажа обеспечения бирж.рынок - безадрес.
        /// </summary>
        public static readonly Board LIQB = new Board
        {
            Id = 279,
            BoardId = "LIQB",
            Title = "Продажа обеспечения бирж.рынок - безадрес.",
            BoardGroupId = 120,
            EngineId = 1,
            MarketId = 36,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Урегулирование с ЦК Нерезиденты - безадрес.
        /// </summary>
        public static readonly Board CIQB = new Board
        {
            Id = 1083,
            BoardId = "CIQB",
            Title = "Урегулирование с ЦК Нерезиденты - безадрес.",
            BoardGroupId = 1082,
            EngineId = 1,
            MarketId = 36,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 день - безадрес.
        /// </summary>
        public static readonly Board GCRP = new Board
        {
            Id = 253,
            BoardId = "GCRP",
            Title = "РЕПО с ЦК с КСУ 1 день - безадрес.",
            BoardGroupId = 86,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 7 дн. - безадрес.
        /// </summary>
        public static readonly Board GCOW = new Board
        {
            Id = 250,
            BoardId = "GCOW",
            Title = "РЕПО с ЦК с КСУ 7 дн. - безадрес.",
            BoardGroupId = 83,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 14 дн. - безадрес.
        /// </summary>
        public static readonly Board GCSW = new Board
        {
            Id = 247,
            BoardId = "GCSW",
            Title = "РЕПО с ЦК с КСУ 14 дн. - безадрес.",
            BoardGroupId = 80,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 месяц - безадрес.
        /// </summary>
        public static readonly Board GCOM = new Board
        {
            Id = 251,
            BoardId = "GCOM",
            Title = "РЕПО с ЦК с КСУ 1 месяц - безадрес.",
            BoardGroupId = 84,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 2 месяца - безадрес.
        /// </summary>
        public static readonly Board GCSM = new Board
        {
            Id = 248,
            BoardId = "GCSM",
            Title = "РЕПО с ЦК с КСУ 2 месяца - безадрес.",
            BoardGroupId = 81,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 3 месяца - безадрес.
        /// </summary>
        public static readonly Board GCTM = new Board
        {
            Id = 252,
            BoardId = "GCTM",
            Title = "РЕПО с ЦК с КСУ 3 месяца - безадрес.",
            BoardGroupId = 85,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 6 мес. - безадрес.
        /// </summary>
        public static readonly Board GCUM = new Board
        {
            Id = 264,
            BoardId = "GCUM",
            Title = "РЕПО с ЦК с КСУ 6 мес. - безадрес.",
            BoardGroupId = 103,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 год - безадрес.
        /// </summary>
        public static readonly Board GCOY = new Board
        {
            Id = 263,
            BoardId = "GCOY",
            Title = "РЕПО с ЦК с КСУ 1 год - безадрес.",
            BoardGroupId = 102,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ - адрес.
        /// </summary>
        public static readonly Board PSGC = new Board
        {
            Id = 249,
            BoardId = "PSGC",
            Title = "РЕПО с ЦК с КСУ - адрес.",
            BoardGroupId = 82,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 день (USD) - безадрес.
        /// </summary>
        public static readonly Board GURP = new Board
        {
            Id = 268,
            BoardId = "GURP",
            Title = "РЕПО с ЦК с КСУ 1 день (USD) - безадрес.",
            BoardGroupId = 111,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 7 дн. (USD) - безадрес.
        /// </summary>
        public static readonly Board GUOW = new Board
        {
            Id = 269,
            BoardId = "GUOW",
            Title = "РЕПО с ЦК с КСУ 7 дн. (USD) - безадрес.",
            BoardGroupId = 112,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 14 дн. (USD) - безадрес.
        /// </summary>
        public static readonly Board GUSW = new Board
        {
            Id = 270,
            BoardId = "GUSW",
            Title = "РЕПО с ЦК с КСУ 14 дн. (USD) - безадрес.",
            BoardGroupId = 113,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 месяц (USD) - безадрес.
        /// </summary>
        public static readonly Board GUOM = new Board
        {
            Id = 271,
            BoardId = "GUOM",
            Title = "РЕПО с ЦК с КСУ 1 месяц (USD) - безадрес.",
            BoardGroupId = 114,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 2 месяца (USD) - безадрес.
        /// </summary>
        public static readonly Board GUSM = new Board
        {
            Id = 272,
            BoardId = "GUSM",
            Title = "РЕПО с ЦК с КСУ 2 месяца (USD) - безадрес.",
            BoardGroupId = 115,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 3 месяца (USD) - безадрес.
        /// </summary>
        public static readonly Board GUTM = new Board
        {
            Id = 273,
            BoardId = "GUTM",
            Title = "РЕПО с ЦК с КСУ 3 месяца (USD) - безадрес.",
            BoardGroupId = 116,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 6 месяцев (USD) - безадрес.
        /// </summary>
        public static readonly Board GUUM = new Board
        {
            Id = 274,
            BoardId = "GUUM",
            Title = "РЕПО с ЦК с КСУ 6 месяцев (USD) - безадрес.",
            BoardGroupId = 117,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 год (USD) - безадрес.
        /// </summary>
        public static readonly Board GUOY = new Board
        {
            Id = 275,
            BoardId = "GUOY",
            Title = "РЕПО с ЦК с КСУ 1 год (USD) - безадрес.",
            BoardGroupId = 118,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ (USD) - адрес.
        /// </summary>
        public static readonly Board PUGC = new Board
        {
            Id = 276,
            BoardId = "PUGC",
            Title = "РЕПО с ЦК с КСУ (USD) - адрес.",
            BoardGroupId = 119,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 день (EUR) - безадрес.
        /// </summary>
        public static readonly Board GERP = new Board
        {
            Id = 283,
            BoardId = "GERP",
            Title = "РЕПО с ЦК с КСУ 1 день (EUR) - безадрес.",
            BoardGroupId = 127,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 7 дн. (EUR) - безадрес.
        /// </summary>
        public static readonly Board GEOW = new Board
        {
            Id = 284,
            BoardId = "GEOW",
            Title = "РЕПО с ЦК с КСУ 7 дн. (EUR) - безадрес.",
            BoardGroupId = 128,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 14 дн. (EUR) - безадрес.
        /// </summary>
        public static readonly Board GESW = new Board
        {
            Id = 285,
            BoardId = "GESW",
            Title = "РЕПО с ЦК с КСУ 14 дн. (EUR) - безадрес.",
            BoardGroupId = 129,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 месяц (EUR) - безадрес.
        /// </summary>
        public static readonly Board GEOM = new Board
        {
            Id = 286,
            BoardId = "GEOM",
            Title = "РЕПО с ЦК с КСУ 1 месяц (EUR) - безадрес.",
            BoardGroupId = 130,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 2 месяца (EUR) - безадрес.
        /// </summary>
        public static readonly Board GESM = new Board
        {
            Id = 287,
            BoardId = "GESM",
            Title = "РЕПО с ЦК с КСУ 2 месяца (EUR) - безадрес.",
            BoardGroupId = 131,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 3 месяца (EUR) - безадрес.
        /// </summary>
        public static readonly Board GETM = new Board
        {
            Id = 288,
            BoardId = "GETM",
            Title = "РЕПО с ЦК с КСУ 3 месяца (EUR) - безадрес.",
            BoardGroupId = 132,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 6 месяцев (EUR) - безадрес.
        /// </summary>
        public static readonly Board GEUM = new Board
        {
            Id = 289,
            BoardId = "GEUM",
            Title = "РЕПО с ЦК с КСУ 6 месяцев (EUR) - безадрес.",
            BoardGroupId = 133,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 год (EUR) - безадрес.
        /// </summary>
        public static readonly Board GEOY = new Board
        {
            Id = 290,
            BoardId = "GEOY",
            Title = "РЕПО с ЦК с КСУ 1 год (EUR) - безадрес.",
            BoardGroupId = 134,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ (EUR) - адрес.
        /// </summary>
        public static readonly Board PEGC = new Board
        {
            Id = 291,
            BoardId = "PEGC",
            Title = "РЕПО с ЦК с КСУ (EUR) - адрес.",
            BoardGroupId = 135,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 9 месяцев - безадрес.
        /// </summary>
        public static readonly Board GCNM = new Board
        {
            Id = 343,
            BoardId = "GCNM",
            Title = "РЕПО с ЦК с КСУ 9 месяцев - безадрес.",
            BoardGroupId = 187,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 9 мес. (USD) - безадрес.
        /// </summary>
        public static readonly Board GUNM = new Board
        {
            Id = 345,
            BoardId = "GUNM",
            Title = "РЕПО с ЦК с КСУ 9 мес. (USD) - безадрес.",
            BoardGroupId = 189,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 9 мес. (EUR) - безадрес.
        /// </summary>
        public static readonly Board GENM = new Board
        {
            Id = 347,
            BoardId = "GENM",
            Title = "РЕПО с ЦК с КСУ 9 мес. (EUR) - безадрес.",
            BoardGroupId = 191,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 день (CNY) - безадрес.
        /// </summary>
        public static readonly Board GYRP = new Board
        {
            Id = 1123,
            BoardId = "GYRP",
            Title = "РЕПО с ЦК с КСУ 1 день (CNY) - безадрес.",
            BoardGroupId = 1122,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 7 дней (CNY) - безадрес.
        /// </summary>
        public static readonly Board GYOW = new Board
        {
            Id = 1125,
            BoardId = "GYOW",
            Title = "РЕПО с ЦК с КСУ 7 дней (CNY) - безадрес.",
            BoardGroupId = 1124,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 14 дней (CNY) - безадрес.
        /// </summary>
        public static readonly Board GYSW = new Board
        {
            Id = 1127,
            BoardId = "GYSW",
            Title = "РЕПО с ЦК с КСУ 14 дней (CNY) - безадрес.",
            BoardGroupId = 1126,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 месяц (CNY) - безадрес.
        /// </summary>
        public static readonly Board GYOM = new Board
        {
            Id = 1129,
            BoardId = "GYOM",
            Title = "РЕПО с ЦК с КСУ 1 месяц (CNY) - безадрес.",
            BoardGroupId = 1128,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 2 месяца (CNY) - безадрес.
        /// </summary>
        public static readonly Board GYSM = new Board
        {
            Id = 1131,
            BoardId = "GYSM",
            Title = "РЕПО с ЦК с КСУ 2 месяца (CNY) - безадрес.",
            BoardGroupId = 1130,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 3 месяца (CNY) - безадрес.
        /// </summary>
        public static readonly Board GYTM = new Board
        {
            Id = 1133,
            BoardId = "GYTM",
            Title = "РЕПО с ЦК с КСУ 3 месяца (CNY) - безадрес.",
            BoardGroupId = 1132,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 6 месяцев (CNY) - безадрес.
        /// </summary>
        public static readonly Board GYUM = new Board
        {
            Id = 1135,
            BoardId = "GYUM",
            Title = "РЕПО с ЦК с КСУ 6 месяцев (CNY) - безадрес.",
            BoardGroupId = 1134,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 9 месяцев (CNY) - безадрес.
        /// </summary>
        public static readonly Board GYNM = new Board
        {
            Id = 1137,
            BoardId = "GYNM",
            Title = "РЕПО с ЦК с КСУ 9 месяцев (CNY) - безадрес.",
            BoardGroupId = 1136,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 год (CNY) - безадрес.
        /// </summary>
        public static readonly Board GYOY = new Board
        {
            Id = 1139,
            BoardId = "GYOY",
            Title = "РЕПО с ЦК с КСУ 1 год (CNY) - безадрес.",
            BoardGroupId = 1138,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ (CNY) - адрес.
        /// </summary>
        public static readonly Board PYGC = new Board
        {
            Id = 1141,
            BoardId = "PYGC",
            Title = "РЕПО с ЦК с КСУ (CNY) - адрес.",
            BoardGroupId = 1140,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 7 дней - безадрес. (RUSFAR)
        /// </summary>
        public static readonly Board FCOW = new Board
        {
            Id = 1157,
            BoardId = "FCOW",
            Title = "РЕПО с ЦК с КСУ пл. 7 дней - безадрес. (RUSFAR)",
            BoardGroupId = 1156,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 14 дней - безадрес. (RUSFAR)
        /// </summary>
        public static readonly Board FCSW = new Board
        {
            Id = 1159,
            BoardId = "FCSW",
            Title = "РЕПО с ЦК с КСУ пл. 14 дней - безадрес. (RUSFAR)",
            BoardGroupId = 1158,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 1 месяц - безадрес. (RUSFAR)
        /// </summary>
        public static readonly Board FCOM = new Board
        {
            Id = 1161,
            BoardId = "FCOM",
            Title = "РЕПО с ЦК с КСУ пл. 1 месяц - безадрес. (RUSFAR)",
            BoardGroupId = 1160,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 2 месяца - безадрес. (RUSFAR)
        /// </summary>
        public static readonly Board FCSM = new Board
        {
            Id = 1163,
            BoardId = "FCSM",
            Title = "РЕПО с ЦК с КСУ пл. 2 месяца - безадрес. (RUSFAR)",
            BoardGroupId = 1162,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 3 месяца - безадрес. (RUSFAR)
        /// </summary>
        public static readonly Board FCTM = new Board
        {
            Id = 1165,
            BoardId = "FCTM",
            Title = "РЕПО с ЦК с КСУ пл. 3 месяца - безадрес. (RUSFAR)",
            BoardGroupId = 1164,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 6 месяца - безадрес. (RUSFAR)
        /// </summary>
        public static readonly Board FCUM = new Board
        {
            Id = 1167,
            BoardId = "FCUM",
            Title = "РЕПО с ЦК с КСУ пл. 6 месяца - безадрес. (RUSFAR)",
            BoardGroupId = 1166,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 9 месяца - безадрес. (RUSFAR)
        /// </summary>
        public static readonly Board FCNM = new Board
        {
            Id = 1169,
            BoardId = "FCNM",
            Title = "РЕПО с ЦК с КСУ пл. 9 месяца - безадрес. (RUSFAR)",
            BoardGroupId = 1168,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 1 год - безадрес. (RUSFAR)
        /// </summary>
        public static readonly Board FCOY = new Board
        {
            Id = 1171,
            BoardId = "FCOY",
            Title = "РЕПО с ЦК с КСУ пл. 1 год - безадрес. (RUSFAR)",
            BoardGroupId = 1170,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 7 дней (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly Board FYOW = new Board
        {
            Id = 1189,
            BoardId = "FYOW",
            Title = "РЕПО с ЦК с КСУ пл. 7 дней (CNY) - безадрес. (RUSFARCNY)",
            BoardGroupId = 1188,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 14 дней (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly Board FYSW = new Board
        {
            Id = 1191,
            BoardId = "FYSW",
            Title = "РЕПО с ЦК с КСУ пл. 14 дней (CNY) - безадрес. (RUSFARCNY)",
            BoardGroupId = 1190,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 1 месяц (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly Board FYOM = new Board
        {
            Id = 1193,
            BoardId = "FYOM",
            Title = "РЕПО с ЦК с КСУ пл. 1 месяц (CNY) - безадрес. (RUSFARCNY)",
            BoardGroupId = 1192,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 2 месяца (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly Board FYSM = new Board
        {
            Id = 1195,
            BoardId = "FYSM",
            Title = "РЕПО с ЦК с КСУ пл. 2 месяца (CNY) - безадрес. (RUSFARCNY)",
            BoardGroupId = 1194,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 3 месяца (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly Board FYTM = new Board
        {
            Id = 1197,
            BoardId = "FYTM",
            Title = "РЕПО с ЦК с КСУ пл. 3 месяца (CNY) - безадрес. (RUSFARCNY)",
            BoardGroupId = 1196,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 6 месяца (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly Board FYUM = new Board
        {
            Id = 1199,
            BoardId = "FYUM",
            Title = "РЕПО с ЦК с КСУ пл. 6 месяца (CNY) - безадрес. (RUSFARCNY)",
            BoardGroupId = 1198,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 9 месяца (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly Board FYNM = new Board
        {
            Id = 1201,
            BoardId = "FYNM",
            Title = "РЕПО с ЦК с КСУ пл. 9 месяца (CNY) - безадрес. (RUSFARCNY)",
            BoardGroupId = 1200,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 1 год (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly Board FYOY = new Board
        {
            Id = 1203,
            BoardId = "FYOY",
            Title = "РЕПО с ЦК с КСУ пл. 1 год (CNY) - безадрес. (RUSFARCNY)",
            BoardGroupId = 1202,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. КлСт 1 мес. - безадрес. (RREFKEYR)
        /// </summary>
        public static readonly Board FAOM = new Board
        {
            Id = 1311,
            BoardId = "FAOM",
            Title = "РЕПО с ЦК с КСУ пл. КлСт 1 мес. - безадрес. (RREFKEYR)",
            BoardGroupId = 1312,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. КлСт 3 мес. - безадрес. (RREFKEYR)
        /// </summary>
        public static readonly Board FATM = new Board
        {
            Id = 1314,
            BoardId = "FATM",
            Title = "РЕПО с ЦК с КСУ пл. КлСт 3 мес. - безадрес. (RREFKEYR)",
            BoardGroupId = 1313,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Ин.Акции и ДР (HKD) - безадрес.
        /// </summary>
        public static readonly Board FQBH = new Board
        {
            Id = 1230,
            BoardId = "FQBH",
            Title = "Т+: Ин.Акции и ДР (HKD) - безадрес.",
            BoardGroupId = 1229,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Ин.Акции ПИР (HKD) - безадрес.
        /// </summary>
        public static readonly Board FQDH = new Board
        {
            Id = 1231,
            BoardId = "FQDH",
            Title = "Т+: Ин.Акции ПИР (HKD) - безадрес.",
            BoardGroupId = 1229,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+ Ин.Акции и ДР - безадрес.
        /// </summary>
        public static readonly Board FQBR = new Board
        {
            Id = 415,
            BoardId = "FQBR",
            Title = "Т+ Ин.Акции и ДР - безадрес.",
            BoardGroupId = 265,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+ Ин.Акции ПИР - безадрес.
        /// </summary>
        public static readonly Board FQDE = new Board
        {
            Id = 417,
            BoardId = "FQDE",
            Title = "Т+ Ин.Акции ПИР - безадрес.",
            BoardGroupId = 265,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Ин.Акции и ДР (USD) - безадрес.
        /// </summary>
        public static readonly Board TQBD = new Board
        {
            Id = 224,
            BoardId = "TQBD",
            Title = "Т+: Ин.Акции и ДР (USD) - безадрес.",
            BoardGroupId = 292,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Ин.Акции ПИР (USD) - безадрес.
        /// </summary>
        public static readonly Board TQDD = new Board
        {
            Id = 508,
            BoardId = "TQDD",
            Title = "Т+: Ин.Акции ПИР (USD) - безадрес.",
            BoardGroupId = 292,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Ин.Акции и ДР (CNY) - безадрес.
        /// </summary>
        public static readonly Board FQBY = new Board
        {
            Id = 1207,
            BoardId = "FQBY",
            Title = "Т+: Ин.Акции и ДР (CNY) - безадрес.",
            BoardGroupId = 1206,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Т+: Ин.Акции ПИР (CNY) - безадрес.
        /// </summary>
        public static readonly Board FQDY = new Board
        {
            Id = 1208,
            BoardId = "FQDY",
            Title = "Т+: Ин.Акции ПИР (CNY) - безадрес.",
            BoardGroupId = 1206,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции и ДР (HKD) - адрес.
        /// </summary>
        public static readonly Board FTSH = new Board
        {
            Id = 1233,
            BoardId = "FTSH",
            Title = "РПС с ЦК: Ин.Акции и ДР (HKD) - адрес.",
            BoardGroupId = 1232,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции ПИР (HKD) - адрес.
        /// </summary>
        public static readonly Board FTDH = new Board
        {
            Id = 1234,
            BoardId = "FTDH",
            Title = "РПС с ЦК: Ин.Акции ПИР (HKD) - адрес.",
            BoardGroupId = 1232,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Ин.Акции (HKD) - адрес.
        /// </summary>
        public static readonly Board FSSH = new Board
        {
            Id = 1236,
            BoardId = "FSSH",
            Title = "РПС: Ин.Акции (HKD) - адрес.",
            BoardGroupId = 1235,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Ин.Акции ПИР (HKD) - адрес.
        /// </summary>
        public static readonly Board FSDH = new Board
        {
            Id = 1237,
            BoardId = "FSDH",
            Title = "РПС: Ин.Акции ПИР (HKD) - адрес.",
            BoardGroupId = 1235,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции и ДР - адрес.
        /// </summary>
        public static readonly Board FTEQ = new Board
        {
            Id = 419,
            BoardId = "FTEQ",
            Title = "РПС с ЦК: Ин.Акции и ДР - адрес.",
            BoardGroupId = 267,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции ПИР - адрес.
        /// </summary>
        public static readonly Board FTDE = new Board
        {
            Id = 421,
            BoardId = "FTDE",
            Title = "РПС с ЦК: Ин.Акции ПИР - адрес.",
            BoardGroupId = 267,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Ин.Акции (USD) - адрес.
        /// </summary>
        public static readonly Board PSSD = new Board
        {
            Id = 510,
            BoardId = "PSSD",
            Title = "РПС: Ин.Акции (USD) - адрес.",
            BoardGroupId = 294,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Ин.Акции ПИР (USD) - адрес.
        /// </summary>
        public static readonly Board PSDD = new Board
        {
            Id = 509,
            BoardId = "PSDD",
            Title = "РПС: Ин.Акции ПИР (USD) - адрес.",
            BoardGroupId = 294,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции и ДР (CNY) - адрес.
        /// </summary>
        public static readonly Board FTSY = new Board
        {
            Id = 1210,
            BoardId = "FTSY",
            Title = "РПС с ЦК: Ин.Акции и ДР (CNY) - адрес.",
            BoardGroupId = 1209,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции ПИР (CNY) - адрес.
        /// </summary>
        public static readonly Board FTDY = new Board
        {
            Id = 1211,
            BoardId = "FTDY",
            Title = "РПС с ЦК: Ин.Акции ПИР (CNY) - адрес.",
            BoardGroupId = 1209,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Ин.Акции (CNY) - адрес.
        /// </summary>
        public static readonly Board FSSY = new Board
        {
            Id = 1213,
            BoardId = "FSSY",
            Title = "РПС: Ин.Акции (CNY) - адрес.",
            BoardGroupId = 1212,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Ин.Акции ПИР (CNY) - адрес.
        /// </summary>
        public static readonly Board FSDY = new Board
        {
            Id = 1214,
            BoardId = "FSDY",
            Title = "РПС: Ин.Акции ПИР (CNY) - адрес.",
            BoardGroupId = 1212,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС: Ин.Акции - адрес.
        /// </summary>
        public static readonly Board FSEQ = new Board
        {
            Id = 423,
            BoardId = "FSEQ",
            Title = "РПС: Ин.Акции - адрес.",
            BoardGroupId = 269,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Ин.Акции ПИР - РПС - адрес.
        /// </summary>
        public static readonly Board FSDE = new Board
        {
            Id = 425,
            BoardId = "FSDE",
            Title = "Ин.Акции ПИР - РПС - адрес.",
            BoardGroupId = 269,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции и ДР (USD) - адрес.
        /// </summary>
        public static readonly Board PTSD = new Board
        {
            Id = 230,
            BoardId = "PTSD",
            Title = "РПС с ЦК: Ин.Акции и ДР (USD) - адрес.",
            BoardGroupId = 293,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции ПИР (USD) - адрес.
        /// </summary>
        public static readonly Board PTDD = new Board
        {
            Id = 497,
            BoardId = "PTDD",
            Title = "РПС с ЦК: Ин.Акции ПИР (USD) - адрес.",
            BoardGroupId = 293,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Кредиты RUB - адрес.
        /// </summary>
        public static readonly Board CRER = new Board
        {
            Id = 491,
            BoardId = "CRER",
            Title = "Кредиты RUB - адрес.",
            BoardGroupId = 275,
            EngineId = 1,
            MarketId = 54,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Кредиты USD - адрес.
        /// </summary>
        public static readonly Board CREU = new Board
        {
            Id = 493,
            BoardId = "CREU",
            Title = "Кредиты USD - адрес.",
            BoardGroupId = 277,
            EngineId = 1,
            MarketId = 54,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Кредиты EUR - адрес.
        /// </summary>
        public static readonly Board CREE = new Board
        {
            Id = 495,
            BoardId = "CREE",
            Title = "Кредиты EUR - адрес.",
            BoardGroupId = 279,
            EngineId = 1,
            MarketId = 54,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Кредиты CNY - адрес.
        /// </summary>
        public static readonly Board CREY = new Board
        {
            Id = 1147,
            BoardId = "CREY",
            Title = "Кредиты CNY - адрес.",
            BoardGroupId = 1146,
            EngineId = 1,
            MarketId = 54,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Акции и ДР - адрес.
        /// </summary>
        public static readonly Board CTEQ = new Board
        {
            Id = 1057,
            BoardId = "CTEQ",
            Title = "РПС с ЦК Нерезиденты: Акции и ДР - адрес.",
            BoardGroupId = 1056,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Акции и ДР (USD) - адрес.
        /// </summary>
        public static readonly Board CTSD = new Board
        {
            Id = 1059,
            BoardId = "CTSD",
            Title = "РПС с ЦК Нерезиденты: Акции и ДР (USD) - адрес.",
            BoardGroupId = 1058,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Акции и ДР (EUR) - адрес.
        /// </summary>
        public static readonly Board CTSE = new Board
        {
            Id = 1061,
            BoardId = "CTSE",
            Title = "РПС с ЦК Нерезиденты: Акции и ДР (EUR) - адрес.",
            BoardGroupId = 1060,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Облигации - адрес.
        /// </summary>
        public static readonly Board CTOB = new Board
        {
            Id = 1063,
            BoardId = "CTOB",
            Title = "РПС с ЦК Нерезиденты: Облигации - адрес.",
            BoardGroupId = 1062,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Облигации (CNY) - адрес.
        /// </summary>
        public static readonly Board CTOY = new Board
        {
            Id = 1065,
            BoardId = "CTOY",
            Title = "РПС с ЦК Нерезиденты: Облигации (CNY) - адрес.",
            BoardGroupId = 1064,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Облигации (USD) - адрес.
        /// </summary>
        public static readonly Board CTOD = new Board
        {
            Id = 1067,
            BoardId = "CTOD",
            Title = "РПС с ЦК Нерезиденты: Облигации (USD) - адрес.",
            BoardGroupId = 1066,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Облигации (EUR) - адрес.
        /// </summary>
        public static readonly Board CTOE = new Board
        {
            Id = 1069,
            BoardId = "CTOE",
            Title = "РПС с ЦК Нерезиденты: Облигации (EUR) - адрес.",
            BoardGroupId = 1068,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО-M Нерезиденты - адрес.
        /// </summary>
        public static readonly Board CPMO = new Board
        {
            Id = 1072,
            BoardId = "CPMO",
            Title = "РЕПО-M Нерезиденты - адрес.",
            BoardGroupId = 1071,
            EngineId = 1,
            MarketId = 1017,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО-M Нерезиденты (USD) - адрес.
        /// </summary>
        public static readonly Board CPEU = new Board
        {
            Id = 1074,
            BoardId = "CPEU",
            Title = "РЕПО-M Нерезиденты (USD) - адрес.",
            BoardGroupId = 1073,
            EngineId = 1,
            MarketId = 1017,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО-M Нерезиденты (EUR) - адрес.
        /// </summary>
        public static readonly Board CPEO = new Board
        {
            Id = 1076,
            BoardId = "CPEO",
            Title = "РЕПО-M Нерезиденты (EUR) - адрес.",
            BoardGroupId = 1075,
            EngineId = 1,
            MarketId = 1017,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// РЕПО-M Нерезиденты (CNY) - адрес.
        /// </summary>
        public static readonly Board CPEY = new Board
        {
            Id = 1078,
            BoardId = "CPEY",
            Title = "РЕПО-M Нерезиденты (CNY) - адрес.",
            BoardGroupId = 1077,
            EngineId = 1,
            MarketId = 1017,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Урегулирование РЕПО с ЦК Нерезиденты - безадрес.
        /// </summary>
        public static readonly Board CIQR = new Board
        {
            Id = 1081,
            BoardId = "CIQR",
            Title = "Урегулирование РЕПО с ЦК Нерезиденты - безадрес.",
            BoardGroupId = 1080,
            EngineId = 1,
            MarketId = 1019,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// ГЦБ
        /// </summary>
        public static readonly Board MAIN = new Board
        {
            Id = 19,
            BoardId = "MAIN",
            Title = "ГЦБ",
            BoardGroupId = 10,
            EngineId = 2,
            MarketId = 6,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Сделки междилерского РЕПО
        /// </summary>
        public static readonly Board RPDD = new Board
        {
            Id = 25,
            BoardId = "RPDD",
            Title = "Сделки междилерского РЕПО",
            BoardGroupId = 3,
            EngineId = 2,
            MarketId = 7,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// ГЦБ: Внесистемные сделки
        /// </summary>
        public static readonly Board NEGD = new Board
        {
            Id = 20,
            BoardId = "NEGD",
            Title = "ГЦБ: Внесистемные сделки",
            BoardGroupId = 11,
            EngineId = 2,
            MarketId = 8,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Индексы ГЦБ
        /// </summary>
        public static readonly Board GNDX = new Board
        {
            Id = 51,
            BoardId = "GNDX",
            Title = "Индексы ГЦБ",
            BoardGroupId = 12,
            EngineId = 2,
            MarketId = 9,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Системные сделки - безадрес.
        /// </summary>
        public static readonly Board CETS = new Board
        {
            Id = 21,
            BoardId = "CETS",
            Title = "Системные сделки - безадрес.",
            BoardGroupId = 13,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Крупные сделки - безадрес.
        /// </summary>
        public static readonly Board SDBP = new Board
        {
            Id = 351,
            BoardId = "SDBP",
            Title = "Крупные сделки - безадрес.",
            BoardGroupId = 13,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Дневная сессия
        /// </summary>
        public static readonly Board CURR = new Board
        {
            Id = 52,
            BoardId = "CURR",
            Title = "Дневная сессия",
            BoardGroupId = 13,
            EngineId = 3,
            MarketId = 10,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Внесистемные сделки- адрес.
        /// </summary>
        public static readonly Board CNGD = new Board
        {
            Id = 116,
            BoardId = "CNGD",
            Title = "Внесистемные сделки- адрес.",
            BoardGroupId = 46,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Внесистемные сделки урегулирования - безадрес.
        /// </summary>
        public static readonly Board LICU = new Board
        {
            Id = 308,
            BoardId = "LICU",
            Title = "Внесистемные сделки урегулирования - безадрес.",
            BoardGroupId = 151,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Фиксинг системный - безадрес.
        /// </summary>
        public static readonly Board FIXS = new Board
        {
            Id = 261,
            BoardId = "FIXS",
            Title = "Фиксинг системный - безадрес.",
            BoardGroupId = 100,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Фиксинг внесистемный- адрес.
        /// </summary>
        public static readonly Board FIXN = new Board
        {
            Id = 262,
            BoardId = "FIXN",
            Title = "Фиксинг внесистемный- адрес.",
            BoardGroupId = 101,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Системные средневзвешенные - безадрес.
        /// </summary>
        public static readonly Board WAPS = new Board
        {
            Id = 306,
            BoardId = "WAPS",
            Title = "Системные средневзвешенные - безадрес.",
            BoardGroupId = 149,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Внесистемные средневзвешенные - адрес.
        /// </summary>
        public static readonly Board WAPN = new Board
        {
            Id = 307,
            BoardId = "WAPN",
            Title = "Внесистемные средневзвешенные - адрес.",
            BoardGroupId = 150,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Аукцион ЦБР - адрес.
        /// </summary>
        public static readonly Board AUCB = new Board
        {
            Id = 182,
            BoardId = "AUCB",
            Title = "Аукцион ЦБР - адрес.",
            BoardGroupId = 70,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Поставка - безадресные
        /// </summary>
        public static readonly Board SPEC = new Board
        {
            Id = 296,
            BoardId = "SPEC",
            Title = "Поставка - безадресные",
            BoardGroupId = 140,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Фьючерсы системные - безадрес.
        /// </summary>
        public static readonly Board FUTS = new Board
        {
            Id = 256,
            BoardId = "FUTS",
            Title = "Фьючерсы системные - безадрес.",
            BoardGroupId = 88,
            EngineId = 3,
            MarketId = 34,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Фьючерсы внесистемные- адрес.
        /// </summary>
        public static readonly Board FUTN = new Board
        {
            Id = 257,
            BoardId = "FUTN",
            Title = "Фьючерсы внесистемные- адрес.",
            BoardGroupId = 89,
            EngineId = 3,
            MarketId = 34,
            IsTraded = false,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Валютный фиксинг
        /// </summary>
        public static readonly Board FIXI = new Board
        {
            Id = 321,
            BoardId = "FIXI",
            Title = "Валютный фиксинг",
            BoardGroupId = 165,
            EngineId = 3,
            MarketId = 41,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Рынок OTC
        /// </summary>
        public static readonly Board OTCT = new Board
        {
            Id = 411,
            BoardId = "OTCT",
            Title = "Рынок OTC",
            BoardGroupId = 261,
            EngineId = 3,
            MarketId = 45,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Рынок OTC крупные сделки
        /// </summary>
        public static readonly Board OTCF = new Board
        {
            Id = 413,
            BoardId = "OTCF",
            Title = "Рынок OTC крупные сделки",
            BoardGroupId = 263,
            EngineId = 3,
            MarketId = 45,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = false,
        };


        /// <summary>
        /// Фьючерсы и Опционы
        /// </summary>
        public static readonly Board FOB = new Board
        {
            Id = 22,
            BoardId = "FOB",
            Title = "Фьючерсы и Опционы",
            BoardGroupId = 15,
            EngineId = 4,
            MarketId = 12,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Фьючерсы
        /// </summary>
        public static readonly Board RFUD = new Board
        {
            Id = 101,
            BoardId = "RFUD",
            Title = "Фьючерсы",
            BoardGroupId = 45,
            EngineId = 4,
            MarketId = 22,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Опционы
        /// </summary>
        public static readonly Board ROPD = new Board
        {
            Id = 103,
            BoardId = "ROPD",
            Title = "Опционы",
            BoardGroupId = 35,
            EngineId = 4,
            MarketId = 24,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Фьючерсы IQS
        /// </summary>
        public static readonly Board FIQS = new Board
        {
            Id = 294,
            BoardId = "FIQS",
            Title = "Фьючерсы IQS",
            BoardGroupId = 138,
            EngineId = 4,
            MarketId = 37,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Опционы IQS
        /// </summary>
        public static readonly Board OIQS = new Board
        {
            Id = 295,
            BoardId = "OIQS",
            Title = "Опционы IQS",
            BoardGroupId = 139,
            EngineId = 4,
            MarketId = 38,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Фьючерсы на товарные активы
        /// </summary>
        public static readonly Board FOCM = new Board
        {
            Id = 80,
            BoardId = "FOCM",
            Title = "Фьючерсы на товарные активы",
            BoardGroupId = 20,
            EngineId = 5,
            MarketId = 18,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Интервенции по продаже зерна
        /// </summary>
        public static readonly Board GSEL = new Board
        {
            Id = 94,
            BoardId = "GSEL",
            Title = "Интервенции по продаже зерна",
            BoardGroupId = 24,
            EngineId = 6,
            MarketId = 20,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// ОТС-система: облигации
        /// </summary>
        public static readonly Board OBBO = new Board
        {
            Id = 297,
            BoardId = "OBBO",
            Title = "ОТС-система: облигации",
            BoardGroupId = 141,
            EngineId = 7,
            MarketId = 39,
            IsTraded = false,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Агро: Сахар
        /// </summary>
        public static readonly Board SUGR = new Board
        {
            Id = 427,
            BoardId = "SUGR",
            Title = "Агро: Сахар",
            BoardGroupId = 271,
            EngineId = 9,
            MarketId = 51,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// Агро: Аукционы НТБ
        /// </summary>
        public static readonly Board AIGR = new Board
        {
            Id = 1036,
            BoardId = "AIGR",
            Title = "Агро: Аукционы НТБ",
            BoardGroupId = 1032,
            EngineId = 9,
            MarketId = 1031,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// Агро: Закупочные аукционы НТБ
        /// </summary>
        public static readonly Board ABGR = new Board
        {
            Id = 1090,
            BoardId = "ABGR",
            Title = "Агро: Закупочные аукционы НТБ",
            BoardGroupId = 1085,
            EngineId = 9,
            MarketId = 1084,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


        /// <summary>
        /// ОТС: Облигации Т+ - безадресные
        /// </summary>
        public static readonly Board OCTR = new Board
        {
            Id = 1022,
            BoardId = "OCTR",
            Title = "ОТС: Облигации Т+ - безадресные",
            BoardGroupId = 1021,
            EngineId = 1012,
            MarketId = 1013,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// ОТС: Облигации Т+ (USD) - безадресные
        /// </summary>
        public static readonly Board OCTU = new Board
        {
            Id = 1016,
            BoardId = "OCTU",
            Title = "ОТС: Облигации Т+ (USD) - безадресные",
            BoardGroupId = 1015,
            EngineId = 1012,
            MarketId = 1013,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// OTC: Облигации с ЦК - двусторонние
        /// </summary>
        public static readonly Board OCBR = new Board
        {
            Id = 1018,
            BoardId = "OCBR",
            Title = "OTC: Облигации с ЦК - двусторонние",
            BoardGroupId = 1017,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// OTC: Облигации с ЦК (CNY) - двусторонние
        /// </summary>
        public static readonly Board OCBY = new Board
        {
            Id = 1205,
            BoardId = "OCBY",
            Title = "OTC: Облигации с ЦК (CNY) - двусторонние",
            BoardGroupId = 1204,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// OTC: Облигации с ЦК (USD) - двусторонние
        /// </summary>
        public static readonly Board OCBU = new Board
        {
            Id = 1020,
            BoardId = "OCBU",
            Title = "OTC: Облигации с ЦК (USD) - двусторонние",
            BoardGroupId = 1019,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// OTC: Облигации с ЦК адрес. - двусторонние
        /// </summary>
        public static readonly Board OCAR = new Board
        {
            Id = 1264,
            BoardId = "OCAR",
            Title = "OTC: Облигации с ЦК адрес. - двусторонние",
            BoardGroupId = 1263,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// OTC: Облигации с ЦК адрес. (CNY) - двусторонние
        /// </summary>
        public static readonly Board OCAY = new Board
        {
            Id = 1266,
            BoardId = "OCAY",
            Title = "OTC: Облигации с ЦК адрес. (CNY) - двусторонние",
            BoardGroupId = 1265,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// OTC: Облигации с ЦК адрес. (USD) - двусторонние
        /// </summary>
        public static readonly Board OCAU = new Board
        {
            Id = 1268,
            BoardId = "OCAU",
            Title = "OTC: Облигации с ЦК адрес. (USD) - двусторонние",
            BoardGroupId = 1267,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// ОТС: Акции Т+ - безадресные
        /// </summary>
        public static readonly Board MTQR = new Board
        {
            Id = 1259,
            BoardId = "MTQR",
            Title = "ОТС: Акции Т+ - безадресные",
            BoardGroupId = 1258,
            EngineId = 1012,
            MarketId = 1257,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// ОТС: Акции РПС с ЦК - адресные
        /// </summary>
        public static readonly Board MPTR = new Board
        {
            Id = 1261,
            BoardId = "MPTR",
            Title = "ОТС: Акции РПС с ЦК - адресные",
            BoardGroupId = 1260,
            EngineId = 1012,
            MarketId = 1262,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = true,
        };


        /// <summary>
        /// OTC Размещение: Адресный
        /// </summary>
        public static readonly Board MPAU = new Board
        {
            Id = 1304,
            BoardId = "MPAU",
            Title = "OTC Размещение: Адресный",
            BoardGroupId = 1303,
            EngineId = 1012,
            MarketId = 1262,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// OTC Выкуп: Адресный
        /// </summary>
        public static readonly Board MPBB = new Board
        {
            Id = 1306,
            BoardId = "MPBB",
            Title = "OTC Выкуп: Адресный",
            BoardGroupId = 1305,
            EngineId = 1012,
            MarketId = 1262,
            IsTraded = true,
            IsPrimary = false,
            HasCandles = true,
        };


        /// <summary>
        /// Квоты
        /// </summary>
        public static readonly Board QBND = new Board
        {
            Id = 1281,
            BoardId = "QBND",
            Title = "Квоты",
            BoardGroupId = 1280,
            EngineId = 1282,
            MarketId = 1279,
            IsTraded = true,
            IsPrimary = true,
            HasCandles = false,
        };


     
        public static Board[] All = new Board[] { TQIF, TQTF, TQBR, TQBS, TQNL, TQLV, TQLI, TQNE, TQDE, TQPI, TQTD, TQFD, TQPD, EQBR, EQBS, EQNL, EQLV, EQDE, EQLI, EQNE, SPEQ, SMAL, TQDP, EQDP, EQTD, TQBE, TQTE, TQFE, TQPE, TQTY, TQPY, EQTU, TQTH, TQPH, EQCC, TQOB, TQOS, TQNO, TQOV, TQNB, TQUS, TQCB, TQRD, TQIR, TQOD, TQUD, TQIU, TQTC, EQOB, EQOS, EQNO, EQOV, EQDB, EQNB, EQUS, EQEO, SPOB, EQTC, EQEU, EQGO, EQYO, AUBB, AUCT, TQDB, TQOE, TQED, TQIE, TQDU, TQOY, TQIY, PACT, RPMO, RPEQ, RPMA, RPEU, RPUA, RPUO, RPEO, RPEY, RPGO, RPCC, PTEU, PTIF, PTTC, PTTF, PTEQ, PTES, PTNL, PTLV, PTLI, PTNE, PTNO, PTUS, PTDE, PTPI, PSTD, PSFD, PSPD, PSIF, PSTC, PSTF, PSEQ, PSES, PSNL, PSLV, PSDE, PSLI, PSNE, PSOS, PSNO, PSOV, PSNB, PSUS, PSPI, PSGO, PSAU, PAUS, PAEU, PACY, PAGB, PSBB, PSBE, OTCB, OTCU, OTCE, PTTD, PTFD, PTPD, PSBU, PSBY, PTOE, PTED, PTIE, PSSE, PSTE, PSFE, PSPE, PTSE, PTTE, PTFE, PTPE, PTOB, PTOS, PTOV, PTNB, PTDB, PTIR, PTOD, PTUD, PTIU, PSOB, PSDB, PSIR, PSEU, PSUD, PSIU, PSEO, PSED, PSIE, PSYO, PSIY, PTIY, PTOY, PSTY, PSPY, PTTY, PTPY, PSTH, PSPH, PTTH, PTPH, PSCC, SNDX, RTSI, INAV, MMIX, AGRO, INPF, SDII, STMR, SDMR, STAD, SDAD, STRP, SDRP, CLMR, CLAD, EQRD, EQRE, EQWP, EQWD, EQWE, EQRP, EQMP, EQMD, EQME, EQTP, ETQD, EQTE, LIQR, EQRY, PSRY, EQWY, EQMY, EQTY, PSRP, PSRD, PSRE, FKRP, FKOW, FKSW, FKFW, FKOM, FKSM, FKTM, FKUM, FKOY, FRRP, FROW, FRSW, FRFW, FROM, FRTM, FSRP, FSOW, FSSW, FSOM, FSFW, TQQI, EQQI, PSQI, PTQI, RPQI, RPUQ, TQQD, SOTC, MXBD, TDEP, NDEP, NDPU, NDPE, TDPU, TDPE, TDPY, NDPY, ADEP, LIQB, CIQB, GCRP, GCOW, GCSW, GCOM, GCSM, GCTM, GCUM, GCOY, PSGC, GURP, GUOW, GUSW, GUOM, GUSM, GUTM, GUUM, GUOY, PUGC, GERP, GEOW, GESW, GEOM, GESM, GETM, GEUM, GEOY, PEGC, GCNM, GUNM, GENM, GYRP, GYOW, GYSW, GYOM, GYSM, GYTM, GYUM, GYNM, GYOY, PYGC, FCOW, FCSW, FCOM, FCSM, FCTM, FCUM, FCNM, FCOY, FYOW, FYSW, FYOM, FYSM, FYTM, FYUM, FYNM, FYOY, FAOM, FATM, FQBH, FQDH, FQBR, FQDE, TQBD, TQDD, FQBY, FQDY, FTSH, FTDH, FSSH, FSDH, FTEQ, FTDE, PSSD, PSDD, FTSY, FTDY, FSSY, FSDY, FSEQ, FSDE, PTSD, PTDD, CRER, CREU, CREE, CREY, CTEQ, CTSD, CTSE, CTOB, CTOY, CTOD, CTOE, CPMO, CPEU, CPEO, CPEY, CIQR, MAIN, RPDD, NEGD, GNDX, CETS, SDBP, CURR, CNGD, LICU, FIXS, FIXN, WAPS, WAPN, AUCB, SPEC, FUTS, FUTN, FIXI, OTCT, OTCF, FOB, RFUD, ROPD, FIQS, OIQS, FOCM, GSEL, OBBO, SUGR, AIGR, ABGR, OCTR, OCTU, OCBR, OCBY, OCBU, OCAR, OCAY, OCAU, MTQR, MPTR, MPAU, MPBB, QBND,  };


    }
}