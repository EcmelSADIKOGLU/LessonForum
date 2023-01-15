using LessonForum.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.DataAccessLayer.Abstract
{
    public interface ISubCategoryDAL:IGenericDAL<SubCategory>
    {
        List<SubCategory> GetListWithCategory();
        List<SubCategory> GetListWithCategory(Expression<Func<SubCategory, bool>> filter);
        List<SubCategory> GetSubCategoryByCategoryID(int id);
        SubCategory GetSubCategoryByID(int id);
    }
}
