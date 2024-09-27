using CQRS.Contract.Share.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO;

public class ProjectBaseDto
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime CreateDate { get; set; }

    //public ICollection<AccountsInProjectEntity>? AccountsInProject { get; set; }
    //public ICollection<ScriptsInProjectEntity>? ScriptsInProjects { get; set; }
}
