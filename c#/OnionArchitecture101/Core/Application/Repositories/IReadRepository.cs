﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{ // read operations=> select. Base interface to execute all reading options related on database
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);

        
        Task<T> GetByIdAsync(string Id);
    }
}
