using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace RSMFreecam
{
    public class Main : BaseScript
    {
        bool IsInFreecam = false;

        public Main()
        {
            EventHandlers["onClientResourceStart"] += new Action<string>(ResourceStart);
        }

        private async void ResourceStart(string Name)
        {
            if (GetCurrentResourceName() != Name) return;

            RegisterCommand("freecam", new Action<int, List<object>, string>((source, args, raw) =>
            {
                IsInFreecam = !IsInFreecam;
                if (IsInFreecam)
                {
                    SendBasicMessage("You are now in freecam! Type /freecam again to disable freecam.");
                    Freecam.Enable();
                }
                else
                    Freecam.Disable();
            }), false);
        }

        public static void SendBasicMessage(string message)
        {
            TriggerEvent("chat:addMessage", new
            {
                color = new[] { 255, 187, 0 },
                args = new[] { "[Freecam]", message }
            });
        }
    }
}
