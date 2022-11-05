using RepositoryDemo_Method.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDemo_Method.Repositories
{
    public interface IGenericRepo<T> where T : class, IModel, new()
    {
        IList<T> Get();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
