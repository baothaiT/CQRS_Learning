using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO;

public class BrowserBaseDto
{
    public string Name { get; set; }
    public string Path { get; set; }
    public bool IsStatus { get; set; }
    public DateTime CreateDate { get; set; }
}
