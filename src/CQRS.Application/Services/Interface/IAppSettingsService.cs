﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Services.Interface
{
    public interface IAppSettingsService
    {
        string GetSetting(string key);
    }
}