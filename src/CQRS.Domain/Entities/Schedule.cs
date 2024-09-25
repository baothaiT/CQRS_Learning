using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Contract.Share.Enum;

namespace CQRS.Domain.Entities;

public class Schedule: BasedTable
{
    public string Name { get; set; }
    public DateTime DateTimeStart { get; set; }
    public DateTime CreateDate { get; set; }
    public StatusRunEnum IsRun { get; set; }
    public StatusEnum IsStatus { get; set; }
    public ICollection<PlansInSchedule>? PlansInSchedules { get; set; }
}
