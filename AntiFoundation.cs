using Oxide.Plugins;
using Rust;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Plugins
{
    [Info("AntiFoundation", "Ahmer", "1.0.0")]
    [Description("Protect bases from floor wipe.")]
    internal class AntiFoundation : RustPlugin
    {
        object OnEntityTakeDamage(BaseCombatEntity entity, HitInfo info)
        {
            if (entity.ShortPrefabName == "foundation" || entity.ShortPrefabName == "foundation.triangle")
            {
                BasePlayer player = info.InitiatorPlayer;
                if (info != null && info.Initiator is BasePlayer)
                {
                    player.ChatMessage("You can not damage foundations.");
                    return 0;
                }
            }
            return null;
        }
    }
}
