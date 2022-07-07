using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazor
{
    public interface IScheduler
    {
        IReadOnlyCollection<Appointment> Appointments { get; set; }

        List<SchedulerViewBase> Views { get; }

        void AddView(SchedulerViewBase schedulerView);

        void RemoveView(SchedulerViewBase schedulerView);
    }
}
