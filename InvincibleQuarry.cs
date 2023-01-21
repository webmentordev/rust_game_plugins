using Oxide.Plugins;
using Rust;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Plugins
{
    [Info("InvincibleQuarry", "Ahmer", "1.0.0")]
    [Description("Quarries Take no damage. Best Plugin for PVE Servers.")]
    internal class InvincibleQuarry : RustPlugin
    {
        /*
            This plugin will disable damage to all quarries set by a player
            Not even owner of a quarry can damage it. It will also prevent
            damage from Helicopetr incendiary rockets.
         */

        object OnEntityTakeDamage(BaseCombatEntity entity, HitInfo info)
        {
            if(entity.ShortPrefabName == "mining_quarry" || entity.ShortPrefabName == "mining.pumpjack")
            {
                BasePlayer player = info.InitiatorPlayer;
                if (info != null && info.Initiator is BasePlayer)
                {
                    player.ChatMessage("You can not damage mining quarries.");
                    return 0;
                }else if (info.damageTypes.GetMajorityDamageType() == DamageType.Heat)
                {
                    return 0;
                }
            }
            return null;
        }
    }
}
