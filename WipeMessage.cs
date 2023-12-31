using System.Text;

namespace Oxide.Plugins
{
    [Info("WipeMessage", "Ahmer", "1.0.0"), Description("Show wipe message in chat with !wipe trigger.")]
    class WipeMessage : RustPlugin
    {
        private string Message;

        protected override void LoadDefaultConfig()
        {
            Config.Clear();
            Config["Message"] = "Every Week, friday at GMT +2 17:00";
            SaveConfig();
        }

        void Init()
        {
            LoadConfigValues();
        }

        void LoadConfigValues()
        {
            Message = Config.Get<string>("Message");				
        }

        private void OnPlayerChat(BasePlayer player, string message, ConVar.Chat.ChatChannel channel)
        {
            if (message == "!wipe")
            {
                player.ChatMessage(Message.ToString());
            }
        }
    }
}