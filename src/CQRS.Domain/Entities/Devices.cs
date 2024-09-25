using CQRS.Contract.Share.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class Devices: BasedTable
{
    public string Name { get; set; }
    public StatusEnum IsStatus { get; set; }
    public DateTime CreateDate { get; set; }

    public ICollection<PlansInSchedule>? PlansInSchedules { get; set; }
}
