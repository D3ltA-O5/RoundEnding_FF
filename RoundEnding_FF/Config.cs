using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RoundEndingFF
{
    public class Config : IConfig
    {
        [Description("Включен ли плагин.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Сообщение, которое отображается всем игрокам, когда включен friendly fire.")]
        public string BroadcastMessage { get; set; } = "Friendly fire is now enabled! Have fun for the last seconds!";

        [Description("Длительность показа сообщения (в секундах).")]
        public ushort BroadcastDuration { get; set; } = 10;

        [Description("Задержка окончания раунда перед перезапуском (в секундах).")]
        public float RoundEndDelay { get; set; } = 10f;

        [Description("Включить режим отладки.")]
        public bool Debug { get; set; } = false;

        [Description("Цвет текста в broadcast-сообщении.")]
        public string BroadcastColor { get; set; } = "red";
    }
}