// <copyright file="UserService.cs" company="Andrey Nikolaev">
// Copyright (c) Andrey Nikolaev. All rights reserved.
// </copyright>

namespace Service
{
    using DataAccess;
    using Domain;
    using Microsoft.EntityFrameworkCore;
    using Service.Abstract;
    using Services.Abstractions;

    /// <summary>
    /// Сервис по работе с пользователями.
    /// </summary>
    public sealed class UserService : CrudService<User, DataContext>, IUserService
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="UserService"/>.
        /// </summary>
        /// <param name="dataContext"> Контекст базы данных. </param>
        public UserService(DataContext dataContext)
            : base(dataContext)
        {
        }

        /// <inheritdoc/>
        public override IQueryable<User> GetAll(bool track = false)
        {
            var query = this.DataContext.Users
                .AsSplitQuery();

            return track
                ? query
                : query.AsNoTracking();
        }
    }
}
