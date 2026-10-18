namespace UI.DragAndDrop.ItemViews;

public sealed class WishlistGridView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public WishlistManager manager; //Field offset: 0x10
		public WishlistGridView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private GameObject _glow; //Field offset: 0x70
	[SerializeField]
	private GameObject _border; //Field offset: 0x78
	[SerializeField]
	private Image _icon; //Field offset: 0x80
	private MongoID _templateId; //Field offset: 0x88
	private WishlistManager _wishlist; //Field offset: 0xA0

	public WishlistGridView() { }

	private void OnAddInWishlist(MongoID templateId, EWishlistGroup group) { }

	private void OnChangeWishlistGroup(MongoID templateId, EWishlistGroup group) { }

	private void OnRemoveFromWishlist(MongoID templateId, EWishlistGroup group) { }

	private void SetElementsActive(bool active) { }

	public void SetExamined(bool examined) { }

	private void SetIcon(EWishlistGroup groupType) { }

	public void Show(WishlistManager manager, MongoID templateId, bool examined) { }

}

