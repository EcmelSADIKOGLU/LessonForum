using LessonForum.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.DataAccessLayer.Abstract
{
    public interface ILessonNoteDAL:IGenericDAL<LessonNote>
    {
        List<LessonNote> GetListWithSubCategory();
        List<LessonNote> GetListWithSubCategory(Expression<Func<LessonNote, bool>> filter);
        List<LessonNote> GetLessonNoteBySubCategoryID(int id);
        LessonNote GetLessonNoteByID(int id);
    }
}
