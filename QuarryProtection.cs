using System.Collections.Generic;
using System.Linq;
using Oxide.Core;
using UnityEngine;

namespace Oxide.Plugins
{
    [Info("QuarryProtection", "Ahmer", "1.0.0")]
    [Description("Protect Quarry from Unauthorized Players to Turn On and Off.")]
    class QuarryProtection : RustPlugin
    {
        void OnQuarryToggled(MiningQuarry quarry, BasePlayer player)
        {
            if(quarry.OwnerID != player.userID && quarry.OwnerID != 0){
                player.ChatMessage($"You do not have the permission to stop the quarry.");
                quarry.EngineSwitch(true);            
            }
        }
    }
}