using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO;

public class GetProxyDto: ProxyBaseDto
{
    public Guid Id { get; set; }
    public bool IsDelete { get; set; }

    //public GetProxyDto(string ip, int port, string username, string password)
    //{
    //    Ip = ip;
    //    Port = port;
    //    User = username;
    //    Password = password;
    //}
}
