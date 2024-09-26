using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class ScriptEntity: BasedTableEntity
{
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }

    public ICollection<ScriptsInProjectEntity>? ScriptsInProjects { get; set; }
}
