namespace EFT.UI;

public sealed class SimpleUIElementTabController : ITabController
{
	private readonly UIElement _content; //Field offset: 0x10

	public SimpleUIElementTabController(UIElement content) { }

	public override void Show() { }

	public override Task TryHide() { }

}

