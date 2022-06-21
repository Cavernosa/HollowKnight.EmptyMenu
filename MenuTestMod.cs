using Modding;
using System.Collections.Generic;
using Modding.Menu;

namespace MenuTestMod
{
	public class MenuTestMod: Mod, ICustomMenuMod
	{
		public bool ToggleButtonInsideMenu { get; } = false;
		internal MenuScreen screen;
		public MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? toggleDelegates) 
		{
			this.screen = new MenuBuilder("modListMenu")
				.Build();
			return this.screen;
		}
	}
}
