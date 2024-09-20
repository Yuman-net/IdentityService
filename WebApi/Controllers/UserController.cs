// <copyright file="UserController.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

using Models;
using WebApi.Abstractions.Controllers;

namespace WebApi.Controllers
{
    public sealed class UserController : CrudController<User, UserModel>
    {
    }
}
