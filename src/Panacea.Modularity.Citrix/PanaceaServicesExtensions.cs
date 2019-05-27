using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Citrix
{
    public static class PanaceaServicesExtensions
    {
        public static ICitrixPlugin GetCitrix(this PanaceaServices core)
        {
            return core.PluginLoader.GetPlugin<ICitrixPlugin>();
        }

        public static bool TryGetCitrix(this PanaceaServices core, out ICitrixPlugin plugin)
        {
            plugin = null;
            var citrix = core.PluginLoader.GetPlugins<ICitrixPlugin>().FirstOrDefault();
            if (citrix == null)
            {
                return false;
            }
            plugin = citrix;
            return true;
        }
    }
}
