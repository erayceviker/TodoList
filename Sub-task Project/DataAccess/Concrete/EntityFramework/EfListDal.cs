using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfListDal : EfEntityRepositoryBase<List,AppDbContext>,IListDal
    {
    }
}
