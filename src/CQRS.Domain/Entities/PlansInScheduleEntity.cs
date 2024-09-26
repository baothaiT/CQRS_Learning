using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class PlansInScheduleEntity
{
    public Guid ScheduleId { get; set; }
    public ScheduleEntity? PlansInSchedule_Schedule { get; set; }

    public Guid DeviceId { get; set; }
    public DevicesEntity? PlansInSchedule_Device { get; set; }

    public Guid? PlanId { get; set; }
    public PlanEntity? PlansInSchedule_Plan { get; set; }

    public bool IsDelete { get; set; }
}
