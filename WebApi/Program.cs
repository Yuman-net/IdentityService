// <copyright file="Program.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi
{
    using Service.Abstract;

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
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
