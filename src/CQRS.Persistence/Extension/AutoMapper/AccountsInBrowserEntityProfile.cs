using AutoMapper;
using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Extension.AutoMapper
{
    public class AccountsInBrowserEntityProfile : Profile
    {
        public AccountsInBrowserEntityProfile()
        {
            CreateMap<AccountsInBrowserEntity, AccountsInBrowserEntity>();
        }
    }
}
