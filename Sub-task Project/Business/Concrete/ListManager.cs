using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ListManager: IListService
    {

        private IListDal _listDal;

        public ListManager(IListDal listDal)
        {
            _listDal = listDal;
        }

        public IDataResult<List> GetById(int listId)
        {
            return new SuccessDataResult<List>(_listDal.Get(l => l.Id == listId));
        }

        public IDataResult<List<List>> GetList()
        {
            return new SuccessDataResult<List<List>>(_listDal.GetList());
        }


        public IResult Add(List list)
        {
            _listDal.Add(list);
            return new SuccessResult(Messages.ListAdded);
        }

        public IResult Update(List list)
        {
            _listDal.Update(list);
            return new SuccessResult(Messages.ListUpdated);
        }

        public IResult Delete(List list)
        {
            _listDal.Delete(list);
            return new SuccessResult(Messages.ListDeleted);
        }
    }
}
