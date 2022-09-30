using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace WebApiSample.Filters;

public partial class RedocFixerDocumentFilter
{
    public class ReplaceVersionWithExactValueInPath : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var paths = swaggerDoc.Paths; 
            swaggerDoc.Paths = new OpenApiPaths();

            foreach (var path in paths)
            {
                var key = path.Key.Replace("v{ver}", "v" + swaggerDoc.Info.Version);
                var value = path.Value;
                swaggerDoc.Paths.Add(key, value);
                swaggerDoc.Paths.Remove("/markdownprocessor/markdownpage");
            }
        }


        public class RemoveVersionFromParameter : IOperationFilter
        {
            public void Apply(OpenApiOperation operation, OperationFilterContext context)
            {
                if (operation.Parameters.Count() > 0)
                {
                    var versionParameter = operation.Parameters.SingleOrDefault(s => s.Name == "ver");
                    operation.Parameters.Remove(versionParameter);
                }
            }
        }
    } 
}
