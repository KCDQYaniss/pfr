namespace EFT.UI;

public abstract class SimpleTabController : ITabController
{

	protected SimpleTabController() { }

	public abstract void Show() { }

	public override Task TryHide() { }

}

