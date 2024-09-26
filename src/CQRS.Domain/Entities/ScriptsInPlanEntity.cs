using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class ScriptsInPlanEntity
{
    public Guid PlanId { get; set; }
    public PlanEntity ScriptsInPlan_Plan { get; set; }

    public Guid ScriptId { get; set; }
    public ScriptEntity ScriptsInPlan_Script { get; set; }

    public bool IsDelete { get; set; }
}
