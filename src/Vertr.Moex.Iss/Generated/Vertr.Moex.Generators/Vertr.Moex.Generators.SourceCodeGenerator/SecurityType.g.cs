namespace Vertr.Moex.Iss.Entities
{
    public partial class SecurityType
    {
    
        /// <summary>
        /// Акция обыкновенная
        /// </summary>
        public static readonly SecurityType Common_Share = new SecurityType
        {
            Id = 3,
            Name = "common_share",
            Title = "Акция обыкновенная",
            EngineId = 1,
            GroupName = "stock_shares",
            StockType = "1",
        };


        /// <summary>
        /// Акция привилегированная 
        /// </summary>
        public static readonly SecurityType Preferred_Share = new SecurityType
        {
            Id = 1,
            Name = "preferred_share",
            Title = "Акция привилегированная ",
            EngineId = 1,
            GroupName = "stock_shares",
            StockType = "2",
        };


        /// <summary>
        /// Депозитарная расписка
        /// </summary>
        public static readonly SecurityType Depositary_Receipt = new SecurityType
        {
            Id = 51,
            Name = "depositary_receipt",
            Title = "Депозитарная расписка",
            EngineId = 1,
            GroupName = "stock_dr",
            StockType = "D",
        };


        /// <summary>
        /// Государственная облигация
        /// </summary>
        public static readonly SecurityType Ofz_Bond = new SecurityType
        {
            Id = 54,
            Name = "ofz_bond",
            Title = "Государственная облигация",
            EngineId = 1,
            GroupName = "stock_bonds",
            StockType = "3",
        };


        /// <summary>
        /// Облигация центрального банка
        /// </summary>
        public static readonly SecurityType Cb_Bond = new SecurityType
        {
            Id = 4,
            Name = "cb_bond",
            Title = "Облигация центрального банка",
            EngineId = 1,
            GroupName = "stock_bonds",
            StockType = "5",
        };


        /// <summary>
        /// Региональная облигация
        /// </summary>
        public static readonly SecurityType Subfederal_Bond = new SecurityType
        {
            Id = 41,
            Name = "subfederal_bond",
            Title = "Региональная облигация",
            EngineId = 1,
            GroupName = "stock_bonds",
            StockType = "4",
        };


        /// <summary>
        /// Муниципальная облигация
        /// </summary>
        public static readonly SecurityType Municipal_Bond = new SecurityType
        {
            Id = 45,
            Name = "municipal_bond",
            Title = "Муниципальная облигация",
            EngineId = 1,
            GroupName = "stock_bonds",
            StockType = "C",
        };


        /// <summary>
        /// Корпоративная облигация
        /// </summary>
        public static readonly SecurityType Corporate_Bond = new SecurityType
        {
            Id = 2,
            Name = "corporate_bond",
            Title = "Корпоративная облигация",
            EngineId = 1,
            GroupName = "stock_bonds",
            StockType = "6",
        };


        /// <summary>
        /// Биржевая облигация
        /// </summary>
        public static readonly SecurityType Exchange_Bond = new SecurityType
        {
            Id = 43,
            Name = "exchange_bond",
            Title = "Биржевая облигация",
            EngineId = 1,
            GroupName = "stock_bonds",
            StockType = "8",
        };


        /// <summary>
        /// Облигация МФО
        /// </summary>
        public static readonly SecurityType Ifi_Bond = new SecurityType
        {
            Id = 42,
            Name = "ifi_bond",
            Title = "Облигация МФО",
            EngineId = 1,
            GroupName = "stock_bonds",
            StockType = "7",
        };


        /// <summary>
        /// Еврооблигации
        /// </summary>
        public static readonly SecurityType Euro_Bond = new SecurityType
        {
            Id = 60,
            Name = "euro_bond",
            Title = "Еврооблигации",
            EngineId = 1,
            GroupName = "stock_eurobond",
            StockType = "",
        };


        /// <summary>
        /// Пай открытого ПИФа
        /// </summary>
        public static readonly SecurityType Public_Ppif = new SecurityType
        {
            Id = 7,
            Name = "public_ppif",
            Title = "Пай открытого ПИФа",
            EngineId = 1,
            GroupName = "stock_ppif",
            StockType = "9",
        };


        /// <summary>
        /// Пай интервального ПИФа
        /// </summary>
        public static readonly SecurityType Interval_Ppif = new SecurityType
        {
            Id = 8,
            Name = "interval_ppif",
            Title = "Пай интервального ПИФа",
            EngineId = 1,
            GroupName = "stock_ppif",
            StockType = "A",
        };


        /// <summary>
        /// Индекс РТС
        /// </summary>
        public static readonly SecurityType Rts_Index = new SecurityType
        {
            Id = 53,
            Name = "rts_index",
            Title = "Индекс РТС",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// Пай закрытого ПИФа
        /// </summary>
        public static readonly SecurityType Private_Ppif = new SecurityType
        {
            Id = 9,
            Name = "private_ppif",
            Title = "Пай закрытого ПИФа",
            EngineId = 1,
            GroupName = "stock_ppif",
            StockType = "B",
        };


        /// <summary>
        /// Ипотечный сертификат
        /// </summary>
        public static readonly SecurityType Stock_Mortgage = new SecurityType
        {
            Id = 57,
            Name = "stock_mortgage",
            Title = "Ипотечный сертификат",
            EngineId = 1,
            GroupName = "stock_mortgage",
            StockType = "F",
        };


        /// <summary>
        /// ETF
        /// </summary>
        public static readonly SecurityType Etf_Ppif = new SecurityType
        {
            Id = 55,
            Name = "etf_ppif",
            Title = "ETF",
            EngineId = 1,
            GroupName = "stock_etf",
            StockType = "E",
        };


        /// <summary>
        /// Индекс фондового рынка
        /// </summary>
        public static readonly SecurityType Stock_Index = new SecurityType
        {
            Id = 44,
            Name = "stock_index",
            Title = "Индекс фондового рынка",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// Пай биржевого ПИФа
        /// </summary>
        public static readonly SecurityType Exchange_Ppif = new SecurityType
        {
            Id = 74,
            Name = "exchange_ppif",
            Title = "Пай биржевого ПИФа",
            EngineId = 1,
            GroupName = "stock_ppif",
            StockType = "J",
        };


        /// <summary>
        /// Товарный индикатор
        /// </summary>
        public static readonly SecurityType Stock_Index_Ci = new SecurityType
        {
            Id = 89,
            Name = "stock_index_ci",
            Title = "Товарный индикатор",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// Индекс акций
        /// </summary>
        public static readonly SecurityType Stock_Index_Eq = new SecurityType
        {
            Id = 84,
            Name = "stock_index_eq",
            Title = "Индекс акций",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// iNAV смешанный
        /// </summary>
        public static readonly SecurityType Stock_Index_Im = new SecurityType
        {
            Id = 90,
            Name = "stock_index_im",
            Title = "iNAV смешанный",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// Индекс облигаций
        /// </summary>
        public static readonly SecurityType Stock_Index_Fi = new SecurityType
        {
            Id = 85,
            Name = "stock_index_fi",
            Title = "Индекс облигаций",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// iNAV акций
        /// </summary>
        public static readonly SecurityType Stock_Index_Ie = new SecurityType
        {
            Id = 87,
            Name = "stock_index_ie",
            Title = "iNAV акций",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// Индекс составной
        /// </summary>
        public static readonly SecurityType Stock_Index_Mx = new SecurityType
        {
            Id = 86,
            Name = "stock_index_mx",
            Title = "Индекс составной",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// iNAV облигаций
        /// </summary>
        public static readonly SecurityType Stock_Index_If = new SecurityType
        {
            Id = 88,
            Name = "stock_index_if",
            Title = "iNAV облигаций",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// Индекс НТБ
        /// </summary>
        public static readonly SecurityType Stock_Index_Namex = new SecurityType
        {
            Id = 1030,
            Name = "stock_index_namex",
            Title = "Индекс НТБ",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// RUSFAR
        /// </summary>
        public static readonly SecurityType Stock_Index_Rusfar = new SecurityType
        {
            Id = 1034,
            Name = "stock_index_rusfar",
            Title = "RUSFAR",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// Ценовой фиксинг
        /// </summary>
        public static readonly SecurityType Stock_Index_Pf = new SecurityType
        {
            Id = 1155,
            Name = "stock_index_pf",
            Title = "Ценовой фиксинг",
            EngineId = 1,
            GroupName = "stock_index",
            StockType = "",
        };


        /// <summary>
        /// Депозит с ЦК
        /// </summary>
        public static readonly SecurityType Stock_Deposit = new SecurityType
        {
            Id = 63,
            Name = "stock_deposit",
            Title = "Депозит с ЦК",
            EngineId = 1,
            GroupName = "stock_deposit",
            StockType = "",
        };


        /// <summary>
        /// Коммерческая облигация
        /// </summary>
        public static readonly SecurityType Non_Exchange_Bond = new SecurityType
        {
            Id = 78,
            Name = "non_exchange_bond",
            Title = "Коммерческая облигация",
            EngineId = 1,
            GroupName = "stock_bonds",
            StockType = "",
        };


        /// <summary>
        /// Государственная облигация
        /// </summary>
        public static readonly SecurityType State_Bond = new SecurityType
        {
            Id = 10,
            Name = "state_bond",
            Title = "Государственная облигация",
            EngineId = 2,
            GroupName = "stock_eurobond",
            StockType = "",
        };


        /// <summary>
        /// Валютный фиксинг
        /// </summary>
        public static readonly SecurityType Currency_Index = new SecurityType
        {
            Id = 75,
            Name = "currency_index",
            Title = "Валютный фиксинг",
            EngineId = 3,
            GroupName = "currency_indices",
            StockType = "",
        };


        /// <summary>
        /// Валюта
        /// </summary>
        public static readonly SecurityType Currency = new SecurityType
        {
            Id = 5,
            Name = "currency",
            Title = "Валюта",
            EngineId = 3,
            GroupName = "currency_selt",
            StockType = "",
        };


        /// <summary>
        /// Металл золото
        /// </summary>
        public static readonly SecurityType Gold_Metal = new SecurityType
        {
            Id = 58,
            Name = "gold_metal",
            Title = "Металл золото",
            EngineId = 3,
            GroupName = "currency_metal",
            StockType = "",
        };


        /// <summary>
        /// Металл серебро
        /// </summary>
        public static readonly SecurityType Silver_Metal = new SecurityType
        {
            Id = 59,
            Name = "silver_metal",
            Title = "Металл серебро",
            EngineId = 3,
            GroupName = "currency_metal",
            StockType = "",
        };


        /// <summary>
        /// Валютный фьючерс
        /// </summary>
        public static readonly SecurityType Currency_Futures = new SecurityType
        {
            Id = 62,
            Name = "currency_futures",
            Title = "Валютный фьючерс",
            EngineId = 3,
            GroupName = "currency_futures",
            StockType = "",
        };


        /// <summary>
        /// Валютный фиксинг
        /// </summary>
        public static readonly SecurityType Currency_Fixing = new SecurityType
        {
            Id = 73,
            Name = "currency_fixing",
            Title = "Валютный фиксинг",
            EngineId = 3,
            GroupName = "currency_selt",
            StockType = "",
        };


        /// <summary>
        /// Средневзвешенный курс
        /// </summary>
        public static readonly SecurityType Currency_Wap = new SecurityType
        {
            Id = 76,
            Name = "currency_wap",
            Title = "Средневзвешенный курс",
            EngineId = 3,
            GroupName = "currency_selt",
            StockType = "",
        };


        /// <summary>
        /// Фьючерс
        /// </summary>
        public static readonly SecurityType Futures = new SecurityType
        {
            Id = 6,
            Name = "futures",
            Title = "Фьючерс",
            EngineId = 4,
            GroupName = "futures_forts",
            StockType = "",
        };


        /// <summary>
        /// Опцион
        /// </summary>
        public static readonly SecurityType Option = new SecurityType
        {
            Id = 52,
            Name = "option",
            Title = "Опцион",
            EngineId = 4,
            GroupName = "futures_options",
            StockType = "",
        };


        /// <summary>
        /// Опцион на акции
        /// </summary>
        public static readonly SecurityType Option_On_Shares = new SecurityType
        {
            Id = 1031,
            Name = "option_on_shares",
            Title = "Опцион на акции",
            EngineId = 4,
            GroupName = "futures_options",
            StockType = "",
        };


        /// <summary>
        /// Опцион на валюту
        /// </summary>
        public static readonly SecurityType Option_On_Currency = new SecurityType
        {
            Id = 1291,
            Name = "option_on_currency",
            Title = "Опцион на валюту",
            EngineId = 4,
            GroupName = "futures_options",
            StockType = "",
        };


        /// <summary>
        /// Опцион на индексы
        /// </summary>
        public static readonly SecurityType Option_On_Indices = new SecurityType
        {
            Id = 1293,
            Name = "option_on_indices",
            Title = "Опцион на индексы",
            EngineId = 4,
            GroupName = "futures_options",
            StockType = "",
        };


        /// <summary>
        /// Опцион на товары
        /// </summary>
        public static readonly SecurityType Option_On_Commodities = new SecurityType
        {
            Id = 1295,
            Name = "option_on_commodities",
            Title = "Опцион на товары",
            EngineId = 4,
            GroupName = "futures_options",
            StockType = "",
        };


     
        public static SecurityType[] All = new SecurityType[] { Common_Share, Preferred_Share, Depositary_Receipt, Ofz_Bond, Cb_Bond, Subfederal_Bond, Municipal_Bond, Corporate_Bond, Exchange_Bond, Ifi_Bond, Euro_Bond, Public_Ppif, Interval_Ppif, Rts_Index, Private_Ppif, Stock_Mortgage, Etf_Ppif, Stock_Index, Exchange_Ppif, Stock_Index_Ci, Stock_Index_Eq, Stock_Index_Im, Stock_Index_Fi, Stock_Index_Ie, Stock_Index_Mx, Stock_Index_If, Stock_Index_Namex, Stock_Index_Rusfar, Stock_Index_Pf, Stock_Deposit, Non_Exchange_Bond, State_Bond, Currency_Index, Currency, Gold_Metal, Silver_Metal, Currency_Futures, Currency_Fixing, Currency_Wap, Futures, Option, Option_On_Shares, Option_On_Currency, Option_On_Indices, Option_On_Commodities,  };


    }
}