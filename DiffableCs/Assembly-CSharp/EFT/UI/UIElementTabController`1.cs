namespace EFT.UI;

public abstract class UIElementTabController`1 : ITabController
{
	protected readonly TContent Content; //Field offset: 0x0

	protected UIElementTabController`1(TContent content) { }

	public abstract void Show() { }

	public override Task TryHide() { }

}

