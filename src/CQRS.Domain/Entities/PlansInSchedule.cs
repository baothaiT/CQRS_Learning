using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class PlansInSchedule
{
    public Guid ScheduleId { get; set; }
    public Schedule? PlansInSchedule_Schedule { get; set; }

    public Guid DeviceId { get; set; }
    public Devices? PlansInSchedule_Device { get; set; }

    public Guid? PlanId { get; set; }
    public Plan? PlansInSchedule_Plan { get; set; }

    public bool IsDelete { get; set; }
}
