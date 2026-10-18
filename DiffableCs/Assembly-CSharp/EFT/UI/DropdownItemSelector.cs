namespace EFT.UI;

public sealed class DropdownItemSelector : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <SelectItem>b__0(ItemView view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public ItemView itemView; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <CreateDropdownItemView>b__0() { }

	}

	[SerializeField]
	private GameObject _container; //Field offset: 0x70
	[SerializeField]
	private GameObject _containerForFirstMap; //Field offset: 0x78
	[SerializeField]
	private Toggle _toggle; //Field offset: 0x80
	[SerializeField]
	private ScrollRect _scrollRect; //Field offset: 0x88
	[SerializeField]
	private Scrollbar _scrollbar; //Field offset: 0x90
	private readonly List _itemsCollection; //Field offset: 0x98
	private ItemView _selectedItem; //Field offset: 0xA0

	public DropdownItemSelector() { }

	private void Awake() { }

	private void Clear() { }

	public virtual void Close() { }

	private ItemView CreateDropdownItemView(SelectableItemContext sourceContext, Item item, ItemController itemController, Transform container) { }

	private void HideMenu() { }

	public void Init(IEnumerable items, InventoryController inventoryController, SelectableItemContext itemContext) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void OnShowMenuButton(bool isOn) { }

	public void SelectItem(Item item) { }

	private void ShowMenu() { }

}

