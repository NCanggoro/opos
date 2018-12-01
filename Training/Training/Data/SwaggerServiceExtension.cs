using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training.Data
{
    public static class SwaggerServiceExtension
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1.0", new Info { Title = "Api Kita v1.0", Version = "v1.0" });


                var security = new Dictionary<string, IEnumerable<string>>
                {
                    {"Bearer" , new string[] {}}
                };

                x.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT Auth, Contoh : \"Authorization : Bearer {Token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });

                x.AddSecurityRequirement(security);

            });

            return services;

        }

        public static IApplicationBuilder AddSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "Versi API v1.0");
                c.DocumentTitle = "Judul Api";
                c.DocExpansion(DocExpansion.None);
            });
            return app;
        }

    }
}
