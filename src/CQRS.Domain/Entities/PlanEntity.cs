using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class PlanEntity: BasedTableEntity
{
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }
    public ICollection<ScriptsInPlanEntity>? ScriptsInPlans { get; set; }
    public ICollection<PlansInScheduleEntity>? PlansInSchedule { get; set; }

}
