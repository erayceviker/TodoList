using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IListService
    {
        IDataResult<List> GetById(int listId);
        IDataResult<List<List>> GetList();
        IResult Add(List list);
        IResult Update(List list);
        IResult Delete(List list);

    }
}
