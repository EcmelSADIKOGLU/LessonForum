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
    public class LogManager : ILogService
    {
        ILogDAL _logDAL;

        public LogManager(ILogDAL logDAL)
        {
            _logDAL = logDAL;
        }

        public void TDelete(Log entity)
        {
            _logDAL.Delete(entity);
        }

        public Log TGetByID(int id)
        {
            return _logDAL.GetByID(id);
        }

        public List<Log> TGetList()
        {
            return _logDAL.GetList();
        }

        public List<Log> TGetList(Expression<Func<Log, bool>> filter)
        {
            return _logDAL.GetList(filter);
        }

        public void TInsert(Log entity)
        {
            _logDAL.Insert(entity);
        }

        public void TUpdate(Log entity)
        {
            _logDAL.Update(entity);
        }
    }
}
