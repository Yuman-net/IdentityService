// <copyright file="UserProfile.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace WebApi.Profiles
{
    using Domain;
    using Models;
    using WebApi.Abstractions.Profiles;

    /// <summary>
    /// Профиль, настраивающий правила отображения из <see cref="User"/> в модель и обратно.
    /// </summary>
    public sealed class UserProfile : EntityProfile<User, UserModel>
    {
    }
}
