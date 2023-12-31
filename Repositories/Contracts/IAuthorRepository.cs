﻿using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IAuthorRepository : IRepositoryBase<Author>
    {
        Author? GetOneAuthor(int id, bool trackChanges);
        void CreateOneAuthor(Author author);
        Author? GetAuthorByAspNetUserId(string id, bool trackChanges);
    }
}
