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
    public class RatingManager : IGenericService<Rating>
    {
        private readonly IGenericDal<Rating> _genericDal;

        public RatingManager(IGenericDal<Rating> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(Rating entity)
        {
            throw new NotImplementedException();
        }

        public Rating GetItem(int id)
        {
            return _genericDal.GetItem(x => x.RatingBlogID == id);
        }

        public List<Rating> GetList(Expression<Func<Rating, bool>> filter = null)
        {
            return _genericDal.GetList(filter);
        }

        public List<Rating> GetListItem(int id)
        {
            return _genericDal.GetList(filter: x => x.RatingBlogID == id);
        }

        public List<Rating> GetListSelected(Expression<Func<Rating, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveT(Rating entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Rating entity)
        {
            throw new NotImplementedException();
        }
    }
}
