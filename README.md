# EasyRP-GUI (Custom Discord Rich Presence with GUI)
<img src="https://i.imgur.com/XhHkcKW.png" align="right">
EasyRP-GUI is an easy program with graphical user interface to use the DiscordRPC library without any knowledge of programming.  
Instead just use this easy program. EasyRP-GUI is based on console program [EasyRP](https://github.com/Pizzabelly/EasyRP/).

## Prerequisites
- .NET Framework 4.6.1
     - It is probably already installed on your PC
- Windows only

## Installation
- Download latest release of EasyRP-GUI from [here](https://github.com/0x4d48/EasyRP-GUI/releases)
- Unpack .zip
- Run EasyRP-GUI.exe

## Usage
- First you need to register a Rich Presence application with discord
     - Go here https://discordapp.com/developers/applications/me
     - Make a new application **The name of the app will be the main name for the rich presence**
     - Enable rich presence for your app and add some assets
- Download the latest release of EasyRP-GUI from here https://github.com/0x4d48/EasyRP-GUI/releases
- Run [EasyRP-GUI.exe](https://github.com/0x4d48/EasyRP-GUI/releases) (it should open a cmd window)
- Fill out forms in the program with the information from your newly registered app
- Press on Update configuration button
- Go into Discord app settings and add the [EasyRP.exe](https://github.com/Pizzabelly/EasyRP/releases) as a game
     - Make sure to add EasyRP.exe, not GUI
- Discord should automatically change the path of [EasyRP.exe](https://github.com/Pizzabelly/EasyRP/releases) to your Discord Rich Presence

Use Restart button if EasyRP doesn't work. You don't need to use it when updating configuration. You can hide program in notification tray by minimizing program window (and make sure checkbox is ticked).
