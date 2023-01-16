using LessonForum.BusinessLayer.Abstract;
using LessonForum.DataAccessLayer.Abstract;
using LessonForum.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void TDelete(Contact entity)
        {
            _contactDAL.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
            return _contactDAL.GetByID(id);
        }

        public List<Contact> TGetList()
        {
            return _contactDAL.GetList();
        }

        public List<Contact> TGetList(Expression<Func<Contact, bool>> filter)
        {
            return _contactDAL.GetList(filter);
        }

        public void TInsert(Contact entity)
        {
            _contactDAL.Insert(entity); 
        }

        public void TUpdate(Contact entity)
        {
            _contactDAL.Update(entity);
        }
    }
}
