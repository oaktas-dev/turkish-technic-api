using System;
using System.Collections.Generic;
using System.Text;
using TurkishTechnic.Core.Utilities.Results;
using TurkishTechnic.Entities;

namespace TurkishTechnic.Business.Abstract
{
    public interface IWorkingTimeService
    {
        IDataResult<List<WorkingTime>> GetByUser(Guid useId);
        IResult Add(WorkingTime workingTime);
    }
}
