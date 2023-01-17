using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Plugins
{
    [Info("Welcomer", "Ahmer", "1.0.0")]
    [Description("Welcome Player with message!")]
    public class Welcomer : RustPlugin
    {
        void OnPlayerConnected(BasePlayer player)
        {
            player.ChatMessage("<size=16>Welcome to RustyOcean <color=#226de6>50x</color></size>.\n----------------------------\n* Server wipes evey Thursday at 6PM GMT\n* No Racism or Cheating.\n* No Teaming. Max 3 Players team is allowed.\n* Open backpack with /backpack\n* Upgrade while building with /bgrade 1-4");
        }
    }
}
