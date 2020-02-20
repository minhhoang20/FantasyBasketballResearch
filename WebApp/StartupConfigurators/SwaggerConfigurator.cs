using Microsoft.Extensions.DependencyInjection;
using NSwag;
using NSwag.Generation.Processors.Security;

namespace WebApp.StartupConfigurators
{
    public static class SwaggerConfigurator
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(config =>
            {
                config.SchemaType = NJsonSchema.SchemaType.OpenApi3;
                config.OperationProcessors.Add(new OperationSecurityScopeProcessor("Bearer"));
                config.DocumentProcessors.Add(
                    new SecurityDefinitionAppender("Bearer", new[] { "", "" }, new OpenApiSecurityScheme
                    {
                        Type = OpenApiSecuritySchemeType.ApiKey,
                        Name = "Authorization",
                        In = OpenApiSecurityApiKeyLocation.Header,
                        Description = "Please enter JWT with Bearer decorator into field"
                    })
                );
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "Fantasy Basketball Research Suite";
                    document.Info.Description =
                        "Application for statistic researching of fantasy basketball";
                    document.Info.TermsOfService = "None";
                    document.Info.Contact = new OpenApiContact
                    {
                        Name = "Fantasy Basketball Research Support Team",
                        Email = "luuminh20@gmail.com"
                    };
                };
            });
        }
    }
}
