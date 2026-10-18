namespace EFT.InventoryLogic;

public sealed class OtherPlayerProfileItemContext : ItemContext
{
	private readonly EItemViewComponent[] _viewComponents; //Field offset: 0x68

	public virtual bool DragAvailable
	{
		 get { } //Length: 3
	}

	public virtual bool ModificationAvailable
	{
		 get { } //Length: 3
	}

	protected virtual IEnumerable ViewComponents
	{
		 get { } //Length: 5
	}

	private OtherPlayerProfileItemContext(Item item, EItemViewType viewType, ItemContext source) { }

	public OtherPlayerProfileItemContext(Item item, EItemViewType viewType) { }

	public virtual ItemContext CreateChild(Item item) { }

	public virtual bool get_DragAvailable() { }

	public virtual bool get_ModificationAvailable() { }

	protected virtual IEnumerable get_ViewComponents() { }

}

