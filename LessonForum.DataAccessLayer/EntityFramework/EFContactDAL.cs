using LessonForum.DataAccessLayer.Abstract;
using LessonForum.DataAccessLayer.Repository;
using LessonForum.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.DataAccessLayer.EntityFramework
{
    public class EFContactDAL:GenericRepository<Contact>,IContactDAL
    {
    }
}
