using LessonForum.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.BusinessLayer.Abstract
{
    public interface ILessonNoteService:IGenericService<LessonNote>
    {
        List<LessonNote> TGetListWithSubCategory();
        List<LessonNote> TGetListWithSubCategory(Expression<Func<LessonNote, bool>> filter);
        List<LessonNote> TGetLessonNoteBySubCategoryID(int id);
        LessonNote TGetLessonNoteByID(int id);
    }
}
