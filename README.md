# HollowKnight.EmptyMenu
I made this to get recordings of the various menu styles present in the game without the text and fleurs in the way.
This mod literally only implements an empty menu screen, which means no way to get out once you're in the menu.

It also doesn't remove the Modding Api text at the top so you'll have to do some workarounds around that:
* For linux (or any system running X.org I guess) just use `xdotool` to resize and move the game window so the text doesn't appear. You should only need to resize a couple pixels vertical
* For windows you're on your own lmao

__If you know a better method (or a method for windows) send a message/pull request/issue__

Don't give too much thought about the code, i assembled it together from breadcrumbs:

https://github.com/Yurihaia/HollowKnight-Timer/blob/timer-1.5/src/HKTimer.cs#L70-L252 ([a](https://web.archive.org/https://github.com/Yurihaia/HollowKnight-Timer/blob/timer-1.5/src/HKTimer.cs))

https://github.com/hk-modding/api/blob/master/Assembly-CSharp/ModListMenu.cs#L24 ([a](https://web.archive.org/https://github.com/hk-modding/api/blob/master/Assembly-CSharp/ModListMenu.cs))

https://hk-modding.github.io/api/articles/menu_api.html ([a](https://web.archive.org/https://hk-modding.github.io/api/articles/menu_api.html))

Install just like any other mod
