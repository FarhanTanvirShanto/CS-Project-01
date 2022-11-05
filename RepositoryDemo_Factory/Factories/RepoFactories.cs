using RepositoryDemo_Factory.Models;
using RepositoryDemo_Factory.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDemo_Factory.Factories
{
    public interface IModelFactory
    {
        T Create<T>(params object[] args) where T : class, IModel, new();
    }
    public class ModelFactory : IModelFactory
    {
        public T Create<T>(params object[] args) where T : class, IModel, new()
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }

    }
    public interface IRepoFactory
    {
        IGenericRepo<T> Create<T>() where T : class, IModel, new();
    }
    public class RepoFactory : IRepoFactory
    {
        public IGenericRepo<T> Create<T>() where T : class, IModel, new()
        {
            return Activator.CreateInstance(
                typeof(GenericRepo<T>),
                new object[] { new List<T>() }) as GenericRepo<T>;
        }
    }
}
