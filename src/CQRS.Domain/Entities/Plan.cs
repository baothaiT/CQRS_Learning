using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class Plan: BasedTable
{
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }
    public ICollection<ScriptsInPlan>? ScriptsInPlans { get; set; }
    public ICollection<PlansInSchedule>? PlansInSchedule { get; set; }

}
