namespace EFT.HandBook;

public sealed class EntityListElement : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public EntityListElement <>4__this; //Field offset: 0x10
		public Profile profile; //Field offset: 0x18
		public WishlistManager wishlist; //Field offset: 0x20

		public <>c__DisplayClass24_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[SerializeField]
	private EntityIcon _icon; //Field offset: 0x70
	[SerializeField]
	private Image _background; //Field offset: 0x78
	[SerializeField]
	private GameObject _newNodeObject; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _name; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _itemCategory; //Field offset: 0x90
	[SerializeField]
	private Color32 _defaultTextColor; //Field offset: 0x98
	[SerializeField]
	private Color32 _defaultCategoryColor; //Field offset: 0x9C
	[SerializeField]
	private Color32 _hoverTextColor; //Field offset: 0xA0
	[SerializeField]
	private Color _selectedBackgroundColor; //Field offset: 0xA4
	[SerializeField]
	private GameObject _wishlistPanel; //Field offset: 0xB8
	[SerializeField]
	private Image _wishlistIcon; //Field offset: 0xC0
	[SerializeField]
	private Image _completableIcon; //Field offset: 0xC8
	private HandbookNode _node; //Field offset: 0xD0
	private Action _onChosen; //Field offset: 0xD8
	private ItemIcon _itemIcon; //Field offset: 0xE0
	private WishlistManager _wishlist; //Field offset: 0xE8
	[CompilerGenerated]
	private bool <Selected>k__BackingField; //Field offset: 0xF0

	private Color BackgroundColor
	{
		private get { } //Length: 31
	}

	private Color HoverBackgroundColor
	{
		private get { } //Length: 31
	}

	private bool Selected
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public EntityListElement() { }

	public virtual void Close() { }

	public void DeselectView() { }

	private Color get_BackgroundColor() { }

	private Color get_HoverBackgroundColor() { }

	[CompilerGenerated]
	private bool get_Selected() { }

	private void OnAddInWishlist(MongoID templateId, EWishlistGroup group) { }

	private void OnChangeWishlistGroup(MongoID templateId, EWishlistGroup group) { }

	private void OnCompletableItemStatusChange(MongoID itemTemplateId, bool completed) { }

	private void OnNewStatusUpdated(bool isNew) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void OnRemoveFromWishlist(MongoID templateId, EWishlistGroup group) { }

	private void SelectView() { }

	[CompilerGenerated]
	private void set_Selected(bool value) { }

	public void Show(HandbookNode node, Action onChosen, WishlistManager wishlist, Profile profile) { }

}

