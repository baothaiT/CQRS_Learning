﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO;

public class GetAccountsInProjectDto : AccountsInProjectBaseDto
{
    public Guid Id { get; set; }
    public bool IsDelete { get; set; }
}
