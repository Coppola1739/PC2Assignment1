using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPriorityTrackerForm.model
{
    public enum Priority
    {
        [Description("High")]
        High,

        [Description("Medium")]
        Medium,

        [Description("Low")]
        Low
    }
}
