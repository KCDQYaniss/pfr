namespace EFT.UI;

public class BarterSchemePanel : UIElement
{
	[SerializeField]
	private DefaultUIButton _autoButton; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProInputField _quantity; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _purchaseCaption; //Field offset: 0x80
	[SerializeField]
	private ItemOnGrid _itemOnDisplay; //Field offset: 0x88
	[SerializeField]
	private GameObject _validSchemeWarning; //Field offset: 0x90
	[SerializeField]
	private CustomTextMeshProUGUI _buyRestrictionLabel; //Field offset: 0x98
	[SerializeField]
	private GameObject _buyRestrictionWarning; //Field offset: 0xA0
	[SerializeField]
	private TradingRequisitePanel _requisiteTemplate; //Field offset: 0xA8
	[SerializeField]
	private Transform _requisitesContainer; //Field offset: 0xB0
	[SerializeField]
	private ScrollRect _mainPart; //Field offset: 0xB8
	[SerializeField]
	private GameObject _noItemsSelectedPanel; //Field offset: 0xC0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xC8
	[SerializeField]
	private UpdatableToggle _autoFillRequirements; //Field offset: 0xD0
	private UpdatableToggle _autoButtonToggle; //Field offset: 0xD8
	private InventoryController _inventoryController; //Field offset: 0xE0
	private ViewList _requisites; //Field offset: 0xE8
	private Assortment _traderAssortment; //Field offset: 0xF0
	private Grid _userStashGrid; //Field offset: 0xF8
	private AutoExchange _autoExchange; //Field offset: 0x100
	[CompilerGenerated]
	private Action OnAutoFillChanged; //Field offset: 0x108

	public event Action OnAutoFillChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public bool AutoFillEnabled
	{
		 get { } //Length: 33
	}

	private int BuyRestrictionQuantity
	{
		private get { } //Length: 83
	}

	private int InputQuantity
	{
		private get { } //Length: 234
	}

	[CanBeNull]
	private Item SelectedItem
	{
		private get { } //Length: 33
	}

	private bool ShowBuyRestriction
	{
		private get { } //Length: 98
	}

	public BarterSchemePanel() { }

	[CompilerGenerated]
	private void <Awake>b__32_0(string x) { }

	[CompilerGenerated]
	private void <Awake>b__32_1() { }

	[CompilerGenerated]
	private void <Awake>b__32_2(bool arg) { }

	[CompilerGenerated]
	private void <SelectedItemChangedHandler>b__35_0(Requisite anItem, TradingRequisitePanel view) { }

	[CompilerGenerated]
	private void <Show>b__33_0() { }

	[CompilerGenerated]
	private void <Show>b__33_1() { }

	[CompilerGenerated]
	private void <Show>b__33_2() { }

	[CompilerGenerated]
	public void add_OnAutoFillChanged(Action value) { }

	private void AutoFill() { }

	private void Awake() { }

	public virtual void Close() { }

	public bool get_AutoFillEnabled() { }

	private int get_BuyRestrictionQuantity() { }

	private int get_InputQuantity() { }

	private Item get_SelectedItem() { }

	private bool get_ShowBuyRestriction() { }

	private void ItemEventHandler(EventArgs eventArgs) { }

	private void ItemExaminedHandler(ExamineItemEventArgs examineArgs) { }

	[CompilerGenerated]
	public void remove_OnAutoFillChanged(Action value) { }

	private void SelectedItemChangedHandler() { }

	private void SetAutoButtonState(bool state) { }

	private void SetBuyRestrictionStatus() { }

	public void Show(Assortment traderAssortment, InventoryController inventoryController, Grid userStashGrid, AutoExchange autoExchange) { }

	private void UpdateDisplayedItem(Item selectedItem) { }

	private void UpdateValidDealWarning() { }

}

