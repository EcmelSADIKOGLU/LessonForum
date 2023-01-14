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
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDAL _subCategoryDAL;

        public SubCategoryManager(ISubCategoryDAL subCategoryDAL)
        {
            _subCategoryDAL = subCategoryDAL;
        }

        public void TDelete(SubCategory entity)
        {
            _subCategoryDAL.Delete(entity);
        }

        public SubCategory TGetByID(int id)
        {
            return _subCategoryDAL.GetByID(id);
        }

        public List<SubCategory> TGetList()
        {
            return _subCategoryDAL.GetList();
        }

        public List<SubCategory> TGetList(Expression<Func<SubCategory, bool>> filter)
        {
            return _subCategoryDAL.GetList(filter);
        }

        public List<SubCategory> TGetListWithCategory()
        {
            return _subCategoryDAL.GetListWithCategory();
        }

        public List<SubCategory> TGetListWithCategory(Expression<Func<SubCategory, bool>> filter)
        {
            return _subCategoryDAL.GetListWithCategory(filter);
        }

        public List<SubCategory> TGetSubCategoryByCategoryID(int id)
        {
            return _subCategoryDAL.GetSubCategoryByCategoryID(id);
        }

        public SubCategory TGetSubCategoryByID(int id)
        {
            return _subCategoryDAL.GetSubCategoryByID(id);
        }

        public void TInsert(SubCategory entity)
        {
            _subCategoryDAL.Insert(entity);
        }

        public void TUpdate(SubCategory entity)
        {
            _subCategoryDAL.Update(entity);
        }
    }
}
