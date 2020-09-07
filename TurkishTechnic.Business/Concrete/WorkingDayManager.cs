using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurkishTechnic.Business.Abstract;
using TurkishTechnic.Business.Constants;
using TurkishTechnic.Core.Utilities.Results;
using TurkishTechnic.DataAccess.Abstract;
using TurkishTechnic.Entities;

namespace TurkishTechnic.Business.Concrete
{
    public class WorkingDayManager : IWorkingTimeService
    {
        private IWorkingTimeDal _workingTimeDal;

        public WorkingDayManager(IWorkingTimeDal workingTimeDal)
        {
            _workingTimeDal = workingTimeDal;
        }

        public IResult Add(WorkingTime workingTime)
        {
            if (workingTime.WorkingStartTime.HasValue && workingTime.WorkingEndTime.HasValue)
                return new ErrorResult(Messages.ModelError);

            _workingTimeDal.Add(workingTime);
            return new SuccessResult(Messages.WorkingTimeAdded);
        }

        public IDataResult<List<WorkingTime>> GetByUser(Guid userId)
        {
            return new SuccessDataResult<List<WorkingTime>>(_workingTimeDal.GetList(w => w.UserId == userId).ToList());
        }
    }
}
