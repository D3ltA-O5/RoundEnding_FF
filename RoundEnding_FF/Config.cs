using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RoundEndingFF
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Message displayed to all players when friendly fire is enabled.")]
        public string BroadcastMessage { get; set; } = "Friendly fire is now enabled! Have fun for the last seconds!";

        [Description("Duration of the broadcast message (in seconds).")]
        public ushort BroadcastDuration { get; set; } = 10;

        [Description("Enable debug mode.")]
        public bool Debug { get; set; } = false;

        [Description("Text color for the broadcast message.")]
        public string BroadcastColor { get; set; } = "red";
    }
}