using CQRS.Contract.Share.DTO;
using CQRS.Contract.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Infrastructure.Services.Interfaces;

public interface IFileService
{
     Task<List<GetProxyDto>> ReadProxies(string filePath);
}
