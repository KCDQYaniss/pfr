namespace EFT;

public sealed class WishlistItem
{
	public readonly MongoID TemplateId; //Field offset: 0x10
	private int _category; //Field offset: 0x28

	public EWishlistGroup Group
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public WishlistItem(MongoID templateId, EWishlistGroup group) { }

	public EWishlistGroup get_Group() { }

	public void set_Group(EWishlistGroup value) { }

}

