﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IRepository <T>
    {
        IEnumerable<T> FindAll ();
        T FindById (Guid id);
        void Create (T entity);
        void Update (T entity);
        void Delete (T entity);
    }
}
