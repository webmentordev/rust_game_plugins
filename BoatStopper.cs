using Oxide.Plugins;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Plugins
{
    [Info("BoatStopper", "Ahmer", "1.0.1")]
    [Description("Switch OFF Row Boat or Rhib Engine if noone is mounted.")]
    internal class BoatStopper: RustPlugin
    {
        void OnEntityDismounted(BaseMountable entity, BasePlayer player)
        {
            if (entity.GetParentEntity().ShortPrefabName == "rowboat")
            {
                MotorRowboat myRowBoat = entity.GetParentEntity() as MotorRowboat;
                if (!myRowBoat.AnyMounted() && !myRowBoat.HasDriver())
                {
                    myRowBoat.EngineToggle(false);
                }
            }else if(entity.GetParentEntity().ShortPrefabName == "rhib")
            {
                RHIB myRhidBoat = entity.GetParentEntity() as RHIB;
                if (!myRhidBoat.AnyMounted() && !myRhidBoat.HasDriver())
                {
                    myRhidBoat.EngineToggle(false);
                }
            }
        }
    }
}
