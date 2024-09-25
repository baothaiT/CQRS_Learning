using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class Script: BasedTable
{
    public string Name { get; set; }
    public DateTime CreateDate { get; set; }

    public ICollection<ScriptsInProject>? ScriptsInProjects { get; set; }
}
