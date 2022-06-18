using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IGenericService<Blog>
    {
        private readonly IGenericDal<Blog> _genericDal;

        public BlogManager(IGenericDal<Blog> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(Blog entity)
        {
             _genericDal.Add(entity);
        }

        public Blog GetItem(int id)
        {
            return _genericDal.GetItem(filter: x => x.BlogId == id);
        }

        public List<Blog> GetList()
        {
            return _genericDal.GetAll();
        }

        public List<Blog> GetList(Expression<Func<Blog, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListItem(int id)
        {
           return _genericDal.GetListSelected(x=> x.BlogId == id);
        }

        public List<Blog> GetListSelected(Expression<Func<Blog, bool>> filter)
        {
            return _genericDal.GetListSelected(filter);
        }

        public void RemoveT(Blog entity)
        {
           _genericDal.Delete(entity);
        }

        public void Update(Blog entity)
        {
            _genericDal.Update(entity);
        }

        //public void Add(Blog entity)
        //{
        //   _genericDal.Add(entity);
        //}

        //public void Delete(Blog entity)
        //{
        //    _genericDal.Delete(entity); 
        //}

        //public List<Blog> GetAll()
        //{
        //    return _genericDal.GetAll();    
        //}

        //public Blog GetItem(int id)
        //{
        //    return _genericDal.GetItem(id);
        //}

        //public List<Blog> GetListAll(Expression<Func<Blog, bool>> filter)
        //{
        //    return _genericDal.GetListAll(filter);
        //}

        //public void Update(Blog entity)
        //{
        //    _genericDal.Update(entity);
        //}
    }
}
