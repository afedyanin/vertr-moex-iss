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
    {GenerateAllEnginesProperty(engines)}
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
        public static readonly Engine {meta.PropertyName} = new Engine {{ Id = {meta.Id}, Name = ""{meta.Name}"", Title = ""{meta.Title}"" }};
");
        }

        return sb.ToString();
    }

    private static string GenerateAllEnginesProperty(EngineMeta[] engines)
    {
        var sb = new StringBuilder();

        sb.AppendLine($@" 
        public static Engine[] All = new Engine[] {{ {GenerateAllEngines(engines)} }};
");

        return sb.ToString();
    }

    private static string GenerateAllEngines(EngineMeta[] engines)
    {
        var sb = new StringBuilder();

        foreach (var engine in engines)
        {
            sb.Append($"{engine.PropertyName}, ");
        }

        return sb.ToString();
    }
}
