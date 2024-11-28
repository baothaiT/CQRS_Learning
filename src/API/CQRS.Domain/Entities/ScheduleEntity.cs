using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Contract.Share.Enum;

namespace CQRS.Domain.Entities;

public class ScheduleEntity: BasedTableEntity
{
    public string Name { get; set; }
    public DateTime DateTimeStart { get; set; }
    public DateTime CreateDate { get; set; }
    public StatusRunEnum IsRun { get; set; }
    public StatusEnum IsStatus { get; set; }
    public ICollection<PlansInScheduleEntity>? PlansInSchedules { get; set; }
}
