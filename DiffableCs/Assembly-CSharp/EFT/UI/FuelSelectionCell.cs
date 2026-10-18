namespace EFT.UI;

public sealed class FuelSelectionCell : ItemSelectionCell
{
	[SerializeField]
	private TextMeshProUGUI _details; //Field offset: 0xF8
	[SerializeField]
	private Color _defaultDetailsColor; //Field offset: 0x100
	[SerializeField]
	private Color _lowCountDetailsColor; //Field offset: 0x110
	[SerializeField]
	private Color _noItemDetailsColor; //Field offset: 0x120
	[SerializeField]
	private float _lowCountLevel; //Field offset: 0x130
	[SerializeField]
	private GameObject _noFuelPanel; //Field offset: 0x138
	[SerializeField]
	private GameObject _timePanel; //Field offset: 0x140
	[SerializeField]
	private TextMeshProUGUI _timeText; //Field offset: 0x148
	[SerializeField]
	private Image _lockIcon; //Field offset: 0x150
	private SimpleTooltip _tooltip; //Field offset: 0x158
	private float _resourceCount; //Field offset: 0x160
	private IConsumer _consumer; //Field offset: 0x168
	private EProductionState _productionState; //Field offset: 0x170

	protected virtual EContextPriorDirection Direction
	{
		 get { } //Length: 6
	}

	private ResourceComponent FuelItem
	{
		private get { } //Length: 79
	}

	public FuelSelectionCell() { }

	[CompilerGenerated]
	private void <Awake>b__17_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__17_1(PointerEventData arg) { }

	protected virtual void Awake() { }

	private void CheckSelectableStatus(Item selectedItem) { }

	public virtual void Close() { }

	protected virtual EContextPriorDirection get_Direction() { }

	private ResourceComponent get_FuelItem() { }

	protected virtual string GetDetails(Item item) { }

	private string GetDetailsText(ResourceComponent resourceHolderItem) { }

	protected virtual bool IsDropdownItemsInteractable() { }

	public virtual void SetItem(Item item) { }

	public void SetProductionState(EProductionState productionState) { }

	public void Show(Item currentSelectedItem, IConsumer consumer, Func selectionChecker, Action selectionHandler) { }

	private void Update() { }

	private void UpdateDetails() { }

}

