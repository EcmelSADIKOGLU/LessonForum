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
    public class LessonNoteManager:ILessonNoteService
    {
        ILessonNoteDAL _lessonNoteDAL;

        public LessonNoteManager(ILessonNoteDAL lessonNoteDAL)
        {
            _lessonNoteDAL = lessonNoteDAL;
        }

        public void TDelete(LessonNote entity)
        {
            _lessonNoteDAL.Delete(entity);
        }

        public LessonNote TGetByID(int id)
        {
            return _lessonNoteDAL.GetByID(id);
        }

        public LessonNote TGetLessonNoteByID(int id)
        {
            return _lessonNoteDAL.GetLessonNoteByID(id);
        }

        public List<LessonNote> TGetLessonNoteBySubCategoryID(int id)
        {
            return _lessonNoteDAL.GetLessonNoteBySubCategoryID(id);
        }

        public List<LessonNote> TGetList()
        {
            return _lessonNoteDAL.GetList();
        }

        public List<LessonNote> TGetList(Expression<Func<LessonNote, bool>> filter)
        {
            return _lessonNoteDAL.GetList(filter);
        }

        public List<LessonNote> TGetListWithSubCategory()
        {
            return _lessonNoteDAL.GetListWithSubCategory();
        }

        public List<LessonNote> TGetListWithSubCategory(Expression<Func<LessonNote, bool>> filter)
        {
            return _lessonNoteDAL.GetListWithSubCategory(filter);
        }

        public void TInsert(LessonNote entity)
        {
            _lessonNoteDAL.Insert(entity);
        }

        public void TUpdate(LessonNote entity)
        {
            _lessonNoteDAL.Update(entity);
        }
    }
}
