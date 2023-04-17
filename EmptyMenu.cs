using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using System.Reflection;
using UnityEngine;

namespace EmptyMenu
{
	public class EmptyMenu: Mod, ICustomMenuMod
	{
		public override string GetVersion() => Assembly.GetExecutingAssembly().GetName().Version.ToString();  

		public bool ToggleButtonInsideMenu { get; } = false;
		internal MenuScreen screen;
		public MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? toggleDelegates) 
		{
			this.screen = new MenuBuilder("emptyMenu")
				.CreateControlPane(RectTransformData.FromSizeAndPos(
							new RelVector2(),
							new AnchoredPosition(new Vector2(),new Vector2(),
								new Vector2(0f, -100f) /*Offset*/
								)
							))
				.SetDefaultNavGraph(new GridNavGraph(1))
				.AddControls(
						new SingleContentLayout(new AnchoredPosition()),
						c => c.AddMenuButton(
							"BackButton",
							new MenuButtonConfig {
							Label = "Back",
							CancelAction = self => UIManager.instance.UIGoToDynamicMenu(modListMenu),
							SubmitAction = self => UIManager.instance.UIGoToDynamicMenu(modListMenu),
							Proceed = true
							}
							)
					    )
				.Build();
			return this.screen;
		}
	}
}
