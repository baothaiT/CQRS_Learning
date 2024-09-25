using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class BasedTable
{
    public Guid Id { get; set; }
    public bool IsDelete { get; set; }
}
