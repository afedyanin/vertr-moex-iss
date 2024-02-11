using System.Text;

namespace Vertr.Moex.Generators.MetaItems.Extensions;

internal static class EngineSourceCodeProvider
{
    public static string ToSourceCode(this EngineMeta[] engines)
    {
        return $@"namespace {SourceCodeGeneratorConsts.EntitiesNamespace}
{{
    public partial class Engine
    {{
    {GenerateEngineProperties(engines)}
    }}
}}";
    }

    private static string GenerateEngineProperties(EngineMeta[] engines)
    {
        var sb = new StringBuilder();

        foreach (var meta in engines)
        {
            sb.AppendLine($@"
        /// <summary>
        /// {meta.Title}
        /// </summary>
        public static readonly Engine {meta.PropertyName} = new Engine {{ Id = {meta.Id}, Name = ""{meta.Name}"", Title = ""{meta.Title}"" }};");
        }

        return sb.ToString();
    }
}
