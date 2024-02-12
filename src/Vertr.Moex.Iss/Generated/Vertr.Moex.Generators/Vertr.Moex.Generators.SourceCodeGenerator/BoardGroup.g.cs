namespace Vertr.Moex.Iss.Entities
{
    public partial class BoardGroup
    {
    
        /// <summary>
        /// Индексы
        /// </summary>
        public static readonly BoardGroup Stock_Index = new BoardGroup
        {
            Id = 9,
            Title = "Индексы",
            Name = "stock_index",
            BoardGroupId = 9,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// INAV
        /// </summary>
        public static readonly BoardGroup Stock_Index_Inav = new BoardGroup
        {
            Id = 104,
            Title = "INAV",
            Name = "stock_index_inav",
            BoardGroupId = 104,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Money Market IndeX
        /// </summary>
        public static readonly BoardGroup Stock_Index_Mmix = new BoardGroup
        {
            Id = 155,
            Title = "Money Market IndeX",
            Name = "stock_index_mmix",
            BoardGroupId = 155,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Индексы НТБ
        /// </summary>
        public static readonly BoardGroup Stock_Index_Namex = new BoardGroup
        {
            Id = 1028,
            Title = "Индексы НТБ",
            Name = "stock_index_namex",
            BoardGroupId = 1028,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Ценовой фиксинг
        /// </summary>
        public static readonly BoardGroup Stock_Index_Pf = new BoardGroup
        {
            Id = 1153,
            Title = "Ценовой фиксинг",
            Name = "stock_index_pf",
            BoardGroupId = 1153,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Индексы СПФИ
        /// </summary>
        public static readonly BoardGroup Stock_Index_Sdfi = new BoardGroup
        {
            Id = 287,
            Title = "Индексы СПФИ",
            Name = "stock_index_sdfi",
            BoardGroupId = 287,
            EngineId = 1,
            MarketId = 5,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Т+: Основной режим - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Tplus = new BoardGroup
        {
            Id = 57,
            Title = "Т+: Основной режим - безадрес.",
            Name = "stock_shares_tplus",
            BoardGroupId = 57,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Основной режим (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Tplus_Usd = new BoardGroup
        {
            Id = 156,
            Title = "Т+: Основной режим (USD) - безадрес.",
            Name = "stock_shares_tplus_usd",
            BoardGroupId = 156,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т0: Основной режим - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares = new BoardGroup
        {
            Id = 6,
            Title = "Т0: Основной режим - безадрес.",
            Name = "stock_shares",
            BoardGroupId = 6,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Поставка по СК
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Settle = new BoardGroup
        {
            Id = 125,
            Title = "Поставка по СК",
            Name = "stock_shares_settle",
            BoardGroupId = 125,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Неполные лоты - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Sm = new BoardGroup
        {
            Id = 21,
            Title = "Неполные лоты - безадрес.",
            Name = "stock_shares_sm",
            BoardGroupId = 21,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Крупные пакеты - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Darkpool = new BoardGroup
        {
            Id = 42,
            Title = "Крупные пакеты - безадрес.",
            Name = "stock_shares_darkpool",
            BoardGroupId = 42,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т0 ETF (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Etf_Usd = new BoardGroup
        {
            Id = 99,
            Title = "Т0 ETF (USD) - безадрес.",
            Name = "stock_etf_usd",
            BoardGroupId = 99,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Основной режим (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Tplus_Eur = new BoardGroup
        {
            Id = 157,
            Title = "Т+: Основной режим (EUR) - безадрес.",
            Name = "stock_shares_tplus_eur",
            BoardGroupId = 157,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Основной режим (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Tplus_Cny = new BoardGroup
        {
            Id = 1215,
            Title = "Т+: Основной режим (CNY) - безадрес.",
            Name = "stock_shares_tplus_cny",
            BoardGroupId = 1215,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т0 ETF (расч. в EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Etf_Eur = new BoardGroup
        {
            Id = 159,
            Title = "Т0 ETF (расч. в EUR) - безадрес.",
            Name = "stock_shares_etf_eur",
            BoardGroupId = 159,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: ПАИ (HKD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Tplus_Hkd = new BoardGroup
        {
            Id = 1238,
            Title = "Т+: ПАИ (HKD) - безадрес.",
            Name = "stock_shares_tplus_hkd",
            BoardGroupId = 1238,
            EngineId = 1,
            MarketId = 1,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// ЦК - Режим основных торгов - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Cc = new BoardGroup
        {
            Id = 30,
            Title = "ЦК - Режим основных торгов - безадрес.",
            Name = "stock_shares_cc",
            BoardGroupId = 30,
            EngineId = 1,
            MarketId = 1,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Основной режим - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Tplus = new BoardGroup
        {
            Id = 58,
            Title = "Т+: Основной режим - безадрес.",
            Name = "stock_bonds_tplus",
            BoardGroupId = 58,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Основной режим (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Tplus_Usd = new BoardGroup
        {
            Id = 193,
            Title = "Т+: Основной режим (USD) - безадрес.",
            Name = "stock_bonds_tplus_usd",
            BoardGroupId = 193,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Основной режим (ЕТС) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Etc_Tplus = new BoardGroup
        {
            Id = 68,
            Title = "Т+: Основной режим (ЕТС) - безадрес.",
            Name = "stock_etc_tplus",
            BoardGroupId = 68,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т0: Основной режим - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds = new BoardGroup
        {
            Id = 7,
            Title = "Т0: Основной режим - безадрес.",
            Name = "stock_bonds",
            BoardGroupId = 7,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Поставка по СК
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Settle = new BoardGroup
        {
            Id = 105,
            Title = "Поставка по СК",
            Name = "stock_bonds_settle",
            BoardGroupId = 105,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Т0: Основной режим (ЕТС) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Etc = new BoardGroup
        {
            Id = 69,
            Title = "Т0: Основной режим (ЕТС) - безадрес.",
            Name = "stock_etc",
            BoardGroupId = 69,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т0: Основной режим (Еврооблигации) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Euro = new BoardGroup
        {
            Id = 67,
            Title = "Т0: Основной режим (Еврооблигации) - безадрес.",
            Name = "stock_bonds_euro",
            BoardGroupId = 67,
            EngineId = 1,
            MarketId = 2,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Выкуп - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Buyback = new BoardGroup
        {
            Id = 122,
            Title = "Выкуп - безадрес.",
            Name = "stock_bonds_buyback",
            BoardGroupId = 122,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Размещение - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Distribution = new BoardGroup
        {
            Id = 123,
            Title = "Размещение - безадрес.",
            Name = "stock_bonds_distribution",
            BoardGroupId = 123,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Крупные пакеты - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Darkpools = new BoardGroup
        {
            Id = 77,
            Title = "Крупные пакеты - безадрес.",
            Name = "stock_bonds_darkpools",
            BoardGroupId = 77,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Облигации (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Tplus_Eur = new BoardGroup
        {
            Id = 207,
            Title = "Т+: Облигации (EUR) - безадрес.",
            Name = "stock_bonds_tplus_eur",
            BoardGroupId = 207,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Крупные пакеты – Облигации (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Darkpools_Usd = new BoardGroup
        {
            Id = 167,
            Title = "Крупные пакеты – Облигации (USD) - безадрес.",
            Name = "stock_bonds_darkpools_usd",
            BoardGroupId = 167,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Облигации (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Tplus_Cny = new BoardGroup
        {
            Id = 245,
            Title = "Т+: Облигации (CNY) - безадрес.",
            Name = "stock_bonds_tplus_cny",
            BoardGroupId = 245,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион: адресные заявки
        /// </summary>
        public static readonly BoardGroup Stock_Bonds_Auct_Pact = new BoardGroup
        {
            Id = 257,
            Title = "Аукцион: адресные заявки",
            Name = "stock_bonds_auct_pact",
            BoardGroupId = 257,
            EngineId = 1,
            MarketId = 2,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Т+: РПС с ЦК - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Tplus = new BoardGroup
        {
            Id = 59,
            Title = "Т+: РПС с ЦК - адрес.",
            Name = "stock_ndm_tplus",
            BoardGroupId = 59,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Usd = new BoardGroup
        {
            Id = 74,
            Title = "РПС (USD) - адрес.",
            Name = "stock_ndm_usd",
            BoardGroupId = 74,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm = new BoardGroup
        {
            Id = 8,
            Title = "РПС - адрес.",
            Name = "stock_ndm",
            BoardGroupId = 8,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС: В валюте - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Currency = new BoardGroup
        {
            Id = 106,
            Title = "РПС: В валюте - адрес.",
            Name = "stock_ndm_currency",
            BoardGroupId = 106,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Размещение - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Issuance = new BoardGroup
        {
            Id = 107,
            Title = "Размещение - адрес.",
            Name = "stock_ndm_issuance",
            BoardGroupId = 107,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Выкуп - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Buyback = new BoardGroup
        {
            Id = 108,
            Title = "Выкуп - адрес.",
            Name = "stock_ndm_buyback",
            BoardGroupId = 108,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Выкуп (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Buyback_Eur = new BoardGroup
        {
            Id = 121,
            Title = "Выкуп (EUR) - адрес.",
            Name = "stock_ndm_buyback_eur",
            BoardGroupId = 121,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Анонимный РПС - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Anonymous = new BoardGroup
        {
            Id = 126,
            Title = "Анонимный РПС - адрес.",
            Name = "stock_ndm_anonymous",
            BoardGroupId = 126,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Анонимный РПС (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Anonymous_Usd = new BoardGroup
        {
            Id = 203,
            Title = "Анонимный РПС (USD) - адрес.",
            Name = "stock_ndm_anonymous_usd",
            BoardGroupId = 203,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Анонимный РПС (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Anonymous_Eur = new BoardGroup
        {
            Id = 205,
            Title = "Анонимный РПС (EUR) - адрес.",
            Name = "stock_ndm_anonymous_eur",
            BoardGroupId = 205,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Т+: РПС с ЦК (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Tplus_Usd = new BoardGroup
        {
            Id = 73,
            Title = "Т+: РПС с ЦК (USD) - адрес.",
            Name = "stock_ndm_tplus_usd",
            BoardGroupId = 73,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Выкуп (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Buyback_Usd = new BoardGroup
        {
            Id = 124,
            Title = "Выкуп (USD) - адрес.",
            Name = "stock_ndm_buyback_usd",
            BoardGroupId = 124,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Выкуп (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Buyback_Cny = new BoardGroup
        {
            Id = 1289,
            Title = "Выкуп (CNY) - адрес.",
            Name = "stock_ndm_buyback_cny",
            BoardGroupId = 1289,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК: Облигации (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Ccp_Bonds_Eur   = new BoardGroup
        {
            Id = 209,
            Title = "РПС с ЦК: Облигации (EUR) - адрес.",
            Name = "stock_ndm_ccp_bonds_eur  ",
            BoardGroupId = 209,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Eur = new BoardGroup
        {
            Id = 160,
            Title = "РПС (EUR) - адрес.",
            Name = "stock_ndm_eur",
            BoardGroupId = 160,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Т+: РПС с ЦК (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Tplus_Eur = new BoardGroup
        {
            Id = 163,
            Title = "Т+: РПС с ЦК (EUR) - адрес.",
            Name = "stock_ndm_tplus_eur",
            BoardGroupId = 163,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК: Облигации - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Ccp_Bonds = new BoardGroup
        {
            Id = 282,
            Title = "РПС с ЦК: Облигации - адрес.",
            Name = "stock_ndm_ccp_bonds",
            BoardGroupId = 282,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК: Облигации (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Ccp_Bonds_Usd = new BoardGroup
        {
            Id = 283,
            Title = "РПС с ЦК: Облигации (USD) - адрес.",
            Name = "stock_ndm_ccp_bonds_usd",
            BoardGroupId = 283,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС: Облигации - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Bonds = new BoardGroup
        {
            Id = 284,
            Title = "РПС: Облигации - адрес.",
            Name = "stock_ndm_bonds",
            BoardGroupId = 284,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС: Облигации (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Bonds_Usd = new BoardGroup
        {
            Id = 285,
            Title = "РПС: Облигации (USD) - адрес.",
            Name = "stock_ndm_bonds_usd",
            BoardGroupId = 285,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС: Облигации (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Bonds_Eur = new BoardGroup
        {
            Id = 286,
            Title = "РПС: Облигации (EUR) - адрес.",
            Name = "stock_ndm_bonds_eur",
            BoardGroupId = 286,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС: Облигации (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Bonds_Cny = new BoardGroup
        {
            Id = 247,
            Title = "РПС: Облигации (CNY) - адрес.",
            Name = "stock_ndm_bonds_cny",
            BoardGroupId = 247,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК: Облигации (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Ccp_Bonds_Cny = new BoardGroup
        {
            Id = 249,
            Title = "РПС с ЦК: Облигации (CNY) - адрес.",
            Name = "stock_ndm_ccp_bonds_cny",
            BoardGroupId = 249,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Cny = new BoardGroup
        {
            Id = 1218,
            Title = "РПС (CNY) - адрес.",
            Name = "stock_ndm_cny",
            BoardGroupId = 1218,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: РПС с ЦК (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Tplus_Cny = new BoardGroup
        {
            Id = 1221,
            Title = "Т+: РПС с ЦК (CNY) - адрес.",
            Name = "stock_ndm_tplus_cny",
            BoardGroupId = 1221,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РПС: ПАИ (HKD) - адресн.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Hkd = new BoardGroup
        {
            Id = 1241,
            Title = "РПС: ПАИ (HKD) - адресн.",
            Name = "stock_ndm_hkd",
            BoardGroupId = 1241,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК: Паи (HKD) - адресн.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Tplus_Hkd = new BoardGroup
        {
            Id = 1244,
            Title = "РПС с ЦК: Паи (HKD) - адресн.",
            Name = "stock_ndm_tplus_hkd",
            BoardGroupId = 1244,
            EngineId = 1,
            MarketId = 4,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// ЦК - РПС - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ndm_Cc = new BoardGroup
        {
            Id = 32,
            Title = "ЦК - РПС - адрес.",
            Name = "stock_ndm_cc",
            BoardGroupId = 32,
            EngineId = 1,
            MarketId = 4,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Репортинг внебиржевых сделок (6264-У)
        /// </summary>
        public static readonly BoardGroup Stock_Otc = new BoardGroup
        {
            Id = 71,
            Title = "Репортинг внебиржевых сделок (6264-У)",
            Name = "stock_otc",
            BoardGroupId = 71,
            EngineId = 1,
            MarketId = 29,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// РЕПО с ЦК 1 день (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_D_Usd = new BoardGroup
        {
            Id = 92,
            Title = "РЕПО с ЦК 1 день (USD) - безадрес.",
            Name = "stock_ccp_d_usd",
            BoardGroupId = 92,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 1 день (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_D_Eur = new BoardGroup
        {
            Id = 93,
            Title = "РЕПО с ЦК 1 день (EUR) - безадрес.",
            Name = "stock_ccp_d_eur",
            BoardGroupId = 93,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 7 дней (RUB) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_W = new BoardGroup
        {
            Id = 76,
            Title = "РЕПО с ЦК 7 дней (RUB) - безадрес.",
            Name = "stock_ccp_w",
            BoardGroupId = 76,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 7 дней (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_W_Usd = new BoardGroup
        {
            Id = 78,
            Title = "РЕПО с ЦК 7 дней (USD) - безадрес.",
            Name = "stock_ccp_w_usd",
            BoardGroupId = 78,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 7 дней (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_W_Eur = new BoardGroup
        {
            Id = 79,
            Title = "РЕПО с ЦК 7 дней (EUR) - безадрес.",
            Name = "stock_ccp_w_eur",
            BoardGroupId = 79,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 1 день (RUB) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp = new BoardGroup
        {
            Id = 50,
            Title = "РЕПО с ЦК 1 день (RUB) - безадрес.",
            Name = "stock_ccp",
            BoardGroupId = 50,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 1 мес.(RUB) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_M = new BoardGroup
        {
            Id = 142,
            Title = "РЕПО с ЦК 1 мес.(RUB) - безадрес.",
            Name = "stock_ccp_m",
            BoardGroupId = 142,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 1 мес. (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_M_Usd = new BoardGroup
        {
            Id = 143,
            Title = "РЕПО с ЦК 1 мес. (USD) - безадрес.",
            Name = "stock_ccp_m_usd",
            BoardGroupId = 143,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 1 мес. (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_M_Eur = new BoardGroup
        {
            Id = 144,
            Title = "РЕПО с ЦК 1 мес. (EUR) - безадрес.",
            Name = "stock_ccp_m_eur",
            BoardGroupId = 144,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 3 мес. (RUB) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_3M = new BoardGroup
        {
            Id = 145,
            Title = "РЕПО с ЦК 3 мес. (RUB) - безадрес.",
            Name = "stock_ccp_3m",
            BoardGroupId = 145,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 3 мес. (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_3M_Usd = new BoardGroup
        {
            Id = 146,
            Title = "РЕПО с ЦК 3 мес. (USD) - безадрес.",
            Name = "stock_ccp_3m_usd",
            BoardGroupId = 146,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 3 мес. (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_3M_Eur = new BoardGroup
        {
            Id = 147,
            Title = "РЕПО с ЦК 3 мес. (EUR) - безадрес.",
            Name = "stock_ccp_3m_eur",
            BoardGroupId = 147,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК: Урегулирование - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Liq = new BoardGroup
        {
            Id = 148,
            Title = "РЕПО с ЦК: Урегулирование - безадрес.",
            Name = "stock_ccp_liq",
            BoardGroupId = 148,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 1 день (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_D_Cny = new BoardGroup
        {
            Id = 152,
            Title = "РЕПО с ЦК 1 день (CNY) - безадрес.",
            Name = "stock_ccp_d_cny",
            BoardGroupId = 152,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Ndm_Cny = new BoardGroup
        {
            Id = 153,
            Title = "РЕПО с ЦК (CNY) - адрес.",
            Name = "stock_ccp_ndm_cny",
            BoardGroupId = 153,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 7 дней (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_W_Cny = new BoardGroup
        {
            Id = 1116,
            Title = "РЕПО с ЦК 7 дней (CNY) - безадрес.",
            Name = "stock_ccp_w_cny",
            BoardGroupId = 1116,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 1 мес. (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_1M_Cny = new BoardGroup
        {
            Id = 1118,
            Title = "РЕПО с ЦК 1 мес. (CNY) - безадрес.",
            Name = "stock_ccp_1m_cny",
            BoardGroupId = 1118,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК 3 мес. (CNY) - безадрес
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_3M_Cny = new BoardGroup
        {
            Id = 1120,
            Title = "РЕПО с ЦК 3 мес. (CNY) - безадрес",
            Name = "stock_ccp_3m_cny",
            BoardGroupId = 1120,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК (RUB) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Ndm = new BoardGroup
        {
            Id = 65,
            Title = "РЕПО с ЦК (RUB) - адрес.",
            Name = "stock_ccp_ndm",
            BoardGroupId = 65,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Ndm_Usd = new BoardGroup
        {
            Id = 91,
            Title = "РЕПО с ЦК (USD) - адрес.",
            Name = "stock_ccp_ndm_usd",
            BoardGroupId = 91,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Ndm_Eur = new BoardGroup
        {
            Id = 96,
            Title = "РЕПО с ЦК (EUR) - адрес.",
            Name = "stock_ccp_ndm_eur",
            BoardGroupId = 96,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Аукцион с ЦК 1 день - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fk_D = new BoardGroup
        {
            Id = 169,
            Title = "Аукцион с ЦК 1 день - безадрес.",
            Name = "stock_ccp_fk_d",
            BoardGroupId = 169,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион с ЦК 1 неделя - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fk_2 = new BoardGroup
        {
            Id = 171,
            Title = "Аукцион с ЦК 1 неделя - безадрес.",
            Name = "stock_ccp_fk_2",
            BoardGroupId = 171,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион с ЦК 2 недели - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fk_2W = new BoardGroup
        {
            Id = 173,
            Title = "Аукцион с ЦК 2 недели - безадрес.",
            Name = "stock_ccp_fk_2w",
            BoardGroupId = 173,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион с ЦК 5 недель - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fk_5W = new BoardGroup
        {
            Id = 281,
            Title = "Аукцион с ЦК 5 недель - безадрес.",
            Name = "stock_ccp_fk_5w",
            BoardGroupId = 281,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион с ЦК 1 месяц - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fk_M = new BoardGroup
        {
            Id = 175,
            Title = "Аукцион с ЦК 1 месяц - безадрес.",
            Name = "stock_ccp_fk_m",
            BoardGroupId = 175,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион с ЦК 2 месяца - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fk_2M = new BoardGroup
        {
            Id = 177,
            Title = "Аукцион с ЦК 2 месяца - безадрес.",
            Name = "stock_ccp_fk_2m",
            BoardGroupId = 177,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион с ЦК 3 месяца - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fk_3M = new BoardGroup
        {
            Id = 179,
            Title = "Аукцион с ЦК 3 месяца - безадрес.",
            Name = "stock_ccp_fk_3m",
            BoardGroupId = 179,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион с ЦК 6 месяцев - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fk_6 = new BoardGroup
        {
            Id = 181,
            Title = "Аукцион с ЦК 6 месяцев - безадрес.",
            Name = "stock_ccp_fk_6",
            BoardGroupId = 181,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион с ЦК 1 год - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fk_1Y = new BoardGroup
        {
            Id = 183,
            Title = "Аукцион с ЦК 1 год - безадрес.",
            Name = "stock_ccp_fk_1y",
            BoardGroupId = 183,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 1 день - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fr_Repo_1D = new BoardGroup
        {
            Id = 288,
            Title = "Аукцион РЕПО с ЦК 1 день - безадрес.",
            Name = "stock_ccp_fr_repo_1d",
            BoardGroupId = 288,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 1 неделя - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fr_Repo_1W = new BoardGroup
        {
            Id = 289,
            Title = "Аукцион РЕПО с ЦК 1 неделя - безадрес.",
            Name = "stock_ccp_fr_repo_1w",
            BoardGroupId = 289,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 2 недели - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fr_Repo_2W = new BoardGroup
        {
            Id = 296,
            Title = "Аукцион РЕПО с ЦК 2 недели - безадрес.",
            Name = "stock_ccp_fr_repo_2w",
            BoardGroupId = 296,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 5 недель - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fr_Repo_5W = new BoardGroup
        {
            Id = 297,
            Title = "Аукцион РЕПО с ЦК 5 недель - безадрес.",
            Name = "stock_ccp_fr_repo_5w",
            BoardGroupId = 297,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 1 месяц - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fr_Repo_1M = new BoardGroup
        {
            Id = 290,
            Title = "Аукцион РЕПО с ЦК 1 месяц - безадрес.",
            Name = "stock_ccp_fr_repo_1m",
            BoardGroupId = 290,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион РЕПО с ЦК 3 месяца - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_Fr_Repo_3M = new BoardGroup
        {
            Id = 291,
            Title = "Аукцион РЕПО с ЦК 3 месяца - безадрес.",
            Name = "stock_ccp_fr_repo_3m",
            BoardGroupId = 291,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 1 день - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_R_1D = new BoardGroup
        {
            Id = 1247,
            Title = "Аукцион обр.РЕПО с ЦК 1 день - безадрес.",
            Name = "stock_ccp_r_1d",
            BoardGroupId = 1247,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 1 неделя - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_R_1W = new BoardGroup
        {
            Id = 1249,
            Title = "Аукцион обр.РЕПО с ЦК 1 неделя - безадрес.",
            Name = "stock_ccp_r_1w",
            BoardGroupId = 1249,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 2 недели - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_R_2W = new BoardGroup
        {
            Id = 1251,
            Title = "Аукцион обр.РЕПО с ЦК 2 недели - безадрес.",
            Name = "stock_ccp_r_2w",
            BoardGroupId = 1251,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 1 месяц - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_R_1M = new BoardGroup
        {
            Id = 1253,
            Title = "Аукцион обр.РЕПО с ЦК 1 месяц - безадрес.",
            Name = "stock_ccp_r_1m",
            BoardGroupId = 1253,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Аукцион обр.РЕПО с ЦК 5 недель - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_R_5W = new BoardGroup
        {
            Id = 1255,
            Title = "Аукцион обр.РЕПО с ЦК 5 недель - безадрес.",
            Name = "stock_ccp_r_5w",
            BoardGroupId = 1255,
            EngineId = 1,
            MarketId = 27,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Депозиты с ЦК - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Deposit_Order = new BoardGroup
        {
            Id = 97,
            Title = "Депозиты с ЦК - безадрес.",
            Name = "stock_deposit_order",
            BoardGroupId = 97,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Депозиты с ЦК - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Deposit_Off_Order = new BoardGroup
        {
            Id = 98,
            Title = "Депозиты с ЦК - адрес.",
            Name = "stock_deposit_off_order",
            BoardGroupId = 98,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Депозиты с ЦК (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Deposit_Off_Order_Usd = new BoardGroup
        {
            Id = 109,
            Title = "Депозиты с ЦК (USD) - адрес.",
            Name = "stock_deposit_off_order_usd",
            BoardGroupId = 109,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Депозиты с ЦК (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Deposit_Off_Order_Eur = new BoardGroup
        {
            Id = 136,
            Title = "Депозиты с ЦК (EUR) - адрес.",
            Name = "stock_deposit_off_order_eur",
            BoardGroupId = 136,
            EngineId = 1,
            MarketId = 35,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Депозиты с ЦК (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Deposit_Order_Usd = new BoardGroup
        {
            Id = 110,
            Title = "Депозиты с ЦК (USD) - безадрес.",
            Name = "stock_deposit_order_usd",
            BoardGroupId = 110,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Депозиты с ЦК (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Deposit_Order_Eur = new BoardGroup
        {
            Id = 137,
            Title = "Депозиты с ЦК (EUR) - безадрес.",
            Name = "stock_deposit_order_eur",
            BoardGroupId = 137,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Депозиты с ЦК (CNY) - безадрес. 
        /// </summary>
        public static readonly BoardGroup Stock_Deposit_Order_Cny = new BoardGroup
        {
            Id = 1142,
            Title = "Депозиты с ЦК (CNY) - безадрес. ",
            Name = "stock_deposit_order_cny",
            BoardGroupId = 1142,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Депозиты с ЦК (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Deposit_Off_Order_Cny = new BoardGroup
        {
            Id = 1144,
            Title = "Депозиты с ЦК (CNY) - адрес.",
            Name = "stock_deposit_off_order_cny",
            BoardGroupId = 1144,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Депозиты с ЦК - Аукцион
        /// </summary>
        public static readonly BoardGroup Stock_Deposit_Close_Auct = new BoardGroup
        {
            Id = 185,
            Title = "Депозиты с ЦК - Аукцион",
            Name = "stock_deposit_close_auct",
            BoardGroupId = 185,
            EngineId = 1,
            MarketId = 35,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО-М - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Repo_Interdealer_M = new BoardGroup
        {
            Id = 201,
            Title = "РЕПО-М - адрес.",
            Name = "stock_repo_interdealer_m",
            BoardGroupId = 201,
            EngineId = 1,
            MarketId = 3,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с акциями - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Shares_Repo = new BoardGroup
        {
            Id = 1,
            Title = "РЕПО с акциями - адрес.",
            Name = "stock_shares_repo",
            BoardGroupId = 1,
            EngineId = 1,
            MarketId = 3,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Междилерское РЕПО (RUB) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Repo_Interdealer_Rub = new BoardGroup
        {
            Id = 95,
            Title = "Междилерское РЕПО (RUB) - адрес.",
            Name = "stock_repo_interdealer_rub",
            BoardGroupId = 95,
            EngineId = 1,
            MarketId = 3,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Междилерское РЕПО (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Repo_Interdealer_Usd = new BoardGroup
        {
            Id = 94,
            Title = "Междилерское РЕПО (USD) - адрес.",
            Name = "stock_repo_interdealer_usd",
            BoardGroupId = 94,
            EngineId = 1,
            MarketId = 3,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Междилерское РЕПО (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Repo_Interdealer_Eur = new BoardGroup
        {
            Id = 90,
            Title = "Междилерское РЕПО (EUR) - адрес.",
            Name = "stock_repo_interdealer_eur",
            BoardGroupId = 90,
            EngineId = 1,
            MarketId = 3,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с облигациями - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Bond_Repo = new BoardGroup
        {
            Id = 2,
            Title = "РЕПО с облигациями - адрес.",
            Name = "stock_bond_repo",
            BoardGroupId = 2,
            EngineId = 1,
            MarketId = 3,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// ЦК - РЕПО - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Repo_Cc = new BoardGroup
        {
            Id = 31,
            Title = "ЦК - РЕПО - адрес.",
            Name = "stock_repo_cc",
            BoardGroupId = 31,
            EngineId = 1,
            MarketId = 3,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Т+: Для квал. инвесторов - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Qnv_Tplus = new BoardGroup
        {
            Id = 63,
            Title = "Т+: Для квал. инвесторов - безадрес.",
            Name = "stock_qnv_tplus",
            BoardGroupId = 63,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т0: Квал. инвесторы - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Qnv_Main = new BoardGroup
        {
            Id = 60,
            Title = "Т0: Квал. инвесторы - безадрес.",
            Name = "stock_qnv_main",
            BoardGroupId = 60,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РПС: Для квал. инвесторов - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Qnv_Ndm = new BoardGroup
        {
            Id = 61,
            Title = "РПС: Для квал. инвесторов - адрес.",
            Name = "stock_qnv_ndm",
            BoardGroupId = 61,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК: Для квал. инвесторов - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Qnv_Ndm_Tplus = new BoardGroup
        {
            Id = 64,
            Title = "РПС с ЦК: Для квал. инвесторов - адрес.",
            Name = "stock_qnv_ndm_tplus",
            BoardGroupId = 64,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО: Для квал. инвесторов - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Qnv_Repo = new BoardGroup
        {
            Id = 62,
            Title = "РЕПО: Для квал. инвесторов - адрес.",
            Name = "stock_qnv_repo",
            BoardGroupId = 62,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Т+: Для квал. инвесторов (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Qnv_Tplus_Usd = new BoardGroup
        {
            Id = 87,
            Title = "Т+: Для квал. инвесторов (USD) - безадрес.",
            Name = "stock_qnv_tplus_usd",
            BoardGroupId = 87,
            EngineId = 1,
            MarketId = 28,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Безадресные сделки с ЦК
        /// </summary>
        public static readonly BoardGroup Stock_Mamc_Liq = new BoardGroup
        {
            Id = 120,
            Title = "Безадресные сделки с ЦК",
            Name = "stock_mamc_liq",
            BoardGroupId = 120,
            EngineId = 1,
            MarketId = 36,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Урегулирование с ЦК Нерезиденты - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresmamc_Liq = new BoardGroup
        {
            Id = 1082,
            Title = "Урегулирование с ЦК Нерезиденты - безадрес.",
            Name = "stock_nonresmamc_liq",
            BoardGroupId = 1082,
            EngineId = 1,
            MarketId = 36,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "nonres",
        };


        /// <summary>
        /// Т+: Ин.Акции и ДР (HKD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreignshares_Tplus_Hkd = new BoardGroup
        {
            Id = 1229,
            Title = "Т+: Ин.Акции и ДР (HKD) - безадрес.",
            Name = "stock_foreignshares_tplus_hkd",
            BoardGroupId = 1229,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+ Ин.Акции и ДР - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreign_Shares = new BoardGroup
        {
            Id = 265,
            Title = "Т+ Ин.Акции и ДР - безадрес.",
            Name = "stock_foreign_shares",
            BoardGroupId = 265,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Ин.Акции и ДР (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreignshares_Tplus_Usd = new BoardGroup
        {
            Id = 292,
            Title = "Т+: Ин.Акции и ДР (USD) - безадрес.",
            Name = "stock_foreignshares_tplus_usd",
            BoardGroupId = 292,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Т+: Ин.Акции и ДР (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreignshares_Tplus_Cny = new BoardGroup
        {
            Id = 1206,
            Title = "Т+: Ин.Акции и ДР (CNY) - безадрес.",
            Name = "stock_foreignshares_tplus_cny",
            BoardGroupId = 1206,
            EngineId = 1,
            MarketId = 47,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции и ДР (HKD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreign_Ccp_Hkd = new BoardGroup
        {
            Id = 1232,
            Title = "РПС с ЦК: Ин.Акции и ДР (HKD) - адрес.",
            Name = "stock_foreign_ccp_hkd",
            BoardGroupId = 1232,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС: Ин.Акции (HKD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreign_Ndm_Hkd = new BoardGroup
        {
            Id = 1235,
            Title = "РПС: Ин.Акции (HKD) - адрес.",
            Name = "stock_foreign_ndm_hkd",
            BoardGroupId = 1235,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции и ДР - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreign_Ccp = new BoardGroup
        {
            Id = 267,
            Title = "РПС с ЦК: Ин.Акции и ДР - адрес.",
            Name = "stock_foreign_ccp",
            BoardGroupId = 267,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС: Ин.Акции (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreignndm_Usd = new BoardGroup
        {
            Id = 294,
            Title = "РПС: Ин.Акции (USD) - адрес.",
            Name = "stock_foreignndm_usd",
            BoardGroupId = 294,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК: Ин.Акции и ДР (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreign_Ccp_Cny = new BoardGroup
        {
            Id = 1209,
            Title = "РПС с ЦК: Ин.Акции и ДР (USD) - адрес.",
            Name = "stock_foreign_ccp_cny",
            BoardGroupId = 1209,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РПС: Ин.Акции (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreign_Ndm_Cny = new BoardGroup
        {
            Id = 1212,
            Title = "РПС: Ин.Акции (CNY) - адрес.",
            Name = "stock_foreign_ndm_cny",
            BoardGroupId = 1212,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РПС: Ин.Акции - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreign_Ndm = new BoardGroup
        {
            Id = 269,
            Title = "РПС: Ин.Акции - адрес.",
            Name = "stock_foreign_ndm",
            BoardGroupId = 269,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Т+: РПС с ЦК: Ин.Акции и ДР (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Foreignndm_Ccp_Usd = new BoardGroup
        {
            Id = 293,
            Title = "Т+: РПС с ЦК: Ин.Акции и ДР (USD) - адрес.",
            Name = "stock_foreignndm_ccp_usd",
            BoardGroupId = 293,
            EngineId = 1,
            MarketId = 49,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// MOEX Board
        /// </summary>
        public static readonly BoardGroup Stock_Moexboard = new BoardGroup
        {
            Id = 72,
            Title = "MOEX Board",
            Name = "stock_moexboard",
            BoardGroupId = 72,
            EngineId = 1,
            MarketId = 33,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 день - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_D = new BoardGroup
        {
            Id = 86,
            Title = "РЕПО с ЦК с КСУ 1 день - безадрес.",
            Name = "stock_gcc_d",
            BoardGroupId = 86,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 7 дн. - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_W = new BoardGroup
        {
            Id = 83,
            Title = "РЕПО с ЦК с КСУ 7 дн. - безадрес.",
            Name = "stock_gcc_w",
            BoardGroupId = 83,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 14 дн. - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_2W = new BoardGroup
        {
            Id = 80,
            Title = "РЕПО с ЦК с КСУ 14 дн. - безадрес.",
            Name = "stock_gcc_2w",
            BoardGroupId = 80,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 месяц - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_M = new BoardGroup
        {
            Id = 84,
            Title = "РЕПО с ЦК с КСУ 1 месяц - безадрес.",
            Name = "stock_gcc_m",
            BoardGroupId = 84,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 2 месяца - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_2M = new BoardGroup
        {
            Id = 81,
            Title = "РЕПО с ЦК с КСУ 2 месяца - безадрес.",
            Name = "stock_gcc_2m",
            BoardGroupId = 81,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 3 месяца - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_3M = new BoardGroup
        {
            Id = 85,
            Title = "РЕПО с ЦК с КСУ 3 месяца - безадрес.",
            Name = "stock_gcc_3m",
            BoardGroupId = 85,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 6 мес. - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_6M = new BoardGroup
        {
            Id = 103,
            Title = "РЕПО с ЦК с КСУ 6 мес. - безадрес.",
            Name = "stock_gcc_6m",
            BoardGroupId = 103,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 год - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_1Y = new BoardGroup
        {
            Id = 102,
            Title = "РЕПО с ЦК с КСУ 1 год - безадрес.",
            Name = "stock_gcc_1y",
            BoardGroupId = 102,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Ndm = new BoardGroup
        {
            Id = 82,
            Title = "РЕПО с ЦК с КСУ - адрес.",
            Name = "stock_gcc_ndm",
            BoardGroupId = 82,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 день (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_D_Usd = new BoardGroup
        {
            Id = 111,
            Title = "РЕПО с ЦК с КСУ 1 день (USD) - безадрес.",
            Name = "stock_gcc_d_usd",
            BoardGroupId = 111,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 7 дн. (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_W_Usd = new BoardGroup
        {
            Id = 112,
            Title = "РЕПО с ЦК с КСУ 7 дн. (USD) - безадрес.",
            Name = "stock_gcc_w_usd",
            BoardGroupId = 112,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 14 дн. (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_2W_Usd = new BoardGroup
        {
            Id = 113,
            Title = "РЕПО с ЦК с КСУ 14 дн. (USD) - безадрес.",
            Name = "stock_gcc_2w_usd",
            BoardGroupId = 113,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 месяц (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_M_Usd = new BoardGroup
        {
            Id = 114,
            Title = "РЕПО с ЦК с КСУ 1 месяц (USD) - безадрес.",
            Name = "stock_gcc_m_usd",
            BoardGroupId = 114,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 2 месяца (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_2M_Usd = new BoardGroup
        {
            Id = 115,
            Title = "РЕПО с ЦК с КСУ 2 месяца (USD) - безадрес.",
            Name = "stock_gcc_2m_usd",
            BoardGroupId = 115,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 3 месяца (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_3M_Usd = new BoardGroup
        {
            Id = 116,
            Title = "РЕПО с ЦК с КСУ 3 месяца (USD) - безадрес.",
            Name = "stock_gcc_3m_usd",
            BoardGroupId = 116,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 6 месяцев (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_6M_Usd = new BoardGroup
        {
            Id = 117,
            Title = "РЕПО с ЦК с КСУ 6 месяцев (USD) - безадрес.",
            Name = "stock_gcc_6m_usd",
            BoardGroupId = 117,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 год (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_1Y_Usd = new BoardGroup
        {
            Id = 118,
            Title = "РЕПО с ЦК с КСУ 1 год (USD) - безадрес.",
            Name = "stock_gcc_1y_usd",
            BoardGroupId = 118,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Ndm_Usd = new BoardGroup
        {
            Id = 119,
            Title = "РЕПО с ЦК с КСУ (USD) - адрес.",
            Name = "stock_gcc_ndm_usd",
            BoardGroupId = 119,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 день (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_D_Eur = new BoardGroup
        {
            Id = 127,
            Title = "РЕПО с ЦК с КСУ 1 день (EUR) - безадрес.",
            Name = "stock_gcc_d_eur",
            BoardGroupId = 127,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 7 дн. (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_W_Eur = new BoardGroup
        {
            Id = 128,
            Title = "РЕПО с ЦК с КСУ 7 дн. (EUR) - безадрес.",
            Name = "stock_gcc_w_eur",
            BoardGroupId = 128,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 14 дн. (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_2W_Eur = new BoardGroup
        {
            Id = 129,
            Title = "РЕПО с ЦК с КСУ 14 дн. (EUR) - безадрес.",
            Name = "stock_gcc_2w_eur",
            BoardGroupId = 129,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 месяц (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_M_Eur = new BoardGroup
        {
            Id = 130,
            Title = "РЕПО с ЦК с КСУ 1 месяц (EUR) - безадрес.",
            Name = "stock_gcc_m_eur",
            BoardGroupId = 130,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 2 месяца (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_2M_Eur = new BoardGroup
        {
            Id = 131,
            Title = "РЕПО с ЦК с КСУ 2 месяца (EUR) - безадрес.",
            Name = "stock_gcc_2m_eur",
            BoardGroupId = 131,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 3 месяца (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_3M_Eur = new BoardGroup
        {
            Id = 132,
            Title = "РЕПО с ЦК с КСУ 3 месяца (EUR) - безадрес.",
            Name = "stock_gcc_3m_eur",
            BoardGroupId = 132,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 6 месяцев (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_6M_Eur = new BoardGroup
        {
            Id = 133,
            Title = "РЕПО с ЦК с КСУ 6 месяцев (EUR) - безадрес.",
            Name = "stock_gcc_6m_eur",
            BoardGroupId = 133,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 год (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_1Y_Eur = new BoardGroup
        {
            Id = 134,
            Title = "РЕПО с ЦК с КСУ 1 год (EUR) - безадрес.",
            Name = "stock_gcc_1y_eur",
            BoardGroupId = 134,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Ndm_Eur = new BoardGroup
        {
            Id = 135,
            Title = "РЕПО с ЦК с КСУ (EUR) - адрес.",
            Name = "stock_gcc_ndm_eur",
            BoardGroupId = 135,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 9 месяцев - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_9M = new BoardGroup
        {
            Id = 187,
            Title = "РЕПО с ЦК с КСУ 9 месяцев - безадрес.",
            Name = "stock_ccp_9m",
            BoardGroupId = 187,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 9 мес. (USD) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_9M_Usd = new BoardGroup
        {
            Id = 189,
            Title = "РЕПО с ЦК с КСУ 9 мес. (USD) - безадрес.",
            Name = "stock_ccp_9m_usd",
            BoardGroupId = 189,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 9 мес. (EUR) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Ccp_9M_Eur = new BoardGroup
        {
            Id = 191,
            Title = "РЕПО с ЦК с КСУ 9 мес. (EUR) - безадрес.",
            Name = "stock_ccp_9m_eur",
            BoardGroupId = 191,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 день (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_D_Cny = new BoardGroup
        {
            Id = 1122,
            Title = "РЕПО с ЦК с КСУ 1 день (CNY) - безадрес.",
            Name = "stock_gcc_d_cny",
            BoardGroupId = 1122,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 7 дней (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_W_Cny = new BoardGroup
        {
            Id = 1124,
            Title = "РЕПО с ЦК с КСУ 7 дней (CNY) - безадрес.",
            Name = "stock_gcc_w_cny",
            BoardGroupId = 1124,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 14 дней (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_2W_Cny = new BoardGroup
        {
            Id = 1126,
            Title = "РЕПО с ЦК с КСУ 14 дней (CNY) - безадрес.",
            Name = "stock_gcc_2w_cny",
            BoardGroupId = 1126,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 месяц (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_1M_Cny = new BoardGroup
        {
            Id = 1128,
            Title = "РЕПО с ЦК с КСУ 1 месяц (CNY) - безадрес.",
            Name = "stock_gcc_1m_cny",
            BoardGroupId = 1128,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 2 месяца (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_2M_Cny = new BoardGroup
        {
            Id = 1130,
            Title = "РЕПО с ЦК с КСУ 2 месяца (CNY) - безадрес.",
            Name = "stock_gcc_2m_cny",
            BoardGroupId = 1130,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 3 месяца (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_3M_Cny = new BoardGroup
        {
            Id = 1132,
            Title = "РЕПО с ЦК с КСУ 3 месяца (CNY) - безадрес.",
            Name = "stock_gcc_3m_cny",
            BoardGroupId = 1132,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 6 месяцев (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_6M_Cny = new BoardGroup
        {
            Id = 1134,
            Title = "РЕПО с ЦК с КСУ 6 месяцев (CNY) - безадрес.",
            Name = "stock_gcc_6m_cny",
            BoardGroupId = 1134,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 9 месяцев (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_9M_Cny = new BoardGroup
        {
            Id = 1136,
            Title = "РЕПО с ЦК с КСУ 9 месяцев (CNY) - безадрес.",
            Name = "stock_gcc_9m_cny",
            BoardGroupId = 1136,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ 1 год (CNY) - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_1Y_Cny = new BoardGroup
        {
            Id = 1138,
            Title = "РЕПО с ЦК с КСУ 1 год (CNY) - безадрес.",
            Name = "stock_gcc_1y_cny",
            BoardGroupId = 1138,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Ndm_Cny = new BoardGroup
        {
            Id = 1140,
            Title = "РЕПО с ЦК с КСУ (CNY) - адрес.",
            Name = "stock_gcc_ndm_cny",
            BoardGroupId = 1140,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 7 дней - безадрес. (RUSFAR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_1W_Rub = new BoardGroup
        {
            Id = 1156,
            Title = "РЕПО с ЦК с КСУ пл. 7 дней - безадрес. (RUSFAR)",
            Name = "stock_gcc_fl_1w_rub",
            BoardGroupId = 1156,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 14 дней - безадрес. (RUSFAR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_2W_Rub = new BoardGroup
        {
            Id = 1158,
            Title = "РЕПО с ЦК с КСУ пл. 14 дней - безадрес. (RUSFAR)",
            Name = "stock_gcc_fl_2w_rub",
            BoardGroupId = 1158,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 1 месяц - безадрес. (RUSFAR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_1M_Rub = new BoardGroup
        {
            Id = 1160,
            Title = "РЕПО с ЦК с КСУ пл. 1 месяц - безадрес. (RUSFAR)",
            Name = "stock_gcc_fl_1m_rub",
            BoardGroupId = 1160,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 2 месяца - безадрес. (RUSFAR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_2M_Rub = new BoardGroup
        {
            Id = 1162,
            Title = "РЕПО с ЦК с КСУ пл. 2 месяца - безадрес. (RUSFAR)",
            Name = "stock_gcc_fl_2m_rub",
            BoardGroupId = 1162,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 3 месяца - безадрес. (RUSFAR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_3M_Rub = new BoardGroup
        {
            Id = 1164,
            Title = "РЕПО с ЦК с КСУ пл. 3 месяца - безадрес. (RUSFAR)",
            Name = "stock_gcc_fl_3m_rub",
            BoardGroupId = 1164,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 6 месяца - безадрес. (RUSFAR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_6M_Rub = new BoardGroup
        {
            Id = 1166,
            Title = "РЕПО с ЦК с КСУ пл. 6 месяца - безадрес. (RUSFAR)",
            Name = "stock_gcc_fl_6m_rub",
            BoardGroupId = 1166,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 9 месяца - безадрес. (RUSFAR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_9M_Rub = new BoardGroup
        {
            Id = 1168,
            Title = "РЕПО с ЦК с КСУ пл. 9 месяца - безадрес. (RUSFAR)",
            Name = "stock_gcc_fl_9m_rub",
            BoardGroupId = 1168,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 1 год - безадрес. (RUSFAR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_1Y_Rub = new BoardGroup
        {
            Id = 1170,
            Title = "РЕПО с ЦК с КСУ пл. 1 год - безадрес. (RUSFAR)",
            Name = "stock_gcc_fl_1y_rub",
            BoardGroupId = 1170,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 7 дней (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_1W_Cny = new BoardGroup
        {
            Id = 1188,
            Title = "РЕПО с ЦК с КСУ пл. 7 дней (CNY) - безадрес. (RUSFARCNY)",
            Name = "stock_gcc_fl_1w_cny",
            BoardGroupId = 1188,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 14 дней (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_2W_Cny = new BoardGroup
        {
            Id = 1190,
            Title = "РЕПО с ЦК с КСУ пл. 14 дней (CNY) - безадрес. (RUSFARCNY)",
            Name = "stock_gcc_fl_2w_cny",
            BoardGroupId = 1190,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 1 месяц (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_1M_Cny = new BoardGroup
        {
            Id = 1192,
            Title = "РЕПО с ЦК с КСУ пл. 1 месяц (CNY) - безадрес. (RUSFARCNY)",
            Name = "stock_gcc_fl_1m_cny",
            BoardGroupId = 1192,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 2 месяца (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_2M_Cny = new BoardGroup
        {
            Id = 1194,
            Title = "РЕПО с ЦК с КСУ пл. 2 месяца (CNY) - безадрес. (RUSFARCNY)",
            Name = "stock_gcc_fl_2m_cny",
            BoardGroupId = 1194,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 3 месяца (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_3M_Cny = new BoardGroup
        {
            Id = 1196,
            Title = "РЕПО с ЦК с КСУ пл. 3 месяца (CNY) - безадрес. (RUSFARCNY)",
            Name = "stock_gcc_fl_3m_cny",
            BoardGroupId = 1196,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 6 месяца (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_6M_Cny = new BoardGroup
        {
            Id = 1198,
            Title = "РЕПО с ЦК с КСУ пл. 6 месяца (CNY) - безадрес. (RUSFARCNY)",
            Name = "stock_gcc_fl_6m_cny",
            BoardGroupId = 1198,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 9 месяца (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_9M_Cny = new BoardGroup
        {
            Id = 1200,
            Title = "РЕПО с ЦК с КСУ пл. 9 месяца (CNY) - безадрес. (RUSFARCNY)",
            Name = "stock_gcc_fl_9m_cny",
            BoardGroupId = 1200,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. 1 год (CNY) - безадрес. (RUSFARCNY)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_1Y_Cny = new BoardGroup
        {
            Id = 1202,
            Title = "РЕПО с ЦК с КСУ пл. 1 год (CNY) - безадрес. (RUSFARCNY)",
            Name = "stock_gcc_fl_1y_cny",
            BoardGroupId = 1202,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. КлСт 1 мес. - безадрес. (RREFKEYR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_Rr_1M_Rub = new BoardGroup
        {
            Id = 1312,
            Title = "РЕПО с ЦК с КСУ пл. КлСт 1 мес. - безадрес. (RREFKEYR)",
            Name = "stock_gcc_fl_rr_1m_rub",
            BoardGroupId = 1312,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// РЕПО с ЦК с КСУ пл. КлСт 3 мес. - безадрес. (RREFKEYR)
        /// </summary>
        public static readonly BoardGroup Stock_Gcc_Fl_Rr_3M_Rub = new BoardGroup
        {
            Id = 1313,
            Title = "РЕПО с ЦК с КСУ пл. КлСт 3 мес. - безадрес. (RREFKEYR)",
            Name = "stock_gcc_fl_rr_3m_rub",
            BoardGroupId = 1313,
            EngineId = 1,
            MarketId = 46,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Кредиты RUB - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Credit_Rub = new BoardGroup
        {
            Id = 275,
            Title = "Кредиты RUB - адрес.",
            Name = "stock_credit_rub",
            BoardGroupId = 275,
            EngineId = 1,
            MarketId = 54,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Кредиты USD - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Credit_Usd = new BoardGroup
        {
            Id = 277,
            Title = "Кредиты USD - адрес.",
            Name = "stock_credit_usd",
            BoardGroupId = 277,
            EngineId = 1,
            MarketId = 54,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Кредиты EUR - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Credit_Eur = new BoardGroup
        {
            Id = 279,
            Title = "Кредиты EUR - адрес.",
            Name = "stock_credit_eur",
            BoardGroupId = 279,
            EngineId = 1,
            MarketId = 54,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Кредиты CNY - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Credit_Cny = new BoardGroup
        {
            Id = 1146,
            Title = "Кредиты CNY - адрес.",
            Name = "stock_credit_cny",
            BoardGroupId = 1146,
            EngineId = 1,
            MarketId = 54,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Акции и ДР - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresndm_Shares_Tplus_Rub = new BoardGroup
        {
            Id = 1056,
            Title = "РПС с ЦК Нерезиденты: Акции и ДР - адрес.",
            Name = "stock_nonresndm_shares_tplus_rub",
            BoardGroupId = 1056,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Акции и ДР (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresndm_Shares_Tplus_Usd = new BoardGroup
        {
            Id = 1058,
            Title = "РПС с ЦК Нерезиденты: Акции и ДР (USD) - адрес.",
            Name = "stock_nonresndm_shares_tplus_usd",
            BoardGroupId = 1058,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Акции и ДР (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresndm_Shares_Tplus_Eur = new BoardGroup
        {
            Id = 1060,
            Title = "РПС с ЦК Нерезиденты: Акции и ДР (EUR) - адрес.",
            Name = "stock_nonresndm_shares_tplus_eur",
            BoardGroupId = 1060,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Облигации - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresndm_Bonds_Tplus_Rub = new BoardGroup
        {
            Id = 1062,
            Title = "РПС с ЦК Нерезиденты: Облигации - адрес.",
            Name = "stock_nonresndm_bonds_tplus_rub",
            BoardGroupId = 1062,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Облигации (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresndm_Bonds_Tplus_Cny = new BoardGroup
        {
            Id = 1064,
            Title = "РПС с ЦК Нерезиденты: Облигации (CNY) - адрес.",
            Name = "stock_nonresndm_bonds_tplus_cny",
            BoardGroupId = 1064,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Облигации (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresndm_Bonds_Tplus_Usd = new BoardGroup
        {
            Id = 1066,
            Title = "РПС с ЦК Нерезиденты: Облигации (USD) - адрес.",
            Name = "stock_nonresndm_bonds_tplus_usd",
            BoardGroupId = 1066,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РПС с ЦК Нерезиденты: Облигации (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresndm_Bonds_Tplus_Eur = new BoardGroup
        {
            Id = 1068,
            Title = "РПС с ЦК Нерезиденты: Облигации (EUR) - адрес.",
            Name = "stock_nonresndm_bonds_tplus_eur",
            BoardGroupId = 1068,
            EngineId = 1,
            MarketId = 1015,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РЕПО-M Нерезиденты - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresrepo_Interdealer_Rub = new BoardGroup
        {
            Id = 1071,
            Title = "РЕПО-M Нерезиденты - адрес.",
            Name = "stock_nonresrepo_interdealer_rub",
            BoardGroupId = 1071,
            EngineId = 1,
            MarketId = 1017,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РЕПО-M Нерезиденты (USD) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresrepo_Interdealer_Usd = new BoardGroup
        {
            Id = 1073,
            Title = "РЕПО-M Нерезиденты (USD) - адрес.",
            Name = "stock_nonresrepo_interdealer_usd",
            BoardGroupId = 1073,
            EngineId = 1,
            MarketId = 1017,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РЕПО-M Нерезиденты (EUR) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresrepo_Interdealer_Eur = new BoardGroup
        {
            Id = 1075,
            Title = "РЕПО-M Нерезиденты (EUR) - адрес.",
            Name = "stock_nonresrepo_interdealer_eur",
            BoardGroupId = 1075,
            EngineId = 1,
            MarketId = 1017,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// РЕПО-M Нерезиденты (CNY) - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresrepo_Interdealer_Cny = new BoardGroup
        {
            Id = 1077,
            Title = "РЕПО-M Нерезиденты (CNY) - адрес.",
            Name = "stock_nonresrepo_interdealer_cny",
            BoardGroupId = 1077,
            EngineId = 1,
            MarketId = 1017,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "nonres",
        };


        /// <summary>
        /// Урегулирование РЕПО с ЦК Нерезиденты - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Nonresccp_Liq = new BoardGroup
        {
            Id = 1080,
            Title = "Урегулирование РЕПО с ЦК Нерезиденты - безадрес.",
            Name = "stock_nonresccp_liq",
            BoardGroupId = 1080,
            EngineId = 1,
            MarketId = 1019,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "nonres",
        };


        /// <summary>
        /// Standard - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Standard = new BoardGroup
        {
            Id = 36,
            Title = "Standard - безадрес.",
            Name = "stock_standard",
            BoardGroupId = 36,
            EngineId = 1,
            MarketId = 23,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Standard - адрес.
        /// </summary>
        public static readonly BoardGroup Standard_Ndm = new BoardGroup
        {
            Id = 41,
            Title = "Standard - адрес.",
            Name = "standard_ndm",
            BoardGroupId = 41,
            EngineId = 1,
            MarketId = 23,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Standard: РЕПО - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Standard_Repo = new BoardGroup
        {
            Id = 40,
            Title = "Standard: РЕПО - адрес.",
            Name = "stock_standard_repo",
            BoardGroupId = 40,
            EngineId = 1,
            MarketId = 23,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Classica - безадрес.
        /// </summary>
        public static readonly BoardGroup Stock_Classica = new BoardGroup
        {
            Id = 43,
            Title = "Classica - безадрес.",
            Name = "stock_classica",
            BoardGroupId = 43,
            EngineId = 1,
            MarketId = 25,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Classica - адрес.
        /// </summary>
        public static readonly BoardGroup Stock_Classica_Ndm = new BoardGroup
        {
            Id = 44,
            Title = "Classica - адрес.",
            Name = "stock_classica_ndm",
            BoardGroupId = 44,
            EngineId = 1,
            MarketId = 25,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Индексы ГКО/ОФЗ
        /// </summary>
        public static readonly BoardGroup State_Index = new BoardGroup
        {
            Id = 12,
            Title = "Индексы ГКО/ОФЗ",
            Name = "state_index",
            BoardGroupId = 12,
            EngineId = 2,
            MarketId = 9,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Основной режим
        /// </summary>
        public static readonly BoardGroup State = new BoardGroup
        {
            Id = 10,
            Title = "Основной режим",
            Name = "state",
            BoardGroupId = 10,
            EngineId = 2,
            MarketId = 6,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Сделки междилерского РЕПО
        /// </summary>
        public static readonly BoardGroup Dealer_Dealer = new BoardGroup
        {
            Id = 3,
            Title = "Сделки междилерского РЕПО",
            Name = "dealer_dealer",
            BoardGroupId = 3,
            EngineId = 2,
            MarketId = 7,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Внесистемные сделки
        /// </summary>
        public static readonly BoardGroup State_Ndm = new BoardGroup
        {
            Id = 11,
            Title = "Внесистемные сделки",
            Name = "state_ndm",
            BoardGroupId = 11,
            EngineId = 2,
            MarketId = 8,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Системные сделки - безадрес.
        /// </summary>
        public static readonly BoardGroup Currency = new BoardGroup
        {
            Id = 13,
            Title = "Системные сделки - безадрес.",
            Name = "currency",
            BoardGroupId = 13,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Внесистемные сделки - адрес.
        /// </summary>
        public static readonly BoardGroup Currency_Ndm = new BoardGroup
        {
            Id = 46,
            Title = "Внесистемные сделки - адрес.",
            Name = "currency_ndm",
            BoardGroupId = 46,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Внесистемные сделки урегулирования - безадрес.
        /// </summary>
        public static readonly BoardGroup Currency_Selt_Licu = new BoardGroup
        {
            Id = 151,
            Title = "Внесистемные сделки урегулирования - безадрес.",
            Name = "currency_selt_licu",
            BoardGroupId = 151,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Фиксинг системный - безадрес.
        /// </summary>
        public static readonly BoardGroup Currency_Fixing = new BoardGroup
        {
            Id = 100,
            Title = "Фиксинг системный - безадрес.",
            Name = "currency_fixing",
            BoardGroupId = 100,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Фиксинг внесистемный - адрес.
        /// </summary>
        public static readonly BoardGroup Currency_Fixing_Ndm = new BoardGroup
        {
            Id = 101,
            Title = "Фиксинг внесистемный - адрес.",
            Name = "currency_fixing_ndm",
            BoardGroupId = 101,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Системные средневзвешенные - безадрес.
        /// </summary>
        public static readonly BoardGroup Currency_Selt_Waps = new BoardGroup
        {
            Id = 149,
            Title = "Системные средневзвешенные - безадрес.",
            Name = "currency_selt_waps",
            BoardGroupId = 149,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Внесистемные средневзвешенные - адрес.
        /// </summary>
        public static readonly BoardGroup Currency_Selt_Wapn = new BoardGroup
        {
            Id = 150,
            Title = "Внесистемные средневзвешенные - адрес.",
            Name = "currency_selt_wapn",
            BoardGroupId = 150,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Аукцион ЦБР - адрес.
        /// </summary>
        public static readonly BoardGroup Currency_Selt_Cbr = new BoardGroup
        {
            Id = 70,
            Title = "Аукцион ЦБР - адрес.",
            Name = "currency_selt_cbr",
            BoardGroupId = 70,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Поставка
        /// </summary>
        public static readonly BoardGroup Currency_Selt_Settle = new BoardGroup
        {
            Id = 140,
            Title = "Поставка",
            Name = "currency_selt_settle",
            BoardGroupId = 140,
            EngineId = 3,
            MarketId = 10,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Системные фьючерсные контракты  - безадрес.
        /// </summary>
        public static readonly BoardGroup Currency_Futures = new BoardGroup
        {
            Id = 88,
            Title = "Системные фьючерсные контракты  - безадрес.",
            Name = "currency_futures",
            BoardGroupId = 88,
            EngineId = 3,
            MarketId = 34,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "main",
        };


        /// <summary>
        /// Внесистемные фьючерсные контракты - адрес.
        /// </summary>
        public static readonly BoardGroup Currency_Futures_Ndm = new BoardGroup
        {
            Id = 89,
            Title = "Внесистемные фьючерсные контракты - адрес.",
            Name = "currency_futures_ndm",
            BoardGroupId = 89,
            EngineId = 3,
            MarketId = 34,
            IsTraded = false,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Валютный фиксинг
        /// </summary>
        public static readonly BoardGroup Currency_Index = new BoardGroup
        {
            Id = 165,
            Title = "Валютный фиксинг",
            Name = "currency_index",
            BoardGroupId = 165,
            EngineId = 3,
            MarketId = 41,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Рынок OTC
        /// </summary>
        public static readonly BoardGroup Currency_Otc_Liquidity = new BoardGroup
        {
            Id = 261,
            Title = "Рынок OTC",
            Name = "currency_otc_liquidity",
            BoardGroupId = 261,
            EngineId = 3,
            MarketId = 45,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Рынок OTC крупные сделки
        /// </summary>
        public static readonly BoardGroup Currency_Otc_Darkpools = new BoardGroup
        {
            Id = 263,
            Title = "Рынок OTC крупные сделки",
            Name = "currency_otc_darkpools",
            BoardGroupId = 263,
            EngineId = 3,
            MarketId = 45,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Срочные инструменты
        /// </summary>
        public static readonly BoardGroup Futures = new BoardGroup
        {
            Id = 15,
            Title = "Срочные инструменты",
            Name = "futures",
            BoardGroupId = 15,
            EngineId = 4,
            MarketId = 12,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Фьючерсы
        /// </summary>
        public static readonly BoardGroup Futures_Forts = new BoardGroup
        {
            Id = 45,
            Title = "Фьючерсы",
            Name = "futures_forts",
            BoardGroupId = 45,
            EngineId = 4,
            MarketId = 22,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Опционы
        /// </summary>
        public static readonly BoardGroup Futures_Options = new BoardGroup
        {
            Id = 35,
            Title = "Опционы",
            Name = "futures_options",
            BoardGroupId = 35,
            EngineId = 4,
            MarketId = 24,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Фьючерсы IQS
        /// </summary>
        public static readonly BoardGroup Futures_Fortsiqs = new BoardGroup
        {
            Id = 138,
            Title = "Фьючерсы IQS",
            Name = "futures_fortsiqs",
            BoardGroupId = 138,
            EngineId = 4,
            MarketId = 37,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Опционы IQS
        /// </summary>
        public static readonly BoardGroup Futures_Optionsiqs = new BoardGroup
        {
            Id = 139,
            Title = "Опционы IQS",
            Name = "futures_optionsiqs",
            BoardGroupId = 139,
            EngineId = 4,
            MarketId = 38,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Стандартные контракты АО НТБ
        /// </summary>
        public static readonly BoardGroup Commodity_Futures = new BoardGroup
        {
            Id = 20,
            Title = "Стандартные контракты АО НТБ",
            Name = "commodity_futures",
            BoardGroupId = 20,
            EngineId = 5,
            MarketId = 18,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Интервенции по продаже зерна
        /// </summary>
        public static readonly BoardGroup Interventions_Grain = new BoardGroup
        {
            Id = 24,
            Title = "Интервенции по продаже зерна",
            Name = "interventions_grain",
            BoardGroupId = 24,
            EngineId = 6,
            MarketId = 20,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// ОТС-система: облигации
        /// </summary>
        public static readonly BoardGroup Offboard_Bond_All = new BoardGroup
        {
            Id = 141,
            Title = "ОТС-система: облигации",
            Name = "offboard_bond_all",
            BoardGroupId = 141,
            EngineId = 7,
            MarketId = 39,
            IsTraded = false,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// Агро: Сахар
        /// </summary>
        public static readonly BoardGroup Agro_Sugar_All = new BoardGroup
        {
            Id = 271,
            Title = "Агро: Сахар",
            Name = "agro_sugar_all",
            BoardGroupId = 271,
            EngineId = 9,
            MarketId = 51,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Агро: Аукционы НТБ
        /// </summary>
        public static readonly BoardGroup Agro_Auctions_All = new BoardGroup
        {
            Id = 1032,
            Title = "Агро: Аукционы НТБ",
            Name = "agro_auctions_all",
            BoardGroupId = 1032,
            EngineId = 9,
            MarketId = 1031,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// Агро: Закупочные аукционы НТБ
        /// </summary>
        public static readonly BoardGroup Agro_Buyauctions_All = new BoardGroup
        {
            Id = 1085,
            Title = "Агро: Закупочные аукционы НТБ",
            Name = "agro_buyauctions_all",
            BoardGroupId = 1085,
            EngineId = 9,
            MarketId = 1084,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "main",
        };


        /// <summary>
        /// ОТС: Акции Т+ - безадресные
        /// </summary>
        public static readonly BoardGroup Otc_Shares_Tplus = new BoardGroup
        {
            Id = 1258,
            Title = "ОТС: Акции Т+ - безадресные",
            Name = "otc_shares_tplus",
            BoardGroupId = 1258,
            EngineId = 1012,
            MarketId = 1257,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "otc",
        };


        /// <summary>
        /// ОТС: Облигации Т+ - безадресные
        /// </summary>
        public static readonly BoardGroup Otc_Bonds_Tplus = new BoardGroup
        {
            Id = 1021,
            Title = "ОТС: Облигации Т+ - безадресные",
            Name = "otc_bonds_tplus",
            BoardGroupId = 1021,
            EngineId = 1012,
            MarketId = 1013,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = true,
            Category = "otc",
        };


        /// <summary>
        /// ОТС: Облигации Т+ (USD) - безадресные
        /// </summary>
        public static readonly BoardGroup Otc_Bonds_Tplus_Usd = new BoardGroup
        {
            Id = 1015,
            Title = "ОТС: Облигации Т+ (USD) - безадресные",
            Name = "otc_bonds_tplus_usd",
            BoardGroupId = 1015,
            EngineId = 1012,
            MarketId = 1013,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = true,
            Category = "otc",
        };


        /// <summary>
        /// ОТС: Акции РПС с ЦК - адресные
        /// </summary>
        public static readonly BoardGroup Otc_Ndm_Ccp_Shares_Rub = new BoardGroup
        {
            Id = 1260,
            Title = "ОТС: Акции РПС с ЦК - адресные",
            Name = "otc_ndm_ccp_shares_rub",
            BoardGroupId = 1260,
            EngineId = 1012,
            MarketId = 1262,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// OTC Размещение: Адресный
        /// </summary>
        public static readonly BoardGroup Otc_Ndm_Shares_Issuance = new BoardGroup
        {
            Id = 1303,
            Title = "OTC Размещение: Адресный",
            Name = "otc_ndm_shares_issuance",
            BoardGroupId = 1303,
            EngineId = 1012,
            MarketId = 1262,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// OTC Выкуп: Адресный
        /// </summary>
        public static readonly BoardGroup Otc_Ndm_Shares_Buyback = new BoardGroup
        {
            Id = 1305,
            Title = "OTC Выкуп: Адресный",
            Name = "otc_ndm_shares_buyback",
            BoardGroupId = 1305,
            EngineId = 1012,
            MarketId = 1262,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// OTC: Облигации с ЦК - двусторонние
        /// </summary>
        public static readonly BoardGroup Otc_Ndm_Ccp_Rub = new BoardGroup
        {
            Id = 1017,
            Title = "OTC: Облигации с ЦК - двусторонние",
            Name = "otc_ndm_ccp_rub",
            BoardGroupId = 1017,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// OTC: Облигации с ЦК (USD) - двусторонние
        /// </summary>
        public static readonly BoardGroup Otc_Ndm_Ccp_Usd = new BoardGroup
        {
            Id = 1019,
            Title = "OTC: Облигации с ЦК (USD) - двусторонние",
            Name = "otc_ndm_ccp_usd",
            BoardGroupId = 1019,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// OTC: Облигации с ЦК (CNY) - двусторонние
        /// </summary>
        public static readonly BoardGroup Otc_Ndm_Ccp_Cny = new BoardGroup
        {
            Id = 1204,
            Title = "OTC: Облигации с ЦК (CNY) - двусторонние",
            Name = "otc_ndm_ccp_cny",
            BoardGroupId = 1204,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// OTC: Облигации с ЦК адрес. - двусторонние
        /// </summary>
        public static readonly BoardGroup Otc_Bondsndm_Ccp_Ndm_Rub = new BoardGroup
        {
            Id = 1263,
            Title = "OTC: Облигации с ЦК адрес. - двусторонние",
            Name = "otc_bondsndm_ccp_ndm_rub",
            BoardGroupId = 1263,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// OTC: Облигации с ЦК адрес. (CNY) - двусторонние
        /// </summary>
        public static readonly BoardGroup Otc_Bondsndm_Ccp_Ndm_Cny = new BoardGroup
        {
            Id = 1265,
            Title = "OTC: Облигации с ЦК адрес. (CNY) - двусторонние",
            Name = "otc_bondsndm_ccp_ndm_cny",
            BoardGroupId = 1265,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// OTC: Облигации с ЦК адрес. (USD) - двусторонние
        /// </summary>
        public static readonly BoardGroup Otc_Bondsndm_Ccp_Ndm_Usd = new BoardGroup
        {
            Id = 1267,
            Title = "OTC: Облигации с ЦК адрес. (USD) - двусторонние",
            Name = "otc_bondsndm_ccp_ndm_usd",
            BoardGroupId = 1267,
            EngineId = 1012,
            MarketId = 1014,
            IsTraded = true,
            IsDefault = false,
            IsOrderDriven = false,
            Category = "otc",
        };


        /// <summary>
        /// Квоты
        /// </summary>
        public static readonly BoardGroup Quotes_Bonds = new BoardGroup
        {
            Id = 1280,
            Title = "Квоты",
            Name = "quotes_bonds",
            BoardGroupId = 1280,
            EngineId = 1282,
            MarketId = 1279,
            IsTraded = true,
            IsDefault = true,
            IsOrderDriven = false,
            Category = "quotes",
        };


     
        public static BoardGroup[] All = new BoardGroup[] { Stock_Index, Stock_Index_Inav, Stock_Index_Mmix, Stock_Index_Namex, Stock_Index_Pf, Stock_Index_Sdfi, Stock_Shares_Tplus, Stock_Shares_Tplus_Usd, Stock_Shares, Stock_Shares_Settle, Stock_Shares_Sm, Stock_Shares_Darkpool, Stock_Etf_Usd, Stock_Shares_Tplus_Eur, Stock_Shares_Tplus_Cny, Stock_Shares_Etf_Eur, Stock_Shares_Tplus_Hkd, Stock_Shares_Cc, Stock_Bonds_Tplus, Stock_Bonds_Tplus_Usd, Stock_Etc_Tplus, Stock_Bonds, Stock_Bonds_Settle, Stock_Etc, Stock_Bonds_Euro, Stock_Bonds_Buyback, Stock_Bonds_Distribution, Stock_Bonds_Darkpools, Stock_Bonds_Tplus_Eur, Stock_Bonds_Darkpools_Usd, Stock_Bonds_Tplus_Cny, Stock_Bonds_Auct_Pact, Stock_Ndm_Tplus, Stock_Ndm_Usd, Stock_Ndm, Stock_Ndm_Currency, Stock_Ndm_Issuance, Stock_Ndm_Buyback, Stock_Ndm_Buyback_Eur, Stock_Ndm_Anonymous, Stock_Ndm_Anonymous_Usd, Stock_Ndm_Anonymous_Eur, Stock_Ndm_Tplus_Usd, Stock_Ndm_Buyback_Usd, Stock_Ndm_Buyback_Cny, Stock_Ndm_Ccp_Bonds_Eur  , Stock_Ndm_Eur, Stock_Ndm_Tplus_Eur, Stock_Ndm_Ccp_Bonds, Stock_Ndm_Ccp_Bonds_Usd, Stock_Ndm_Bonds, Stock_Ndm_Bonds_Usd, Stock_Ndm_Bonds_Eur, Stock_Ndm_Bonds_Cny, Stock_Ndm_Ccp_Bonds_Cny, Stock_Ndm_Cny, Stock_Ndm_Tplus_Cny, Stock_Ndm_Hkd, Stock_Ndm_Tplus_Hkd, Stock_Ndm_Cc, Stock_Otc, Stock_Ccp_D_Usd, Stock_Ccp_D_Eur, Stock_Ccp_W, Stock_Ccp_W_Usd, Stock_Ccp_W_Eur, Stock_Ccp, Stock_Ccp_M, Stock_Ccp_M_Usd, Stock_Ccp_M_Eur, Stock_Ccp_3M, Stock_Ccp_3M_Usd, Stock_Ccp_3M_Eur, Stock_Ccp_Liq, Stock_Ccp_D_Cny, Stock_Ccp_Ndm_Cny, Stock_Ccp_W_Cny, Stock_Ccp_1M_Cny, Stock_Ccp_3M_Cny, Stock_Ccp_Ndm, Stock_Ccp_Ndm_Usd, Stock_Ccp_Ndm_Eur, Stock_Ccp_Fk_D, Stock_Ccp_Fk_2, Stock_Ccp_Fk_2W, Stock_Ccp_Fk_5W, Stock_Ccp_Fk_M, Stock_Ccp_Fk_2M, Stock_Ccp_Fk_3M, Stock_Ccp_Fk_6, Stock_Ccp_Fk_1Y, Stock_Ccp_Fr_Repo_1D, Stock_Ccp_Fr_Repo_1W, Stock_Ccp_Fr_Repo_2W, Stock_Ccp_Fr_Repo_5W, Stock_Ccp_Fr_Repo_1M, Stock_Ccp_Fr_Repo_3M, Stock_Ccp_R_1D, Stock_Ccp_R_1W, Stock_Ccp_R_2W, Stock_Ccp_R_1M, Stock_Ccp_R_5W, Stock_Deposit_Order, Stock_Deposit_Off_Order, Stock_Deposit_Off_Order_Usd, Stock_Deposit_Off_Order_Eur, Stock_Deposit_Order_Usd, Stock_Deposit_Order_Eur, Stock_Deposit_Order_Cny, Stock_Deposit_Off_Order_Cny, Stock_Deposit_Close_Auct, Stock_Repo_Interdealer_M, Stock_Shares_Repo, Stock_Repo_Interdealer_Rub, Stock_Repo_Interdealer_Usd, Stock_Repo_Interdealer_Eur, Stock_Bond_Repo, Stock_Repo_Cc, Stock_Qnv_Tplus, Stock_Qnv_Main, Stock_Qnv_Ndm, Stock_Qnv_Ndm_Tplus, Stock_Qnv_Repo, Stock_Qnv_Tplus_Usd, Stock_Mamc_Liq, Stock_Nonresmamc_Liq, Stock_Foreignshares_Tplus_Hkd, Stock_Foreign_Shares, Stock_Foreignshares_Tplus_Usd, Stock_Foreignshares_Tplus_Cny, Stock_Foreign_Ccp_Hkd, Stock_Foreign_Ndm_Hkd, Stock_Foreign_Ccp, Stock_Foreignndm_Usd, Stock_Foreign_Ccp_Cny, Stock_Foreign_Ndm_Cny, Stock_Foreign_Ndm, Stock_Foreignndm_Ccp_Usd, Stock_Moexboard, Stock_Gcc_D, Stock_Gcc_W, Stock_Gcc_2W, Stock_Gcc_M, Stock_Gcc_2M, Stock_Gcc_3M, Stock_Gcc_6M, Stock_Gcc_1Y, Stock_Gcc_Ndm, Stock_Gcc_D_Usd, Stock_Gcc_W_Usd, Stock_Gcc_2W_Usd, Stock_Gcc_M_Usd, Stock_Gcc_2M_Usd, Stock_Gcc_3M_Usd, Stock_Gcc_6M_Usd, Stock_Gcc_1Y_Usd, Stock_Gcc_Ndm_Usd, Stock_Gcc_D_Eur, Stock_Gcc_W_Eur, Stock_Gcc_2W_Eur, Stock_Gcc_M_Eur, Stock_Gcc_2M_Eur, Stock_Gcc_3M_Eur, Stock_Gcc_6M_Eur, Stock_Gcc_1Y_Eur, Stock_Gcc_Ndm_Eur, Stock_Ccp_9M, Stock_Ccp_9M_Usd, Stock_Ccp_9M_Eur, Stock_Gcc_D_Cny, Stock_Gcc_W_Cny, Stock_Gcc_2W_Cny, Stock_Gcc_1M_Cny, Stock_Gcc_2M_Cny, Stock_Gcc_3M_Cny, Stock_Gcc_6M_Cny, Stock_Gcc_9M_Cny, Stock_Gcc_1Y_Cny, Stock_Gcc_Ndm_Cny, Stock_Gcc_Fl_1W_Rub, Stock_Gcc_Fl_2W_Rub, Stock_Gcc_Fl_1M_Rub, Stock_Gcc_Fl_2M_Rub, Stock_Gcc_Fl_3M_Rub, Stock_Gcc_Fl_6M_Rub, Stock_Gcc_Fl_9M_Rub, Stock_Gcc_Fl_1Y_Rub, Stock_Gcc_Fl_1W_Cny, Stock_Gcc_Fl_2W_Cny, Stock_Gcc_Fl_1M_Cny, Stock_Gcc_Fl_2M_Cny, Stock_Gcc_Fl_3M_Cny, Stock_Gcc_Fl_6M_Cny, Stock_Gcc_Fl_9M_Cny, Stock_Gcc_Fl_1Y_Cny, Stock_Gcc_Fl_Rr_1M_Rub, Stock_Gcc_Fl_Rr_3M_Rub, Stock_Credit_Rub, Stock_Credit_Usd, Stock_Credit_Eur, Stock_Credit_Cny, Stock_Nonresndm_Shares_Tplus_Rub, Stock_Nonresndm_Shares_Tplus_Usd, Stock_Nonresndm_Shares_Tplus_Eur, Stock_Nonresndm_Bonds_Tplus_Rub, Stock_Nonresndm_Bonds_Tplus_Cny, Stock_Nonresndm_Bonds_Tplus_Usd, Stock_Nonresndm_Bonds_Tplus_Eur, Stock_Nonresrepo_Interdealer_Rub, Stock_Nonresrepo_Interdealer_Usd, Stock_Nonresrepo_Interdealer_Eur, Stock_Nonresrepo_Interdealer_Cny, Stock_Nonresccp_Liq, Stock_Standard, Standard_Ndm, Stock_Standard_Repo, Stock_Classica, Stock_Classica_Ndm, State_Index, State, Dealer_Dealer, State_Ndm, Currency, Currency_Ndm, Currency_Selt_Licu, Currency_Fixing, Currency_Fixing_Ndm, Currency_Selt_Waps, Currency_Selt_Wapn, Currency_Selt_Cbr, Currency_Selt_Settle, Currency_Futures, Currency_Futures_Ndm, Currency_Index, Currency_Otc_Liquidity, Currency_Otc_Darkpools, Futures, Futures_Forts, Futures_Options, Futures_Fortsiqs, Futures_Optionsiqs, Commodity_Futures, Interventions_Grain, Offboard_Bond_All, Agro_Sugar_All, Agro_Auctions_All, Agro_Buyauctions_All, Otc_Shares_Tplus, Otc_Bonds_Tplus, Otc_Bonds_Tplus_Usd, Otc_Ndm_Ccp_Shares_Rub, Otc_Ndm_Shares_Issuance, Otc_Ndm_Shares_Buyback, Otc_Ndm_Ccp_Rub, Otc_Ndm_Ccp_Usd, Otc_Ndm_Ccp_Cny, Otc_Bondsndm_Ccp_Ndm_Rub, Otc_Bondsndm_Ccp_Ndm_Cny, Otc_Bondsndm_Ccp_Ndm_Usd, Quotes_Bonds,  };


    }
}