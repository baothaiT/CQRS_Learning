using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.Worker.Services.Interface
{
    public interface IAppSettingsService
    {
        string GetSetting(string key);
    }
}
