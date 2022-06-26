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
    public class VoteManager : IGenericService<Vote>
    {
       private readonly  IGenericDal<Vote> _genericDal;

        public VoteManager(IGenericDal<Vote> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(Vote entity)
        {
            _genericDal.Add(entity);    
        }

        public Vote GetItem(int id)
        {
            return _genericDal.GetItem(x => x.VoteOfBlogID == id);
        }

        public List<Vote> GetList(Expression<Func<Vote, bool>> filter = null)
        {
            throw new NotImplementedException();

        }

        public List<Vote> GetListItem(int id)
        {
            return _genericDal.GetList(x => x.VoteOfBlogID == id);

        }

        public List<Vote> GetListSelected(Expression<Func<Vote, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveT(Vote entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Vote entity)
        {
            throw new NotImplementedException();
        }
    }
}
