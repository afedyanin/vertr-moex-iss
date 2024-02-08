
using System.ComponentModel;
namespace Vertr.Moex.Iss.UrlBuilderComponents
{
  public partial class Engine
  {
    
public static readonly Engine Stock = new Engine { Id = 1, Name = "stock", Title = "Фондовый рынок и рынок депозитов" };

public static readonly Engine State = new Engine { Id = 2, Name = "state", Title = "Рынок ГЦБ (размещение)" };

public static readonly Engine Currency = new Engine { Id = 3, Name = "currency", Title = "Валютный рынок" };

public static readonly Engine Futures = new Engine { Id = 4, Name = "futures", Title = "Срочный рынок" };

public static readonly Engine Commodity = new Engine { Id = 5, Name = "commodity", Title = "Товарный рынок" };

public static readonly Engine Interventions = new Engine { Id = 6, Name = "interventions", Title = "Товарные интервенции" };

public static readonly Engine Offboard = new Engine { Id = 7, Name = "offboard", Title = "ОТС-система" };

public static readonly Engine Agro = new Engine { Id = 9, Name = "agro", Title = "Агро" };

public static readonly Engine Otc = new Engine { Id = 1012, Name = "otc", Title = "ОТС с ЦК" };

public static readonly Engine Quotes = new Engine { Id = 1282, Name = "quotes", Title = "Квоты" };

  }
}