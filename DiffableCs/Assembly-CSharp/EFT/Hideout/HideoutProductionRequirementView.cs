namespace EFT.Hideout;

public sealed class HideoutProductionRequirementView : UIElement
{
	[SerializeField]
	private HideoutItemViewFactory _itemViewFactory; //Field offset: 0x70
	[SerializeField]
	private Image _toolMarker; //Field offset: 0x78
	[SerializeField]
	private Color _fullFilledColor; //Field offset: 0x80
	[SerializeField]
	private Color _notFilledColor; //Field offset: 0x90
	[CompilerGenerated]
	private bool <IsFulfilled>k__BackingField; //Field offset: 0xA0

	public private bool IsFulfilled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private Color ToolColor
	{
		private get { } //Length: 34
	}

	public HideoutProductionRequirementView() { }

	private void Awake() { }

	[CompilerGenerated]
	public bool get_IsFulfilled() { }

	private Color get_ToolColor() { }

	[CompilerGenerated]
	private void set_IsFulfilled(bool value) { }

	public void Show(ItemUiContext itemUiContext, InventoryController inventoryController, ItemRequirement requirement, BaseHideoutScheme scheme, IEnumerable allItems, bool canStartProduction) { }

	private void ShowToolMarker(bool isTool) { }

	public void ValidateFavorite() { }

}

