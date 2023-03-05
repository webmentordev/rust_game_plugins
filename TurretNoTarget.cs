using System.Collections.Generic;
using System.Linq;
using Rust.Ai;
using Oxide.Core;

namespace Oxide.Plugins
{
    [Info("TurretNoTarget", "Ahmer", "1.0.0")]
    [Description("Turrets Ignore Zombies, Murderers and Scientists")]
    class TurretNoTarget : RustPlugin
    {
        object OnTurretTarget(AutoTurret turret, BaseCombatEntity entity)
        {
            if (entity != null && entity.ShortPrefabName == "scarecrow") return true;
            if (entity != null && entity.ShortPrefabName == "scientistnpc_heavy") return true;
            return null;
        }
    }
}
