using System.Collections.Generic;
using System.Linq;
using Rust.Ai;
using Oxide.Core;

namespace Oxide.Plugins
{
    [Info("NoAirWolfVendor", "Ahmer", "1.0.0")]
    [Description("Disable Air Wolf Vendor on Bandit Camp who sells Minicopter & Transport Helicopter")]
    class NoAirWolfVendor : RustPlugin
    {
        /*
            I had a problem with Minicopter on my PVE server where If you buy the Mini, it spawns with 17k
            Low Grade which was suppose to be just 100. So i decided to disable it. But i had Vehicle License
            Plugin. You can use it too.
        */
        bool? OnNpcConversationStart(VehicleVendor vendor, BasePlayer player, ConversationData conversationData)
        {
            if (conversationData.shortname == "airwolf_heli_vendor")
            {
                player.ChatMessage("AirWolf Vendor is permanently disabled.");
                return false;
            }
            return null;
        }
    }
}
