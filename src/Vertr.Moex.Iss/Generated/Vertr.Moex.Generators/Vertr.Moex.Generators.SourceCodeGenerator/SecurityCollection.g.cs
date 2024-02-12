namespace Vertr.Moex.Iss.Entities
{
    public partial class SecurityCollection
    {
    
        /// <summary>
        /// Все индексы
        /// </summary>
        public static readonly SecurityCollection Stock_Index_All = new SecurityCollection
        {
            Id = 72,
            Name = "stock_index_all",
            Title = "Все индексы",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Основные индексы акций
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Shares = new SecurityCollection
        {
            Id = 213,
            Name = "stock_index_shares",
            Title = "Основные индексы акций",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Отраслевые индексы акций
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Shares_Sectoral = new SecurityCollection
        {
            Id = 210,
            Name = "stock_index_shares_sectoral",
            Title = "Отраслевые индексы акций",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Индексы акций полной доходности
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Total_Return = new SecurityCollection
        {
            Id = 249,
            Name = "stock_index_total_return",
            Title = "Индексы акций полной доходности",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Тематические индексы акций
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Shares_Thematic = new SecurityCollection
        {
            Id = 211,
            Name = "stock_index_shares_thematic",
            Title = "Тематические индексы акций",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Основные индексы облигаций
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Bonds = new SecurityCollection
        {
            Id = 207,
            Name = "stock_index_bonds",
            Title = "Основные индексы облигаций",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Индексы государственных облигаций
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Bonds_State = new SecurityCollection
        {
            Id = 214,
            Name = "stock_index_bonds_state",
            Title = "Индексы государственных облигаций",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Индексы корпоративных облигаций
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Bonds_Corporate = new SecurityCollection
        {
            Id = 208,
            Name = "stock_index_bonds_corporate",
            Title = "Индексы корпоративных облигаций",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Индексы муниципальных облигаций
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Bonds_Municipal = new SecurityCollection
        {
            Id = 212,
            Name = "stock_index_bonds_municipal",
            Title = "Индексы муниципальных облигаций",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Индексы активов пенсионных накоплений
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Bonds_Retiring = new SecurityCollection
        {
            Id = 209,
            Name = "stock_index_bonds_retiring",
            Title = "Индексы активов пенсионных накоплений",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Индексы еврооблигаций
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Eurobonds = new SecurityCollection
        {
            Id = 328,
            Name = "stock_index_eurobonds",
            Title = "Индексы еврооблигаций",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Российские индексы волатильности
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Volatility = new SecurityCollection
        {
            Id = 215,
            Name = "stock_index_volatility",
            Title = "Российские индексы волатильности",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// INAV
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Inav = new SecurityCollection
        {
            Id = 259,
            Name = "stock_index_inav",
            Title = "INAV",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Индикаторы ставок РЕПО
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Repo = new SecurityCollection
        {
            Id = 115,
            Name = "stock_index_repo",
            Title = "Индикаторы ставок РЕПО",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Ценовые фиксинги
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Pf = new SecurityCollection
        {
            Id = 329,
            Name = "stock_index_pf",
            Title = "Ценовые фиксинги",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Money market index
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Mmix = new SecurityCollection
        {
            Id = 295,
            Name = "stock_index_mmix",
            Title = "Money market index",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Облигационные индексы котировальных листов
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Quotationlist_Bond = new SecurityCollection
        {
            Id = 229,
            Name = "stock_index_quotationlist_bond",
            Title = "Облигационные индексы котировальных листов",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Товарные индексы
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Commodity = new SecurityCollection
        {
            Id = 324,
            Name = "stock_index_commodity",
            Title = "Товарные индексы",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Индексы СПФИ
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Sdfi = new SecurityCollection
        {
            Id = 323,
            Name = "stock_index_sdfi",
            Title = "Индексы СПФИ",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Заказные индексы
        /// </summary>
        public static readonly SecurityCollection Stock_Index_Custom = new SecurityCollection
        {
            Id = 327,
            Name = "stock_index_custom",
            Title = "Заказные индексы",
            SecurityGroupId = 12,
        };


        /// <summary>
        /// Все акции
        /// </summary>
        public static readonly SecurityCollection Stock_Shares_All = new SecurityCollection
        {
            Id = 3,
            Name = "stock_shares_all",
            Title = "Все акции",
            SecurityGroupId = 4,
        };


        /// <summary>
        /// Уровень 1
        /// </summary>
        public static readonly SecurityCollection Stock_Shares_One = new SecurityCollection
        {
            Id = 160,
            Name = "stock_shares_one",
            Title = "Уровень 1",
            SecurityGroupId = 4,
        };


        /// <summary>
        /// Уровень 2
        /// </summary>
        public static readonly SecurityCollection Stock_Shares_Two = new SecurityCollection
        {
            Id = 161,
            Name = "stock_shares_two",
            Title = "Уровень 2",
            SecurityGroupId = 4,
        };


        /// <summary>
        /// Уровень 3
        /// </summary>
        public static readonly SecurityCollection Stock_Shares_Three = new SecurityCollection
        {
            Id = 162,
            Name = "stock_shares_three",
            Title = "Уровень 3",
            SecurityGroupId = 4,
        };


        /// <summary>
        /// Все
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_All = new SecurityCollection
        {
            Id = 7,
            Name = "stock_bonds_all",
            Title = "Все",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все уровень 1
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_One = new SecurityCollection
        {
            Id = 163,
            Name = "stock_bonds_one",
            Title = "Все уровень 1",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все уровень 2
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Two = new SecurityCollection
        {
            Id = 164,
            Name = "stock_bonds_two",
            Title = "Все уровень 2",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все уровень 3
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Three = new SecurityCollection
        {
            Id = 165,
            Name = "stock_bonds_three",
            Title = "Все уровень 3",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все корпоративные
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Corp_All = new SecurityCollection
        {
            Id = 189,
            Name = "stock_bonds_corp_all",
            Title = "Все корпоративные",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Корпоративные уровень 1
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Corp_One = new SecurityCollection
        {
            Id = 202,
            Name = "stock_bonds_corp_one",
            Title = "Корпоративные уровень 1",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Корпоративные уровень 2
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Corp_Two = new SecurityCollection
        {
            Id = 194,
            Name = "stock_bonds_corp_two",
            Title = "Корпоративные уровень 2",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Корпоративные уровень 3
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Corp_Three = new SecurityCollection
        {
            Id = 188,
            Name = "stock_bonds_corp_three",
            Title = "Корпоративные уровень 3",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все биржевые
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Exchange_All = new SecurityCollection
        {
            Id = 200,
            Name = "stock_bonds_exchange_all",
            Title = "Все биржевые",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Биржевые уровень 1
        /// </summary>
        public static readonly SecurityCollection Stock_Exchange_Corp_One = new SecurityCollection
        {
            Id = 185,
            Name = "stock_exchange_corp_one",
            Title = "Биржевые уровень 1",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Биржевые уровень 2
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Exchange_Two = new SecurityCollection
        {
            Id = 195,
            Name = "stock_bonds_exchange_two",
            Title = "Биржевые уровень 2",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Биржевые уровень 3
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Exchange_Three = new SecurityCollection
        {
            Id = 190,
            Name = "stock_bonds_exchange_three",
            Title = "Биржевые уровень 3",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все муниципальные
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Municipal_All = new SecurityCollection
        {
            Id = 205,
            Name = "stock_bonds_municipal_all",
            Title = "Все муниципальные",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Муниципальные уровень 1
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Municipal_One = new SecurityCollection
        {
            Id = 201,
            Name = "stock_bonds_municipal_one",
            Title = "Муниципальные уровень 1",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Муниципальные уровень 2
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Municipal_Two = new SecurityCollection
        {
            Id = 191,
            Name = "stock_bonds_municipal_two",
            Title = "Муниципальные уровень 2",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Муниципальные уровень 3
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Municipal_Three = new SecurityCollection
        {
            Id = 203,
            Name = "stock_bonds_municipal_three",
            Title = "Муниципальные уровень 3",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все субъектов РФ
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Subfederal_All = new SecurityCollection
        {
            Id = 198,
            Name = "stock_bonds_subfederal_all",
            Title = "Все субъектов РФ",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Субъектов РФ уровень 1
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Subfederal_One = new SecurityCollection
        {
            Id = 206,
            Name = "stock_bonds_subfederal_one",
            Title = "Субъектов РФ уровень 1",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Субъектов РФ уровень 2
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Subfederal_Two = new SecurityCollection
        {
            Id = 204,
            Name = "stock_bonds_subfederal_two",
            Title = "Субъектов РФ уровень 2",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Субъектов РФ уровень 3
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Subfederal_Three = new SecurityCollection
        {
            Id = 192,
            Name = "stock_bonds_subfederal_three",
            Title = "Субъектов РФ уровень 3",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все ОФЗ
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Ofz_All = new SecurityCollection
        {
            Id = 186,
            Name = "stock_bonds_ofz_all",
            Title = "Все ОФЗ",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все Банка России
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Cb_All = new SecurityCollection
        {
            Id = 193,
            Name = "stock_bonds_cb_all",
            Title = "Все Банка России",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все иностранных эмитентов
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Ifi_All = new SecurityCollection
        {
            Id = 197,
            Name = "stock_bonds_ifi_all",
            Title = "Все иностранных эмитентов",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Иностранных эмитентов уровень 1
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Ifi_One = new SecurityCollection
        {
            Id = 199,
            Name = "stock_bonds_ifi_one",
            Title = "Иностранных эмитентов уровень 1",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Иностранных эмитентов уровень 2
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Ifi_Two = new SecurityCollection
        {
            Id = 187,
            Name = "stock_bonds_ifi_two",
            Title = "Иностранных эмитентов уровень 2",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Иностранных эмитентов уровень 3
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Ifi_Three = new SecurityCollection
        {
            Id = 196,
            Name = "stock_bonds_ifi_three",
            Title = "Иностранных эмитентов уровень 3",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все Коммерческие
        /// </summary>
        public static readonly SecurityCollection Offboard_Bonds_All = new SecurityCollection
        {
            Id = 303,
            Name = "offboard_bonds_all",
            Title = "Все Коммерческие",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Замещающие облигации
        /// </summary>
        public static readonly SecurityCollection Stock_Bonds_Replacements = new SecurityCollection
        {
            Id = 1315,
            Name = "stock_bonds_replacements",
            Title = "Замещающие облигации",
            SecurityGroupId = 3,
        };


        /// <summary>
        /// Все валюты СПОТ
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_All_Spot = new SecurityCollection
        {
            Id = 177,
            Name = "currency_selt_all_spot",
            Title = "Все валюты СПОТ",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// Все валюты СВОП
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_All_Swap = new SecurityCollection
        {
            Id = 170,
            Name = "currency_selt_all_swap",
            Title = "Все валюты СВОП",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// USD/RUB СПОТ
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Usd_Spot = new SecurityCollection
        {
            Id = 173,
            Name = "currency_selt_usd_spot",
            Title = "USD/RUB СПОТ",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// USD/RUB СВОП
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Usd_Swap = new SecurityCollection
        {
            Id = 174,
            Name = "currency_selt_usd_swap",
            Title = "USD/RUB СВОП",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// EUR/RUB СПОТ
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Eur_Spot = new SecurityCollection
        {
            Id = 172,
            Name = "currency_selt_eur_spot",
            Title = "EUR/RUB СПОТ",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// EUR/RUB СВОП
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Eur_Swap = new SecurityCollection
        {
            Id = 179,
            Name = "currency_selt_eur_swap",
            Title = "EUR/RUB СВОП",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// CNY/RUB СПОТ
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Cny_Spot = new SecurityCollection
        {
            Id = 181,
            Name = "currency_selt_cny_spot",
            Title = "CNY/RUB СПОТ",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// CNY/RUB СВОП
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Cny_Swap = new SecurityCollection
        {
            Id = 176,
            Name = "currency_selt_cny_swap",
            Title = "CNY/RUB СВОП",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// EUR/USD СПОТ
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Eurusd_Spot = new SecurityCollection
        {
            Id = 178,
            Name = "currency_selt_eurusd_spot",
            Title = "EUR/USD СПОТ",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// EUR/USD СВОП
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Eurusd_Swap = new SecurityCollection
        {
            Id = 180,
            Name = "currency_selt_eurusd_swap",
            Title = "EUR/USD СВОП",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// Другие валюты СПОТ
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Other_Spot = new SecurityCollection
        {
            Id = 171,
            Name = "currency_selt_other_spot",
            Title = "Другие валюты СПОТ",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// Другие валюты СВОП
        /// </summary>
        public static readonly SecurityCollection Currency_Selt_Other_Swap = new SecurityCollection
        {
            Id = 175,
            Name = "currency_selt_other_swap",
            Title = "Другие валюты СВОП",
            SecurityGroupId = 9,
        };


        /// <summary>
        /// Все фьючерсы
        /// </summary>
        public static readonly SecurityCollection Futures_Forts_All = new SecurityCollection
        {
            Id = 227,
            Name = "futures_forts_all",
            Title = "Все фьючерсы",
            SecurityGroupId = 10,
        };


        /// <summary>
        /// Фьючерсы на индексы
        /// </summary>
        public static readonly SecurityCollection Futures_Forts_Index = new SecurityCollection
        {
            Id = 226,
            Name = "futures_forts_index",
            Title = "Фьючерсы на индексы",
            SecurityGroupId = 10,
        };


        /// <summary>
        /// Фьючерсы на акции
        /// </summary>
        public static readonly SecurityCollection Futures_Forts_Shares = new SecurityCollection
        {
            Id = 224,
            Name = "futures_forts_shares",
            Title = "Фьючерсы на акции",
            SecurityGroupId = 10,
        };


        /// <summary>
        /// Фьючерсы на валюты
        /// </summary>
        public static readonly SecurityCollection Futures_Forts_Currency = new SecurityCollection
        {
            Id = 225,
            Name = "futures_forts_currency",
            Title = "Фьючерсы на валюты",
            SecurityGroupId = 10,
        };


        /// <summary>
        /// Фьючерсы на процентные ставки
        /// </summary>
        public static readonly SecurityCollection Futures_Forts_Interest = new SecurityCollection
        {
            Id = 228,
            Name = "futures_forts_interest",
            Title = "Фьючерсы на процентные ставки",
            SecurityGroupId = 10,
        };


        /// <summary>
        /// Фьючерсы на товарные контракты
        /// </summary>
        public static readonly SecurityCollection Futures_Forts_Commodity = new SecurityCollection
        {
            Id = 223,
            Name = "futures_forts_commodity",
            Title = "Фьючерсы на товарные контракты",
            SecurityGroupId = 10,
        };


        /// <summary>
        /// Фьючерсы на ОФЗ
        /// </summary>
        public static readonly SecurityCollection Futures_Forts_Ofz = new SecurityCollection
        {
            Id = 260,
            Name = "futures_forts_ofz",
            Title = "Фьючерсы на ОФЗ",
            SecurityGroupId = 10,
        };


        /// <summary>
        /// Все опционы
        /// </summary>
        public static readonly SecurityCollection Futures_Options_All = new SecurityCollection
        {
            Id = 218,
            Name = "futures_options_all",
            Title = "Все опционы",
            SecurityGroupId = 26,
        };


        /// <summary>
        /// Опционы ф. на индекс
        /// </summary>
        public static readonly SecurityCollection Futures_Options_Index = new SecurityCollection
        {
            Id = 222,
            Name = "futures_options_index",
            Title = "Опционы ф. на индекс",
            SecurityGroupId = 26,
        };


        /// <summary>
        /// Опционы ф. на акции
        /// </summary>
        public static readonly SecurityCollection Futures_Options_Shares = new SecurityCollection
        {
            Id = 221,
            Name = "futures_options_shares",
            Title = "Опционы ф. на акции",
            SecurityGroupId = 26,
        };


        /// <summary>
        /// Опционы ф. на валюты
        /// </summary>
        public static readonly SecurityCollection Futures_Options_Currency = new SecurityCollection
        {
            Id = 220,
            Name = "futures_options_currency",
            Title = "Опционы ф. на валюты",
            SecurityGroupId = 26,
        };


        /// <summary>
        /// Опционы ф. на товарные контракты
        /// </summary>
        public static readonly SecurityCollection Futures_Options_Commodity = new SecurityCollection
        {
            Id = 219,
            Name = "futures_options_commodity",
            Title = "Опционы ф. на товарные контракты",
            SecurityGroupId = 26,
        };


        /// <summary>
        /// Все ДР
        /// </summary>
        public static readonly SecurityCollection Stock_Dr_All = new SecurityCollection
        {
            Id = 130,
            Name = "stock_dr_all",
            Title = "Все ДР",
            SecurityGroupId = 18,
        };


        /// <summary>
        /// Иностранные ц.б.
        /// </summary>
        public static readonly SecurityCollection Stock_Foreign_Shares_All = new SecurityCollection
        {
            Id = 301,
            Name = "stock_foreign_shares_all",
            Title = "Иностранные ц.б.",
            SecurityGroupId = 33,
        };


        /// <summary>
        /// Все
        /// </summary>
        public static readonly SecurityCollection Stock_Eurobond_All = new SecurityCollection
        {
            Id = 60,
            Name = "stock_eurobond_all",
            Title = "Все",
            SecurityGroupId = 6,
        };


        /// <summary>
        /// Уровень 1
        /// </summary>
        public static readonly SecurityCollection Stock_Eurobond_One = new SecurityCollection
        {
            Id = 184,
            Name = "stock_eurobond_one",
            Title = "Уровень 1",
            SecurityGroupId = 6,
        };


        /// <summary>
        /// Уровень 2
        /// </summary>
        public static readonly SecurityCollection Stock_Eurobond_Two = new SecurityCollection
        {
            Id = 182,
            Name = "stock_eurobond_two",
            Title = "Уровень 2",
            SecurityGroupId = 6,
        };


        /// <summary>
        /// Уровень 3
        /// </summary>
        public static readonly SecurityCollection Stock_Eurobond_Three = new SecurityCollection
        {
            Id = 183,
            Name = "stock_eurobond_three",
            Title = "Уровень 3",
            SecurityGroupId = 6,
        };


        /// <summary>
        /// Все ПИФы
        /// </summary>
        public static readonly SecurityCollection Stock_Ppif_All = new SecurityCollection
        {
            Id = 59,
            Name = "stock_ppif_all",
            Title = "Все ПИФы",
            SecurityGroupId = 5,
        };


        /// <summary>
        /// Уровень 1
        /// </summary>
        public static readonly SecurityCollection Stock_Ppif_One = new SecurityCollection
        {
            Id = 166,
            Name = "stock_ppif_one",
            Title = "Уровень 1",
            SecurityGroupId = 5,
        };


        /// <summary>
        /// Уровень 2
        /// </summary>
        public static readonly SecurityCollection Stock_Ppif_Two = new SecurityCollection
        {
            Id = 167,
            Name = "stock_ppif_two",
            Title = "Уровень 2",
            SecurityGroupId = 5,
        };


        /// <summary>
        /// Уровень 3
        /// </summary>
        public static readonly SecurityCollection Stock_Ppif_Three = new SecurityCollection
        {
            Id = 168,
            Name = "stock_ppif_three",
            Title = "Уровень 3",
            SecurityGroupId = 5,
        };


        /// <summary>
        /// Все паи иностранных фондов
        /// </summary>
        public static readonly SecurityCollection Stock_Etf_All = new SecurityCollection
        {
            Id = 151,
            Name = "stock_etf_all",
            Title = "Все паи иностранных фондов",
            SecurityGroupId = 20,
        };


        /// <summary>
        /// Золото
        /// </summary>
        public static readonly SecurityCollection Currency_Metal_Gold = new SecurityCollection
        {
            Id = 216,
            Name = "currency_metal_gold",
            Title = "Золото",
            SecurityGroupId = 24,
        };


        /// <summary>
        /// Серебро
        /// </summary>
        public static readonly SecurityCollection Currency_Metal_Silver = new SecurityCollection
        {
            Id = 217,
            Name = "currency_metal_silver",
            Title = "Серебро",
            SecurityGroupId = 24,
        };


        /// <summary>
        /// Все квал. инвесторы
        /// </summary>
        public static readonly SecurityCollection Stock_Qnv_All = new SecurityCollection
        {
            Id = 152,
            Name = "stock_qnv_all",
            Title = "Все квал. инвесторы",
            SecurityGroupId = 21,
        };


        /// <summary>
        /// Клиринговые сертификаты участия
        /// </summary>
        public static readonly SecurityCollection Stock_Gcc_All = new SecurityCollection
        {
            Id = 230,
            Name = "stock_gcc_all",
            Title = "Клиринговые сертификаты участия",
            SecurityGroupId = 27,
        };


        /// <summary>
        /// Депозиты с ЦК
        /// </summary>
        public static readonly SecurityCollection Stock_Deposit_All = new SecurityCollection
        {
            Id = 258,
            Name = "stock_deposit_all",
            Title = "Депозиты с ЦК",
            SecurityGroupId = 29,
        };


        /// <summary>
        /// Все валюты поставочные СВОП КОНТРАКТЫ
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Swap_All = new SecurityCollection
        {
            Id = 286,
            Name = "currency_futures_swap_all",
            Title = "Все валюты поставочные СВОП КОНТРАКТЫ",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// Все валюты поставочные ФЬЮЧЕРСЫ
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Delivery_All = new SecurityCollection
        {
            Id = 254,
            Name = "currency_futures_delivery_all",
            Title = "Все валюты поставочные ФЬЮЧЕРСЫ",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// USD/RUB поставочный СВОП КОНТРАКТ
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Swap_Usd = new SecurityCollection
        {
            Id = 287,
            Name = "currency_futures_swap_usd",
            Title = "USD/RUB поставочный СВОП КОНТРАКТ",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// USD/RUB поставочный ФЬЮЧЕРС
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Delivery_Usd = new SecurityCollection
        {
            Id = 252,
            Name = "currency_futures_delivery_usd",
            Title = "USD/RUB поставочный ФЬЮЧЕРС",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// EUR/RUB поставочный СВОП КОНТРАКТ
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Swap_Eur = new SecurityCollection
        {
            Id = 288,
            Name = "currency_futures_swap_eur",
            Title = "EUR/RUB поставочный СВОП КОНТРАКТ",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// EUR/RUB поставочный ФЬЮЧЕРС
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Delivery_Eur = new SecurityCollection
        {
            Id = 255,
            Name = "currency_futures_delivery_eur",
            Title = "EUR/RUB поставочный ФЬЮЧЕРС",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// CNY/RUB поставочный СВОП КОНТРАКТ
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Swap_Cny = new SecurityCollection
        {
            Id = 289,
            Name = "currency_futures_swap_cny",
            Title = "CNY/RUB поставочный СВОП КОНТРАКТ",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// CNY/RUB поставочный ФЬЮЧЕРС
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Delivery_Cny = new SecurityCollection
        {
            Id = 250,
            Name = "currency_futures_delivery_cny",
            Title = "CNY/RUB поставочный ФЬЮЧЕРС",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// Другие валюты поставочный СВОП КОНТРАКТ
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Swap_Other = new SecurityCollection
        {
            Id = 292,
            Name = "currency_futures_swap_other",
            Title = "Другие валюты поставочный СВОП КОНТРАКТ",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// Другие валюты поставочный ФЬЮЧЕРС
        /// </summary>
        public static readonly SecurityCollection Currency_Futures_Delivery_Others = new SecurityCollection
        {
            Id = 293,
            Name = "currency_futures_delivery_others",
            Title = "Другие валюты поставочный ФЬЮЧЕРС",
            SecurityGroupId = 28,
        };


        /// <summary>
        /// Все валютные фиксинги
        /// </summary>
        public static readonly SecurityCollection Currency_Indices_All = new SecurityCollection
        {
            Id = 297,
            Name = "currency_indices_all",
            Title = "Все валютные фиксинги",
            SecurityGroupId = 31,
        };


     
        public static SecurityCollection[] All = new SecurityCollection[] { Stock_Index_All, Stock_Index_Shares, Stock_Index_Shares_Sectoral, Stock_Index_Total_Return, Stock_Index_Shares_Thematic, Stock_Index_Bonds, Stock_Index_Bonds_State, Stock_Index_Bonds_Corporate, Stock_Index_Bonds_Municipal, Stock_Index_Bonds_Retiring, Stock_Index_Eurobonds, Stock_Index_Volatility, Stock_Index_Inav, Stock_Index_Repo, Stock_Index_Pf, Stock_Index_Mmix, Stock_Index_Quotationlist_Bond, Stock_Index_Commodity, Stock_Index_Sdfi, Stock_Index_Custom, Stock_Shares_All, Stock_Shares_One, Stock_Shares_Two, Stock_Shares_Three, Stock_Bonds_All, Stock_Bonds_One, Stock_Bonds_Two, Stock_Bonds_Three, Stock_Bonds_Corp_All, Stock_Bonds_Corp_One, Stock_Bonds_Corp_Two, Stock_Bonds_Corp_Three, Stock_Bonds_Exchange_All, Stock_Exchange_Corp_One, Stock_Bonds_Exchange_Two, Stock_Bonds_Exchange_Three, Stock_Bonds_Municipal_All, Stock_Bonds_Municipal_One, Stock_Bonds_Municipal_Two, Stock_Bonds_Municipal_Three, Stock_Bonds_Subfederal_All, Stock_Bonds_Subfederal_One, Stock_Bonds_Subfederal_Two, Stock_Bonds_Subfederal_Three, Stock_Bonds_Ofz_All, Stock_Bonds_Cb_All, Stock_Bonds_Ifi_All, Stock_Bonds_Ifi_One, Stock_Bonds_Ifi_Two, Stock_Bonds_Ifi_Three, Offboard_Bonds_All, Stock_Bonds_Replacements, Currency_Selt_All_Spot, Currency_Selt_All_Swap, Currency_Selt_Usd_Spot, Currency_Selt_Usd_Swap, Currency_Selt_Eur_Spot, Currency_Selt_Eur_Swap, Currency_Selt_Cny_Spot, Currency_Selt_Cny_Swap, Currency_Selt_Eurusd_Spot, Currency_Selt_Eurusd_Swap, Currency_Selt_Other_Spot, Currency_Selt_Other_Swap, Futures_Forts_All, Futures_Forts_Index, Futures_Forts_Shares, Futures_Forts_Currency, Futures_Forts_Interest, Futures_Forts_Commodity, Futures_Forts_Ofz, Futures_Options_All, Futures_Options_Index, Futures_Options_Shares, Futures_Options_Currency, Futures_Options_Commodity, Stock_Dr_All, Stock_Foreign_Shares_All, Stock_Eurobond_All, Stock_Eurobond_One, Stock_Eurobond_Two, Stock_Eurobond_Three, Stock_Ppif_All, Stock_Ppif_One, Stock_Ppif_Two, Stock_Ppif_Three, Stock_Etf_All, Currency_Metal_Gold, Currency_Metal_Silver, Stock_Qnv_All, Stock_Gcc_All, Stock_Deposit_All, Currency_Futures_Swap_All, Currency_Futures_Delivery_All, Currency_Futures_Swap_Usd, Currency_Futures_Delivery_Usd, Currency_Futures_Swap_Eur, Currency_Futures_Delivery_Eur, Currency_Futures_Swap_Cny, Currency_Futures_Delivery_Cny, Currency_Futures_Swap_Other, Currency_Futures_Delivery_Others, Currency_Indices_All,  };


    }
}