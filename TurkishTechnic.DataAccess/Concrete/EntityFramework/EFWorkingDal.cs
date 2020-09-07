using System;
using System.Collections.Generic;
using System.Text;
using TurkishTechnic.Core.DataAccess.EntityFramework;
using TurkishTechnic.DataAccess.Abstract;
using TurkishTechnic.DataAccess.Concrete.EntityFramework.Context;
using TurkishTechnic.Entities;

namespace TurkishTechnic.DataAccess.Concrete.EntityFramework
{
    public class EFWorkingDal : EntityRepositoryBase<WorkingTime, TurkishTechnicContext>, IWorkingTimeDal
    {
    }
}
