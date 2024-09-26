using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO;

public class ProxyBaseDto
{
    public string Ip { get; set; }
    public int Port { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
}
