namespace EFT.UI;

public sealed class SimpleSpecifiedContextButtons : MonoBehaviour
{
	internal class ButtonTemplateDictionary`1 : SerializableEnumDictionary
	{

		public ButtonTemplateDictionary`1() { }

		public SimpleContextMenuButton GetTemplate(TEnum key, SimpleContextMenuButton defaultButton) { }

	}

	internal sealed class FriendInteractionButtonDictionary : ButtonTemplateDictionary
	{

		public FriendInteractionButtonDictionary() { }

	}

	internal sealed class ItemInfoButtonDictionary : ButtonTemplateDictionary
	{

		public ItemInfoButtonDictionary() { }

	}

	internal sealed class WishlistInteractionsDictionary : ButtonTemplateDictionary
	{

		public WishlistInteractionsDictionary() { }

	}

	[SerializeField]
	private ItemInfoButtonDictionary _itemInfoButtons; //Field offset: 0x20
	[SerializeField]
	private FriendInteractionButtonDictionary _friendInteractionButtons; //Field offset: 0x28
	[SerializeField]
	private WishlistInteractionsDictionary _wishlistInteractions; //Field offset: 0x30

	public SimpleSpecifiedContextButtons() { }

	public SimpleContextMenuButton GetSpecifiedButton(T key, SimpleContextMenuButton defaultButton) { }

}

