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
    public class NotificationManager : IGenericService<Notification>
    {
        private readonly IGenericDal<Notification> _genericDal;

        public NotificationManager(IGenericDal<Notification> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(Notification entity)
        {
           _genericDal.Add(entity);
        }

        public Notification GetItem(int id)
        {
            return _genericDal.GetItem(filter: x => x.NotificationId == id);
        }

        public List<Notification> GetList()
        {
            return _genericDal.GetList().ToList();
        }

        public List<Notification> GetList(Expression<Func<Notification, bool>> filter = null)
        {
            return _genericDal.GetList(filter).ToList();    
        }

        public List<Notification> GetListItem(int id)
        {
            return _genericDal.GetList(x=> x.NotificationId == id);

        }

        public List<Notification> GetListSelected(Expression<Func<Notification, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveT(Notification entity)
        {
            _genericDal.Delete(entity);
        }

        public void Update(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}
