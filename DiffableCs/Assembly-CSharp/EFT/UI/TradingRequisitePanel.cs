namespace EFT.UI;

public sealed class TradingRequisitePanel : ItemOnGrid, IContainerView, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private CustomTextMeshProUGUI _count; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _dogtagLevel; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _dogtagSide; //Field offset: 0x88
	[SerializeField]
	private GameObject _yesCheck; //Field offset: 0x90
	[SerializeField]
	private GameObject _noCheck; //Field offset: 0x98
	private SimpleTooltip _tooltip; //Field offset: 0xA0
	private Requisite _requisite; //Field offset: 0xA8
	private Assortment _traderAssortment; //Field offset: 0xB0
	private ItemUiContext _itemUiContext; //Field offset: 0xB8
	private ItemContext _itemContext; //Field offset: 0xC0

	public TradingRequisitePanel() { }

	[CompilerGenerated]
	private void <Awake>b__10_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__10_1(PointerEventData arg) { }

	public override Task AcceptItem(DragItemContext itemContext, ItemContext targetItemContext) { }

	private void Awake() { }

	public override bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	public override bool CanDrag(ItemContext itemContext) { }

	public virtual void Close() { }

	public override void DisableHighlight() { }

	public override void DragCancelled() { }

	public override void DragStarted() { }

	public override void HighlightItemViewPosition(DragItemContext itemContext, ItemContext targetItemContext, bool preview) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public void Show(Requisite requisite, Assortment trader) { }

	private void UpdateValues() { }

}

