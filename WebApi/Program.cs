// <copyright file="Program.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.OpenApi.Models;
    using Service.Abstract;
    using DataAccess.Extensions;
    using WebApi.Profiles;

    /// <summary>
    /// Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Стартовая точка.
        /// </summary>
        /// <param name="args"> Аргументы. </param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            _ = builder.Services.AddServices();

            _ = builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = $"IdentityService", Version = "v1" });
                var xmlFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml");
                foreach (var xmlFile in xmlFiles)
                {
                    options.IncludeXmlComments(xmlFile);
                }
            });

            builder.Services.AddAutoMapper();
            builder.Services.AddControllers();
            builder.Services.AddDataAccess(builder.Configuration);

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}
