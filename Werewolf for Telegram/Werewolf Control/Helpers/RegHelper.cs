using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Config;

namespace Werewolf_Control.Helpers
{
    public static class RegHelper
    {
        public static string GetRegValue(string key)
        {
            return Config.Config.GetByKey(key);
        }
    }
}
