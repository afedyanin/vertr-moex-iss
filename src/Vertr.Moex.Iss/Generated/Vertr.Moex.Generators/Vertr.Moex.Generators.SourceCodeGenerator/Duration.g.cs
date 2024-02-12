namespace Vertr.Moex.Iss.Entities
{
    public partial class Duration
    {
    
        /// <summary>
        /// минута
        /// </summary>
        public static readonly Duration M1 = new Duration
        {
            Interval = 1,
            DurationInSeconds = 60,
            Days = 0,
            Title = "минута",
            Hint = "1м",
        };


        /// <summary>
        /// 10 минут
        /// </summary>
        public static readonly Duration M10 = new Duration
        {
            Interval = 10,
            DurationInSeconds = 600,
            Days = 0,
            Title = "10 минут",
            Hint = "10м",
        };


        /// <summary>
        /// час
        /// </summary>
        public static readonly Duration H1 = new Duration
        {
            Interval = 60,
            DurationInSeconds = 3600,
            Days = 0,
            Title = "час",
            Hint = "1ч",
        };


        /// <summary>
        /// день
        /// </summary>
        public static readonly Duration D1 = new Duration
        {
            Interval = 24,
            DurationInSeconds = 86400,
            Days = 0,
            Title = "день",
            Hint = "1д",
        };


        /// <summary>
        /// неделя
        /// </summary>
        public static readonly Duration W1 = new Duration
        {
            Interval = 7,
            DurationInSeconds = 604800,
            Days = 0,
            Title = "неделя",
            Hint = "1н",
        };


        /// <summary>
        /// месяц
        /// </summary>
        public static readonly Duration MN1 = new Duration
        {
            Interval = 31,
            DurationInSeconds = 2678400,
            Days = 0,
            Title = "месяц",
            Hint = "1М",
        };


        /// <summary>
        /// квартал
        /// </summary>
        public static readonly Duration Q1 = new Duration
        {
            Interval = 4,
            DurationInSeconds = 8035200,
            Days = 0,
            Title = "квартал",
            Hint = "1К",
        };


     
        public static Duration[] All = new Duration[] { M1, M10, H1, D1, W1, MN1, Q1,  };


    }
}