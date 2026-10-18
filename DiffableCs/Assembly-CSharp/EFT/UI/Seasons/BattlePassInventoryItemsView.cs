namespace EFT.UI.Seasons;

public sealed class BattlePassInventoryItemsView : UIElement
{
	private const string BATTLE_PASS_DOCUMENTS_TOOLTIP = "UI/BattlePass/DocsTooltip{0}{1}{2}{3}{4}{5}{6}"; //Field offset: 0x0
	[SerializeField]
	private BattlePassInventoryItemView _itemViewTemplate; //Field offset: 0x70
	[SerializeField]
	private List _itemContainers; //Field offset: 0x78
	[SerializeField]
	private RectTransform _poolContainer; //Field offset: 0x80
	[SerializeField]
	private BattlePassUniversalItemView _universalDocView; //Field offset: 0x88
	[SerializeField]
	private MouseEventPropagator _hintRaycastTarget; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _limitField; //Field offset: 0x98
	private readonly Dictionary _itemViews; //Field offset: 0xA0
	private UiElementPool _viewPool; //Field offset: 0xA8
	private SimpleTooltip _tooltip; //Field offset: 0xB0
	private CancellationToken _tooltipCloseToken; //Field offset: 0xB8
	private BattlePass _battlePass; //Field offset: 0xC0
	private long _tooltipTimeLeftSeconds; //Field offset: 0xC8

	private bool IsOwnTooltipActive
	{
		private get { } //Length: 150
	}

	public BattlePassInventoryItemsView() { }

	[CompilerGenerated]
	private void <Show>b__13_0(PointerEventData _) { }

	[CompilerGenerated]
	private void <Show>b__13_1(PointerEventData _) { }

	private void CloseTooltip() { }

	private bool get_IsOwnTooltipActive() { }

	private string GetTooltipText(long timeLeftSeconds) { }

	private long GetTooltipTimeLeftSeconds() { }

	public void Show(BattlePassController controller, BattlePass battlePass, IImageLoader imageLoader) { }

	private void ShowTooltip() { }

	private void Update() { }

	private void UpdateItems(BattlePassController controller, BattlePass battlePass, IImageLoader imageLoader) { }

}

