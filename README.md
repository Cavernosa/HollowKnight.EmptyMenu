# HollowKnight.EmptyMenu
I made this to get recordings of the various menu styles present in the game without the text and animated fleurs in the way. 
For a demo of what it can do, see: https://www.youtube.com/watch?v=LV4qxjWMHGM

This mod literally only implements an empty menu screen, which means no way to get out once you're in the empty menu.

It also doesn't remove the Modding Api text at the top so you'll have to do some workarounds around that:
* For linux (or any system running X.org I guess) just use `xdotool` to resize and move the game window so the text doesn't appear. You should only need to resize a couple pixels vertical
* For windows you're on your own lmao

__If you know a better method (or a method for windows) send a message/pull request/issue__

Don't think too much about the code, i assembled it together from breadcrumbs:

* https://github.com/Yurihaia/HollowKnight-Timer/blob/timer-1.5/src/HKTimer.cs#L70-L252 ([a](https://web.archive.org/https://github.com/Yurihaia/HollowKnight-Timer/blob/timer-1.5/src/HKTimer.cs))

* https://github.com/hk-modding/api/blob/master/Assembly-CSharp/ModListMenu.cs#L24 ([a](https://web.archive.org/https://github.com/hk-modding/api/blob/master/Assembly-CSharp/ModListMenu.cs))

* https://hk-modding.github.io/api/articles/menu_api.html ([a](https://web.archive.org/https://hk-modding.github.io/api/articles/menu_api.html))

## Usage
1. Install just like any other mod
2. The empty menu is found in "Main Menu" > Options > Mods > "MenuTestMod Options"

## Build
1. Get something to build C#. I use dotnet-sdk
2. Download the repository, enter the downloaded folder
3. Edit the `ProjectFile.csproj` to suit your system
4. `dotnet build` or whatever you're using to build

The built dll will be in `Exports/MenuTestMod/`
