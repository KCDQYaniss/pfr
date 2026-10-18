namespace EFT.InventoryLogic;

public sealed class AreaStashItemContext : InventorySelectableItemContext, IFavoriteContextComponent
{
	internal enum EItemType
	{
		Inventory = 0,
		AreaStash = 1,
		HandoverWindow = 2,
	}

	private readonly EItemViewComponent[] _areaStashViewComponents; //Field offset: 0x90
	private readonly EItemType _itemType; //Field offset: 0x98
	private readonly FavoriteItemsStorage _favoriteItems; //Field offset: 0xA0
	[CompilerGenerated]
	private readonly bool <ModificationAvailable>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private readonly bool <AddingToFavoriteAvailable>k__BackingField; //Field offset: 0xA9

	public override bool AddingToFavoriteAvailable
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual bool DragAvailable
	{
		 get { } //Length: 396
	}

	private override FavoriteItemsStorage EFT.InventoryLogic.IFavoriteContextComponent.FavoriteItems
	{
		private get { } //Length: 8
	}

	private bool IsPlayerStash
	{
		private get { } //Length: 11
	}

	public virtual bool ModificationAvailable
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual Nullable RotationLock
	{
		 get { } //Length: 84
	}

	protected virtual IEnumerable ViewComponents
	{
		 get { } //Length: 111
	}

	public AreaStashItemContext(Item item, EItemType itemType, FavoriteItemsStorage favoriteItems, bool addingToFavoriteAvailable) { }

	private AreaStashItemContext(Item item, bool modificationAvailable, EItemType itemType, FavoriteItemsStorage favoriteItems, bool addingToFavoriteAvailable, AreaStashItemContext source) { }

	public virtual bool CanQuickMoveTo(ETargetContainer targetContainer) { }

	public virtual ItemContext CreateChild(Item item) { }

	private override FavoriteItemsStorage EFT.InventoryLogic.IFavoriteContextComponent.get_FavoriteItems() { }

	private override bool EFT.InventoryLogic.IFavoriteContextComponent.ShouldSetFavoriteIcon(Item item, out bool isFavorite) { }

	[CompilerGenerated]
	public override bool get_AddingToFavoriteAvailable() { }

	public virtual bool get_DragAvailable() { }

	private bool get_IsPlayerStash() { }

	[CompilerGenerated]
	public virtual bool get_ModificationAvailable() { }

	public virtual Nullable get_RotationLock() { }

	protected virtual IEnumerable get_ViewComponents() { }

	public virtual ContextInteractions GetItemContextInteractions(Action closeAction) { }

}

