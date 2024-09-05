using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System.Collections.Generic;
using Exiled.Events.EventArgs.Server;

namespace RoundEndingFF
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "RoundEnding_FF";
        public override string Author => "D3ltA_O5";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 11, 0);

        private CoroutineHandle _roundEndHandle;

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
            // Активируем friendly fire
            Server.FriendlyFire = true;

            // Формируем сообщение с цветом
            string coloredMessage = $"<color={Config.BroadcastColor}>{Config.BroadcastMessage}</color>";

            // Показываем сообщение всем игрокам
            Map.Broadcast(Config.BroadcastDuration, coloredMessage);

            // Задерживаем конец раунда
            _roundEndHandle = Timing.CallDelayed(Config.RoundEndDelay, () =>
            {
                // Деактивируем friendly fire
                Server.FriendlyFire = false;
                Server.Restart();
            });
        }
    }
}