# Example Mod

This repository contains the basic solution and project setup for one (or more) C# mods for [Plan B Terraform](https://steamcommunity.com/app/1894430).

## Ingredients

- 1x Solution File
- 1x `Directory.Build.props` which sets some common settings. They're evaluated before the .csprojs are loaded.
- 1x `Directory.Build.targets` which is executed after the .csprojs and contains some glue
- 1x `<GameModule>` item properties which allow you to easier reference game assemblies and/or the game's Unity assemblies - making sure you're targetting the right version.
- 1x Example Mod .csproj with the minimal settings required.
- 1x Example Plugin setup for BepInEx 5.x
- 1x Example Harmony patch

## Installation

1. Clone this repository or download the source zip.
2. Copy the `Paths.user.example` to `Paths.user` and adjust the path to the game inside.
3. By default, the plugins are compiled straight into the game's plugins folder to be ready for use. If you don't want this, define a `<PluginFolder>` directive in your Paths.user.
4. Open the solution in your favorite IDE.
5. Hit compile. It should restore the dependencies and then compile the mod.

## Notes

This setup does not contain any special settings to "publish" assemblies. In theory, you should be able to just zip up your plugin folder and call it a day. If you need to have some sort of publishing system, you can adjust the `Directory.Build.targets` accordingly to do that. Currently, there's no plans for native support for this kind of workflow with this setup from my side.