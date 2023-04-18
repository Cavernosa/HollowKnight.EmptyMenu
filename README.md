# HollowKnight.EmptyMenu
I made this to get recordings of the various menu styles present in the game without the UI (like the text and animated fleurs) in the way.
For a demo of what it can do, see: [All Menu Styles (No HUD)](https://www.youtube.com/watch?v=LV4qxjWMHGM)

This mod doesn't remove the Modding Api text at the top so you'll have to do some work-arounds around that. In Linux, for example, you can use `xdotool` (X11) to precisely resize the window vertically so the mod list gets hidden in the black space.

The code is very simple, assembled together from these sources:
* https://github.com/Yurihaia/HollowKnight-Timer/blob/timer-1.5/src/HKTimer.cs#L70-L252 ([a](https://web.archive.org/https://github.com/Yurihaia/HollowKnight-Timer/blob/timer-1.5/src/HKTimer.cs))
* https://github.com/hk-modding/api/blob/master/Assembly-CSharp/ModListMenu.cs#L24 ([a](https://web.archive.org/https://github.com/hk-modding/api/blob/master/Assembly-CSharp/ModListMenu.cs))
* https://hk-modding.github.io/api/articles/menu_api.html ([a](https://web.archive.org/https://hk-modding.github.io/api/articles/menu_api.html))

## Installation
Install the `EmptyMenu` mod in [Scarab](https://github.com/fifty-six/Scarab), or manually from the [latest release](https://github.com/Cavernosa/HollowKnight.EmptyMenu/releases/latest/download/EmptyMenu.dll).

## Usage
The empty menu is found in "Main Menu" > Options > Mods > "EmptyMenu Options"

To go back, press BACK or SUBMIT (Escape or Enter in a keyboard)

## Build
1. Get something to build C#. I use dotnet-sdk (available in most distros repos)
2. Download the repository and enter the downloaded folder
3. Edit the `ProjectFile.csproj` to suit your system, mainly the `HollowKnightRefs` tag.
4. `dotnet build` or whatever you're using to build

The built dll will be in `Exports/EmptyMenu/`, so you need to copy it to the Mods folder.

