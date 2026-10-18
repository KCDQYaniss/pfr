namespace EFT.UI;

public sealed class ScreenVisibilityTabController`1 : ITabController
{
	private readonly TContent _screen; //Field offset: 0x0
	private readonly Action _showAction; //Field offset: 0x0
	private readonly Action _hideAction; //Field offset: 0x0

	public ScreenVisibilityTabController`1(TContent screen, Action showAction, Action hideAction = null) { }

	public override void Show() { }

	public override Task TryHide() { }

}

