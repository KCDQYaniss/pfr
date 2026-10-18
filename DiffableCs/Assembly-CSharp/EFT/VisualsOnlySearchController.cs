namespace EFT;

public sealed class VisualsOnlySearchController : FakeSearchController
{
	public static readonly VisualsOnlySearchController Instance; //Field offset: 0x0

	private static VisualsOnlySearchController() { }

	private VisualsOnlySearchController() { }

	public virtual bool IsItemKnown(Item item, ItemAddress itemAddress = null) { }

	public virtual bool IsSearched(SearchableItem item) { }

}

