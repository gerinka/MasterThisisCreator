﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Mtc.Domain.Models;
using Mtc.Domain.Services.Interfaces;

namespace Mtc.Domain.Services
{
    public class DocumentService : IDocumentService
    {
        public Document GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Document GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Document Create(Document entity)
        {
            throw new NotImplementedException();
        }

        public Document Update(Document entity)
        {
            throw new NotImplementedException();
        }

        public Document Delete(Document entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> GetAll(Expression<Func<Document, bool>> filter = null, Func<IQueryable<Document>, IOrderedQueryable<Document>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
    }
}