// <copyright file="IUserService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Service.Abstract
{
    using Domain;
    using Services.Abstractions.Interfaces;

    /// <summary>
    /// Сервис по работе с пользователями.
    /// </summary>
    public interface IUserService : ICrudService<User>
    {
    }
}
