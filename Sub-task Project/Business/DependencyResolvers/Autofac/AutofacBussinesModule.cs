using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBussinesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TaskManager>().As<ITaskService>();
            builder.RegisterType<EfTaskDal>().As<ITaskDal>();
            builder.RegisterType<ListManager>().As<IListService>();
            builder.RegisterType<EfListDal>().As<IListDal>();
        }
    }
}
