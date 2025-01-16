using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RoundEndingFF
{
    public class Config : IConfig
    {
        [Description("Включён ли плагин.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Включить режим отладки (вывод подробных логов).")]
        public bool Debug { get; set; } = false;

        [Description("Сообщение, которое увидят все игроки при включении FriendlyFire.")]
        public string BroadcastMessage { get; set; } =
            "Friendly fire is now enabled! Have fun for the last seconds!";

        [Description("Продолжительность широковещательного сообщения (в секундах).")]
        public ushort BroadcastDuration { get; set; } = 10;

        [Description("Цвет текста в широковещательном сообщении.")]
        public string BroadcastColor { get; set; } = "red";
    }
}
