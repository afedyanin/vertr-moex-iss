namespace Vertr.Moex.Iss.UrlBuilderComponents
{
    public partial class Engine
    {
    
        /// <summary>
        /// Фондовый рынок и рынок депозитов
        /// </summary>
        public static readonly Engine Stock = new Engine { Id = 1, Name = "stock", Title = "Фондовый рынок и рынок депозитов" };

        /// <summary>
        /// Рынок ГЦБ (размещение)
        /// </summary>
        public static readonly Engine State = new Engine { Id = 2, Name = "state", Title = "Рынок ГЦБ (размещение)" };

        /// <summary>
        /// Валютный рынок
        /// </summary>
        public static readonly Engine Currency = new Engine { Id = 3, Name = "currency", Title = "Валютный рынок" };

        /// <summary>
        /// Срочный рынок
        /// </summary>
        public static readonly Engine Futures = new Engine { Id = 4, Name = "futures", Title = "Срочный рынок" };

        /// <summary>
        /// Товарный рынок
        /// </summary>
        public static readonly Engine Commodity = new Engine { Id = 5, Name = "commodity", Title = "Товарный рынок" };

        /// <summary>
        /// Товарные интервенции
        /// </summary>
        public static readonly Engine Interventions = new Engine { Id = 6, Name = "interventions", Title = "Товарные интервенции" };

        /// <summary>
        /// ОТС-система
        /// </summary>
        public static readonly Engine Offboard = new Engine { Id = 7, Name = "offboard", Title = "ОТС-система" };

        /// <summary>
        /// Агро
        /// </summary>
        public static readonly Engine Agro = new Engine { Id = 9, Name = "agro", Title = "Агро" };

        /// <summary>
        /// ОТС с ЦК
        /// </summary>
        public static readonly Engine Otc = new Engine { Id = 1012, Name = "otc", Title = "ОТС с ЦК" };

        /// <summary>
        /// Квоты
        /// </summary>
        public static readonly Engine Quotes = new Engine { Id = 1282, Name = "quotes", Title = "Квоты" };

    }
}