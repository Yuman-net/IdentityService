// <copyright file="UserController.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Controllers
{
    using System.Net.Mime;
    using AutoMapper;
    using DataAccess;
    using Domain;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Service.Abstract;
    using WebApi.Abstractions.Controllers;

    /// <summary>
    /// Контроллер по работе с пользователями.
    /// </summary>
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Route(UserController.RouteUrl)]
    public sealed class UserController : CrudController<User, UserModel, UserModel, DataContext, IUserService>
    {
        private const string RouteUrl = "api/users";

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="UserController"/>.
        /// </summary>
        /// <param name="dataContext"> Конекст базы данных. </param>
        /// <param name="service"> Целевой сервис. </param>
        /// <param name="mapper"> Маппер. </param>
        public UserController(DataContext dataContext, IUserService service, IMapper mapper)
            : base(dataContext, service, mapper)
        {
        }
    }
}
