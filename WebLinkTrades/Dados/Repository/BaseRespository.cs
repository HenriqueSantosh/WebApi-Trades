using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLinkTrades.Dados.Interfaces;

namespace WebLinkTrades.Dados.Repository
{
    public class BaseRespository<T> : IRepository<T> where T : class
    {
        public BaseRespository()
        {

        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T item)
        {
            throw new NotImplementedException();
        }

        public T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
