using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLinkTrades.Dados.Context;
using WebLinkTrades.Dados.Interfaces;

namespace WebLinkTrades.Dados.Repository
{
    public class BaseRespository<T> : IRepository<T> where T : class
    {
        protected readonly BaseContext _context;
        private readonly DbSet<T> _dataSet;

        public BaseRespository(BaseContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }
        public bool Delete(int id)
        {
           var entity = _dataSet.Find(id);

            if (entity == null) return false;

            _dataSet.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dataSet.ToListAsync();
        }

        public T GetById(int id)
        {
           return  _dataSet.Find(id);
        }

        public T Save(T item)
        {
            _dataSet.Add(item);
            _context.SaveChanges();
            return item;
        }

        public T Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.Set<T>().Update(item);
            _context.SaveChanges();
            return item;
        }
    }
}
