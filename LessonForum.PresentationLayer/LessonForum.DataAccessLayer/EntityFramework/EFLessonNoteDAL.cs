using LessonForum.DataAccessLayer.Abstract;
using LessonForum.DataAccessLayer.Concrete;
using LessonForum.DataAccessLayer.Repository;
using LessonForum.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.DataAccessLayer.EntityFramework
{
    public class EFLessonNoteDAL : GenericRepository<LessonNote>, ILessonNoteDAL
    {
        Context context = new Context();

        public LessonNote GetLessonNoteByID(int id)
        {
            return context.Set<LessonNote>().Where(x => x.LessonNotesID == id).
                Include(x => x.SubCategory.Category).
                Include(x=>x.SubCategory).
                FirstOrDefault();
        }

        public List<LessonNote> GetLessonNoteBySubCategoryID(int id)
        {
            return context.Set<LessonNote>().Where(x => x.SubCategoryID == id).
                Include(x => x.SubCategory.Category).
                Include(x => x.SubCategory).
                ToList();
        }

        public List<LessonNote> GetListWithSubCategory()
        {
            return context.Set<LessonNote>().
                Include(x => x.SubCategory.Category).
                Include(x => x.SubCategory).
                ToList();
        }

        public List<LessonNote> GetListWithSubCategory(Expression<Func<LessonNote, bool>> filter)
        {
            return context.Set<LessonNote>().Where(filter).
                Include(x => x.SubCategory.Category).
                Include(x => x.SubCategory).
                ToList();
        }
    }
}
