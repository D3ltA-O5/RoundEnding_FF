using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Server;
using MEC;

namespace RoundEndingFF
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "RoundEnding_FF";
        public override string Author => "D3ltA_O5";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 11, 0);

        public override void OnEnabled()
        {
            if (!Config.IsEnabled)
                return;

            Exiled.Events.Handlers.Server.RoundEnded += OnRoundEnded;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundEnded -= OnRoundEnded;
            base.OnDisabled();
        }

        private void OnRoundEnded(RoundEndedEventArgs ev)
        {
            // Enable friendly fire
            Server.FriendlyFire = true;

            // Create colored message
            string coloredMessage = $"<color={Config.BroadcastColor}>{Config.BroadcastMessage}</color>";

            // Show message to all players
            Map.Broadcast(Config.BroadcastDuration, coloredMessage);

            // Restart server after a brief moment
            Timing.CallDelayed(5f, () =>
            {
                // Disable friendly fire before restarting
                Server.FriendlyFire = false;
                Server.Restart();
            });
        }
    }
}
