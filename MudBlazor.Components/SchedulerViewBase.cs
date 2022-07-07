using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazor
{
    public abstract class SchedulerViewBase : ComponentBase, IDisposable
    {
        [CascadingParameter]
        public IScheduler Scheduler { get; set; } = null!;

        public abstract string Header { get; }

        protected override void OnInitialized()
        {
            Scheduler.AddView(this);
        }

        public virtual RenderFragment Render()
        {
            return null!;
        }

        public void Dispose()
        {
            Scheduler.RemoveView(this);
        }
    }
}
