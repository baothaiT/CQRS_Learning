using AutoMapper;
using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Extension.AutoMapper
{
    public class BrowserEntityProfile : Profile
    {
        public BrowserEntityProfile()
        {
            // Ignore the primary key (Id) to avoid overwriting it
            CreateMap<BrowserEntity, BrowserEntity>();
        }
    }
}
