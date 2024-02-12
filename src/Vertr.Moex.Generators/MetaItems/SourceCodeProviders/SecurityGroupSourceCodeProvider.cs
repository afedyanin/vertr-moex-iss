using System.Text;

namespace Vertr.Moex.Generators.MetaItems.SourceCodeProviders;

internal static class SecurityGroupSourceCodeProvider
{
    public static string ToSourceCode(this SecurityGroupMeta[] items)
    {
        return $@"namespace {SourceCodeGeneratorConsts.EntitiesNamespace}
{{
    public partial class SecurityGroup
    {{
    {GenerateStaticProperties(items)}
    {GenerateAllProperty(items)}
    }}
}}";
    }

    private static string GenerateStaticProperties(SecurityGroupMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var meta in items)
        {
            sb.AppendLine($@"
        /// <summary>
        /// {meta.Title}
        /// </summary>
        public static readonly SecurityGroup {meta.PropertyName} = new SecurityGroup
        {{
            Id = {meta.Id},
            Name = ""{meta.Name}"",
            Title = ""{meta.Title}"",
            IsHidden = {meta.IsHidden.ToString().ToLower()},
        }};
");
        }

        return sb.ToString();
    }

    private static string GenerateAllProperty(SecurityGroupMeta[] items)
    {
        var sb = new StringBuilder();

        sb.AppendLine($@" 
        public static SecurityGroup[] All = new SecurityGroup[] {{ {GenerateAllItemsList(items)} }};
");

        return sb.ToString();
    }

    private static string GenerateAllItemsList(SecurityGroupMeta[] items)
    {
        var sb = new StringBuilder();

        foreach (var item in items)
        {
            sb.Append($"{item.PropertyName}, ");
        }

        return sb.ToString();
    }
}
