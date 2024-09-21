// <copyright file="UserConfiguration.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace DataAccess
{
    using DataAccess.Abstractions;
    using Domain;

    /// <summary>
    /// Конфигуратор сущности <see cref="User"/>.
    /// </summary>
    public sealed class UserConfiguration : EntityConfiguration<User>
    {
    }
}
