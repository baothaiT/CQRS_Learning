using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class ScriptsInPlan
{
    public Guid PlanId { get; set; }
    public Plan ScriptsInPlan_Plan { get; set; }

    public Guid ScriptId { get; set; }
    public Script ScriptsInPlan_Script { get; set; }

    public bool IsDelete { get; set; }
}
