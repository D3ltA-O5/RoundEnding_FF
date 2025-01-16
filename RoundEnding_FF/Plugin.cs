using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;

namespace RoundEndingFF
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "RoundEnding_FF";
        public override string Author => "cybercodeveloper";
        public override Version Version => new Version(1, 1, 0);
        public override Version RequiredExiledVersion => new Version(8, 11, 0);

        public override void OnEnabled()
        {
            // Subscribe to necessary server events
            Exiled.Events.Handlers.Server.EndingRound += OnEndingRound;
            Exiled.Events.Handlers.Server.RoundEnded += OnRoundEnded;

            base.OnEnabled();

            if (Config.Debug)
                Log.Info("[RoundEndingFF] Plugin has been enabled and subscribed to events.");
        }

        public override void OnDisabled()
        {
            // Unsubscribe from server events
            Exiled.Events.Handlers.Server.EndingRound -= OnEndingRound;
            Exiled.Events.Handlers.Server.RoundEnded -= OnRoundEnded;

            base.OnDisabled();

            if (Config.Debug)
                Log.Info("[RoundEndingFF] Plugin has been disabled and unsubscribed from events.");
        }

        private void OnEndingRound(EndingRoundEventArgs ev)
        {
            // Enable FriendlyFire at the end of the round
            Server.FriendlyFire = true;

            // Prepare a colored broadcast message
            string coloredMessage =
                $"<color={Config.BroadcastColor}>{Config.BroadcastMessage}</color>";

            // Send the broadcast message to all players
            Map.Broadcast(Config.BroadcastDuration, coloredMessage);

            if (Config.Debug)
                Log.Info("[RoundEndingFF] FriendlyFire has been enabled during EndingRound, and the message was sent to players.");
        }

        private void OnRoundEnded(RoundEndedEventArgs ev)
        {
            // Disable FriendlyFire after the round officially ends
            Server.FriendlyFire = false;

            if (Config.Debug)
                Log.Info("[RoundEndingFF] FriendlyFire has been disabled during RoundEnded.");
        }
    }
}
