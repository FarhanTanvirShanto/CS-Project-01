using RepositoryDemo_Method.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDemo_Method.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepo<T> GetRepo<T>() where T : class, IModel, new()
        {
            return new GenericRepo<T>(new List<T>());
        }
    }
}
