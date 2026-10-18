namespace EFT.UI;

public class WishlistContextInteractions : ContextInteractions
{
	internal enum EWishlistInteractions
	{
		Quests = 0,
		Equipment = 1,
		Hideout = 2,
		Other = 3,
		Trading = 4,
		RemoveFromWishlist = 5,
	}

	private readonly Dictionary _customNames; //Field offset: 0x38
	private readonly ItemContext _itemContext; //Field offset: 0x40

	public virtual Dictionary CustomNames
	{
		 get { } //Length: 5
	}

	public virtual bool HasIcons
	{
		 get { } //Length: 3
	}

	public WishlistContextInteractions(ItemContext itemContext, ItemUiContext uiContext) { }

	protected virtual void ExecuteInteractionInternal(EWishlistInteractions interaction) { }

	public virtual Dictionary get_CustomNames() { }

	public virtual bool get_HasIcons() { }

	private static EWishlistGroup InteractionToWishlistGroup(EWishlistInteractions interaction) { }

	public virtual bool IsActive(EWishlistInteractions button) { }

	public virtual IResult IsInteractive(EWishlistInteractions button) { }

	public virtual bool TryGetCustomIcon(EWishlistInteractions key, out Sprite icon) { }

}

