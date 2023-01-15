using LessonForum.DataAccessLayer.Abstract;
using LessonForum.DataAccessLayer.Concrete;
using LessonForum.DataAccessLayer.Repository;
using LessonForum.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.DataAccessLayer.EntityFramework
{
    public class EFSubCategoryDAL : GenericRepository<SubCategory>, ISubCategoryDAL
    {
        Context context = new Context();

        public List<SubCategory> GetListWithCategory()
        {
            return context.Set<SubCategory>().Include(x => x.Category).ToList();
        }

        public List<SubCategory> GetListWithCategory(Expression<Func<SubCategory, bool>> filter)
        {
            return context.Set<SubCategory>().Where(filter).Include(x => x.Category).ToList();
        }

        public List<SubCategory> GetSubCategoryByCategoryID(int id)
        {
            return context.Set<SubCategory>().Where(x => x.CategoryID == id).Include(x=>x.Category).ToList();
        }

        public SubCategory GetSubCategoryByID(int id)
        {
            return context.Set<SubCategory>().Where(x => x.SubCategoryID == id).Include(x => x.Category).FirstOrDefault();
        }
    }
}
