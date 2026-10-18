namespace EFT.Hideout;

[UsedImplicitly]
public sealed class HideoutItemViewFactory : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _counterField; //Field offset: 0x70
	[SerializeField]
	private GameObject _counterContainer; //Field offset: 0x78
	[SerializeField]
	private RequirementFulfilledStatus _fulfilledStatus; //Field offset: 0x80
	[SerializeField]
	private GameObject _fulfilledStatusContainer; //Field offset: 0x88
	[SerializeField]
	private HorizontalOrVerticalLayoutGroup _horizontalLayout; //Field offset: 0x90
	[SerializeField]
	private HorizontalOrVerticalLayoutGroup _verticalLayout; //Field offset: 0x98
	[SerializeField]
	private Transform _itemViewContainer; //Field offset: 0xA0
	[SerializeField]
	private GameObject _infoContainer; //Field offset: 0xA8
	[SerializeField]
	private bool _showCounter; //Field offset: 0xB0
	[SerializeField]
	private bool _showFulfilledStatus; //Field offset: 0xB1
	[SerializeField]
	private Axis _layout; //Field offset: 0xB4
	[SerializeField]
	private HoverTooltipArea _hoverTooltipArea; //Field offset: 0xB8
	[SerializeField]
	private GameObject _errorBlock; //Field offset: 0xC0
	[CompilerGenerated]
	private ItemView <ItemView>k__BackingField; //Field offset: 0xC8

	public bool FulfilledStatus
	{
		 set { } //Length: 76
	}

	private ItemView ItemView
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutItemViewFactory() { }

	public virtual void Close() { }

	[CompilerGenerated]
	private ItemView get_ItemView() { }

	public void set_FulfilledStatus(bool value) { }

	[CompilerGenerated]
	private void set_ItemView(ItemView value) { }

	public void SetBorderColor(in Color color) { }

	public void SetCounterText(string text) { }

	public void SetError(InventoryError error) { }

	private void SetInfoLayout(Axis layoutType) { }

	public void Show(Item item, InventoryController inventoryController, ItemUiContext itemUiContext) { }

	public void ShowInfo(bool showCounter, bool showFulfilledStatus) { }

	public void ValidateFavorite() { }

}

