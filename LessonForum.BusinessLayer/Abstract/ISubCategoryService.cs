using LessonForum.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.BusinessLayer.Abstract
{
    public interface ISubCategoryService:IGenericService<SubCategory>
    {
        List<SubCategory> TGetListWithCategory();
        List<SubCategory> TGetListWithCategory(Expression<Func<SubCategory, bool>> filter);
        List<SubCategory> TGetSubCategoryByCategoryID(int id);
        SubCategory TGetSubCategoryByID(int id);

    }
}
