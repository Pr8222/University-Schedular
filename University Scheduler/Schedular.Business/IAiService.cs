using Schedular.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.Business
{
    public interface IAiService
    {
        Task<List<CourseScheduleViewModel>> SuggestSchedulesAsync(
            List<CourseScheduleViewModel> currentSchedules,
            string teacherName,
            string courseTitle,
            int classGroup,
            int count,
            string distributionType);
    }
}
