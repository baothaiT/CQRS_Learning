using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class ScriptsInProjectEntity
{
    public Guid ProjectId { get; set; }
    public ProjectEntity ScriptsInProject_Project { get; set; }

    public Guid ScriptId { get; set; }
    public ScriptEntity ScriptsInProject_Script { get; set; }

    public bool IsDelete { get; set; }
}
