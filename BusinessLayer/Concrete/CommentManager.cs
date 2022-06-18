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
    public class CommentManager : IGenericService<Comment>
    {
        private readonly IGenericDal<Comment> _genericDal;


        public CommentManager(IGenericDal<Comment> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(Comment entity)
        {
            _genericDal.Add(entity);
        }

        public Comment GetItem(int id)
        {
            return _genericDal.GetItem(filter: x => x.CommentId == id);
        }

        public List<Comment> GetList()
        {
            return _genericDal.GetAll();    
        }

        public List<Comment> GetList(Expression<Func<Comment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListItem(int id)
        {
           return _genericDal.GetList(filter: x => x.BlogId == id);  
        }

        public List<Comment> GetListSelected(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveT(Comment entity)
        {
            _genericDal.Delete(entity); 
        }

        public void Update(Comment entity)
        {
           _genericDal.Update(entity);
        }
    }
}
