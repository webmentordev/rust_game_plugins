using Oxide.Plugins;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Plugins
{
    [Info("BoatStopper", "Ahmer", "1.0.0")]
    [Description("Stop Row Boat, If noone is on it.")]
    internal class BoatStopper: RustPlugin
    {
        object OnEntityDismounted(BaseMountable entity, BasePlayer player)
        {
            MotorRowboat myRowBoat = entity.GetParentEntity() as MotorRowboat;
            if(!myRowBoat.AnyMounted() && !myRowBoat.HasDriver())
            {
                myRowBoat.EngineToggle(false);
            }
            return null;
        }
    }
}
