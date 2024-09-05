# RoundEnds Friendly Fire Plugin for SCP: Secret Laboratory

This plugin enables friendly fire at the end of each round in SCP: Secret Laboratory, allowing players to engage in combat after the main game events have concluded. It's designed to add an extra layer of excitement and unpredictability to the game.

## Features

- **Automatic Friendly Fire Activation**: Friendly fire is automatically enabled at the end of each round.
- **Custom Broadcast Message**: Displays a customizable message to all players when friendly fire is activated.
- **Automatic Friendly Fire Deactivation**: Friendly fire is disabled, and the server is restarted after the end of the round.

## Requirements

- **SCP: Secret Laboratory** game server
- **Exiled API** version 8.11.0 or higher

## Installation

1. **Download the Plugin**  
   Download the latest release of the `RoundEnds Friendly Fire` plugin from the [Releases](https://github.com/YourRepository/Releases) page.

2. **Move the Plugin to Your Server**  
   Place the downloaded `.dll` file into the `Plugins` folder of your SCP: SL server directory.

3. **Restart the Server**  
   Restart your SCP: SL server to load the plugin.

## Configuration

After the plugin is installed, a configuration file will be generated in your server's `Configs` folder. You can customize the following settings:

- **IsEnabled**: Enables or disables the plugin (default: `true`).
- **BroadcastColor**: Sets the color of the broadcast message (default: `red`).
- **BroadcastMessage**: Custom message displayed to players when friendly fire is enabled (default: `"Friendly fire is now enabled!"`).
- **BroadcastDuration**: Duration of the broadcast message in seconds (default: `10`).
- **RoundEndDelay**: Delay before ending the round after friendly fire is enabled (default: `60`).

## Usage

Once the plugin is installed and configured, it will automatically activate friendly fire at the end of each round. Players will see a broadcast message informing them when friendly fire is active.

## Contributing

If you'd like to contribute to the development of this plugin, feel free to fork the repository and submit a pull request!

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/YourRepository/LICENSE) file for more details.

## Support

For support, please create an issue in the [GitHub repository](https://github.com/YourRepository/Issues).

## Author

**D3ltA_O5**  
Feel free to reach out if you have any questions or need further assistance.

---
