namespace Vertr.Moex.Iss.Entities
{
    public partial class SecurityGroup
    {
    
        /// <summary>
        /// Индексы
        /// </summary>
        public static readonly SecurityGroup Stock_Index = new SecurityGroup
        {
            Id = 12,
            Name = "stock_index",
            Title = "Индексы",
            IsHidden = false,
        };


        /// <summary>
        /// Акции
        /// </summary>
        public static readonly SecurityGroup Stock_Shares = new SecurityGroup
        {
            Id = 4,
            Name = "stock_shares",
            Title = "Акции",
            IsHidden = false,
        };


        /// <summary>
        /// Облигации
        /// </summary>
        public static readonly SecurityGroup Stock_Bonds = new SecurityGroup
        {
            Id = 3,
            Name = "stock_bonds",
            Title = "Облигации",
            IsHidden = false,
        };


        /// <summary>
        /// Валюта
        /// </summary>
        public static readonly SecurityGroup Currency_Selt = new SecurityGroup
        {
            Id = 9,
            Name = "currency_selt",
            Title = "Валюта",
            IsHidden = false,
        };


        /// <summary>
        /// Фьючерсы
        /// </summary>
        public static readonly SecurityGroup Futures_Forts = new SecurityGroup
        {
            Id = 10,
            Name = "futures_forts",
            Title = "Фьючерсы",
            IsHidden = false,
        };


        /// <summary>
        /// Опционы
        /// </summary>
        public static readonly SecurityGroup Futures_Options = new SecurityGroup
        {
            Id = 26,
            Name = "futures_options",
            Title = "Опционы",
            IsHidden = false,
        };


        /// <summary>
        /// Депозитарные расписки
        /// </summary>
        public static readonly SecurityGroup Stock_Dr = new SecurityGroup
        {
            Id = 18,
            Name = "stock_dr",
            Title = "Депозитарные расписки",
            IsHidden = false,
        };


        /// <summary>
        /// Иностранные ц.б.
        /// </summary>
        public static readonly SecurityGroup Stock_Foreign_Shares = new SecurityGroup
        {
            Id = 33,
            Name = "stock_foreign_shares",
            Title = "Иностранные ц.б.",
            IsHidden = false,
        };


        /// <summary>
        /// Еврооблигации
        /// </summary>
        public static readonly SecurityGroup Stock_Eurobond = new SecurityGroup
        {
            Id = 6,
            Name = "stock_eurobond",
            Title = "Еврооблигации",
            IsHidden = false,
        };


        /// <summary>
        /// Паи ПИФов
        /// </summary>
        public static readonly SecurityGroup Stock_Ppif = new SecurityGroup
        {
            Id = 5,
            Name = "stock_ppif",
            Title = "Паи ПИФов",
            IsHidden = false,
        };


        /// <summary>
        /// Биржевые фонды
        /// </summary>
        public static readonly SecurityGroup Stock_Etf = new SecurityGroup
        {
            Id = 20,
            Name = "stock_etf",
            Title = "Биржевые фонды",
            IsHidden = false,
        };


        /// <summary>
        /// Драгоценные металлы
        /// </summary>
        public static readonly SecurityGroup Currency_Metal = new SecurityGroup
        {
            Id = 24,
            Name = "currency_metal",
            Title = "Драгоценные металлы",
            IsHidden = false,
        };


        /// <summary>
        /// Квал. инвесторы
        /// </summary>
        public static readonly SecurityGroup Stock_Qnv = new SecurityGroup
        {
            Id = 21,
            Name = "stock_qnv",
            Title = "Квал. инвесторы",
            IsHidden = false,
        };


        /// <summary>
        /// Клиринговые сертификаты участия
        /// </summary>
        public static readonly SecurityGroup Stock_Gcc = new SecurityGroup
        {
            Id = 27,
            Name = "stock_gcc",
            Title = "Клиринговые сертификаты участия",
            IsHidden = false,
        };


        /// <summary>
        /// Депозиты с ЦК
        /// </summary>
        public static readonly SecurityGroup Stock_Deposit = new SecurityGroup
        {
            Id = 29,
            Name = "stock_deposit",
            Title = "Депозиты с ЦК",
            IsHidden = false,
        };


        /// <summary>
        /// Валютный фьючерс
        /// </summary>
        public static readonly SecurityGroup Currency_Futures = new SecurityGroup
        {
            Id = 28,
            Name = "currency_futures",
            Title = "Валютный фьючерс",
            IsHidden = false,
        };


        /// <summary>
        /// Валютные фиксинги
        /// </summary>
        public static readonly SecurityGroup Currency_Indices = new SecurityGroup
        {
            Id = 31,
            Name = "currency_indices",
            Title = "Валютные фиксинги",
            IsHidden = false,
        };


        /// <summary>
        /// Ипотечный сертификат
        /// </summary>
        public static readonly SecurityGroup Stock_Mortgage = new SecurityGroup
        {
            Id = 22,
            Name = "stock_mortgage",
            Title = "Ипотечный сертификат",
            IsHidden = true,
        };


     
        public static SecurityGroup[] All = new SecurityGroup[] { Stock_Index, Stock_Shares, Stock_Bonds, Currency_Selt, Futures_Forts, Futures_Options, Stock_Dr, Stock_Foreign_Shares, Stock_Eurobond, Stock_Ppif, Stock_Etf, Currency_Metal, Stock_Qnv, Stock_Gcc, Stock_Deposit, Currency_Futures, Currency_Indices, Stock_Mortgage,  };


    }
}