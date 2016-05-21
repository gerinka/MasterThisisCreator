﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Mtc.Domain.Common;

namespace Mtc.Domain.Services.Interfaces
{
    public interface IBaseService<T> where T: class
    {
        T GetById(long id);
        T GetByName(string name);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
