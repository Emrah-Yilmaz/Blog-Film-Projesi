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
    public class MessageManager : IGenericService<Message>
    {
        private readonly IGenericDal<Message> _genericDal;

        public MessageManager(IGenericDal<Message> genericDal)
        {
            _genericDal = genericDal;
        }

        public void AddT(Message entity)
        {
            _genericDal.Add(entity);    
        }

        public Message GetItem(int id)
        {
           return  _genericDal.GetItem(filter: x => x.MessageId == id);
        }

        public List<Message> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList(Expression<Func<Message, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListSelected(Expression<Func<Message, bool>> filter)
        {
            return _genericDal.GetListSelected(filter);
        }

        public void RemoveT(Message entity)
        {
            _genericDal.Delete(entity);
        }

        public void Update(Message entity)
        {
            _genericDal.Update(entity);
        }
    }
}
