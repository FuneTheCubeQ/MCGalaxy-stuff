### Plugins and commands for MCGalaxy


### Commands
| Name | Description |
| ------------- | -----|
|  **CmdMeow** | Took panda's /banall plugin to make this.
|  **CmdQuack** | Was super easy to make lol. (YOU NEED TWO CUSTOM COLORS %j AND %z)


### Plugins
| Name | Description |
| ------------- | -----|

# Installation

### How to install plugins:
1. Put the plugin's .cs file into the **./plugins/** folder. If it's not there, make a new folder and put it in there.
2. Either in-game or via the server console, type **/pcompile [plugin name]**. It should say **Plugin compiled successfully.**, if it doesn't, something is wrong on the plugin
3. Now type **/pload [plugin name]**. It should say **Plugin loaded successfully.**
4. And you're done, enjoy your plugin.

### How to install commands:
1. Put the command's .cs file into the **./extra/commands/source/** folder. If it's not there, make a new folder and put it in there.
2. Either in-game or via the server console, type **/compile [command name]**. It should say **Command compiled successfully.**, if it doesn't, something is wrong on the command.
3. Now type **/cmdload [command name]**. It should say **Command loaded successfully.**
4. And you're done, enjoy your command.

`NOTE:`
If you want your commands to load upon server start, you should add the command name into the `./text/cmdautoload.txt` file.

For example, if your command file is named `CmdHelloWorld.cs`, you would put `HelloWorld` on a new line.
