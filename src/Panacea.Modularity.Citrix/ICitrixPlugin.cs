using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Citrix
{
    public interface ICitrixPlugin : IPlugin
    {
        bool IsRunning();
        void Start(string username, string password, string domain, string server, string application);
        void Stop();
    }
}
