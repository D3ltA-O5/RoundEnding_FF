using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RoundEndingFF
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;

        public string BroadcastMessage { get; set; } =
            "Friendly fire is now enabled! Have fun for the last seconds!";

        public ushort BroadcastDuration { get; set; } = 10;

        public string BroadcastColor { get; set; } = "red";
    }
}
