using System.Text;

namespace Vertr.Moex.Generators.MetaItems.SourceCodeProviders;
internal static class DurationSourceCodeProvider
{
    public static string ToSourceCode(this DurationMeta[] items)
    {
        return $@"namespace {SourceCodeGeneratorConsts.EntitiesNamespace}
{{
    public partial class Duration
    {{
    {GenerateStaticProperties(items)}
    {GenerateAllProperty(items)}
    }}
}}";
    }

    private static string GenerateStaticProperties(DurationMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var meta in items)
        {
            sb.AppendLine($@"
        /// <summary>
        /// {meta.Title}
        /// </summary>
        public static readonly Duration {meta.PropertyName} = new Duration
        {{
            Interval = {meta.Interval},
            DurationInSeconds = {meta.Duration},
            Days = {meta.Days},
            Title = ""{meta.Title}"",
            Hint = ""{meta.Hint}"",
        }};
");
        }

        return sb.ToString();
    }

    private static string GenerateAllProperty(DurationMeta[] items)
    {
        var sb = new StringBuilder();

        sb.AppendLine($@" 
        public static Duration[] All = new Duration[] {{ {GenerateAllItemsList(items)} }};
");

        return sb.ToString();
    }

    private static string GenerateAllItemsList(DurationMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var item in items)
        {
            sb.Append($"{item.PropertyName}, ");
        }

        return sb.ToString();
    }
}
