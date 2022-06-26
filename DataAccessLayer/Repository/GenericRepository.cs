using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T entity)
        {
            using var context = new Context();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new Context();
            context.Remove(entity);
            context.SaveChanges();

        }


        public List<T> GetAll()
        {
            using var context = new Context ();
            return context.Set<T>().ToList();
        }
        
        public T GetItem(Expression<Func<T, bool>> filter)
        {
            using var context = new Context();
            return context.Set<T>().SingleOrDefault(filter);
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using Context context = new ();
            return filter == null
            ? context.Set<T>().ToList()
            : context.Set<T>().Where(filter).ToList();
        }

        public List<T> GetListSelected(Expression<Func<T, bool>> filter)
        {
            using var context = new Context();
            return context.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            using var context = new Context();
            //var updatedEntity = context.Entry(entity);
            //context.Entry(entity).State = EntityState.Modified;
            //context.SaveChanges();
            context.Update(entity);
            context.SaveChanges();
        }


    }
}
