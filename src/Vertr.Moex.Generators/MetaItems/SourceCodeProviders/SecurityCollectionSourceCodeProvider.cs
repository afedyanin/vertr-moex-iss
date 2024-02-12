using System.Text;

namespace Vertr.Moex.Generators.MetaItems.SourceCodeProviders;
internal static class SecurityCollectionSourceCodeProvider
{
    public static string ToSourceCode(this SecurityCollectionMeta[] items)
    {
        return $@"namespace {SourceCodeGeneratorConsts.EntitiesNamespace}
{{
    public partial class SecurityCollection
    {{
    {GenerateStaticProperties(items)}
    {GenerateAllProperty(items)}
    }}
}}";
    }

    private static string GenerateStaticProperties(SecurityCollectionMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var meta in items)
        {
            sb.AppendLine($@"
        /// <summary>
        /// {meta.Title}
        /// </summary>
        public static readonly SecurityCollection {meta.PropertyName} = new SecurityCollection
        {{
            Id = {meta.Id},
            Name = ""{meta.Name}"",
            Title = ""{meta.Title}"",
            SecurityGroupId = {meta.SecurityGroupId},
        }};
");
        }

        return sb.ToString();
    }

    private static string GenerateAllProperty(SecurityCollectionMeta[] items)
    {
        var sb = new StringBuilder();

        sb.AppendLine($@" 
        public static SecurityCollection[] All = new SecurityCollection[] {{ {GenerateAllItemsList(items)} }};
");

        return sb.ToString();
    }

    private static string GenerateAllItemsList(SecurityCollectionMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var item in items)
        {
            sb.Append($"{item.PropertyName}, ");
        }

        return sb.ToString();
    }
}
