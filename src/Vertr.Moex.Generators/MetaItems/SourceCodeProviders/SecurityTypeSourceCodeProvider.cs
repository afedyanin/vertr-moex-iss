using System.Text;

namespace Vertr.Moex.Generators.MetaItems.SourceCodeProviders;
internal static class SecurityTypeSourceCodeProvider
{
    public static string ToSourceCode(this SecurityTypeMeta[] items)
    {
        return $@"namespace {SourceCodeGeneratorConsts.EntitiesNamespace}
{{
    public partial class SecurityType
    {{
    {GenerateStaticProperties(items)}
    {GenerateAllProperty(items)}
    }}
}}";
    }

    private static string GenerateStaticProperties(SecurityTypeMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var meta in items)
        {
            sb.AppendLine($@"
        /// <summary>
        /// {meta.Title}
        /// </summary>
        public static readonly SecurityType {meta.PropertyName} = new SecurityType
        {{
            Id = {meta.Id},
            Name = ""{meta.Name}"",
            Title = ""{meta.Title}"",
            EngineId = {meta.EngineId},
            GroupName = ""{meta.GroupName ?? string.Empty}"",
            StockType = ""{meta.StockType ?? string.Empty}"",
        }};
");
        }

        return sb.ToString();
    }

    private static string GenerateAllProperty(SecurityTypeMeta[] items)
    {
        var sb = new StringBuilder();

        sb.AppendLine($@" 
        public static SecurityType[] All = new SecurityType[] {{ {GenerateAllItemsList(items)} }};
");

        return sb.ToString();
    }

    private static string GenerateAllItemsList(SecurityTypeMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var item in items)
        {
            sb.Append($"{item.PropertyName}, ");
        }

        return sb.ToString();
    }
}
