namespace EFT.UI;

[UsedImplicitly]
public class TraderDialogWindow : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public ClientDialogController clientDialogController; //Field offset: 0x10
		public TraderDialogWindow <>4__this; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <Show>b__0() { }

	}

	private const string NEXT_PAGE_LOCALE_KEY = "Trading/Dialog/NextPage"; //Field offset: 0x0
	private const string BACK_PAGE_LOCALE_KEY = "Trading/Dialog/BackPage"; //Field offset: 0x0
	[SerializeField]
	private TraderDialogHistoryView _dialogHistoryView; //Field offset: 0x70
	[SerializeField]
	protected ToggleButton _historyButton; //Field offset: 0x78
	[SerializeField]
	private TraderDialogWindowOptionRow _dialogRow; //Field offset: 0x80
	[SerializeField]
	protected TextMeshProUGUI _traderText; //Field offset: 0x88
	[SerializeField]
	protected TextMeshProUGUI _traderName; //Field offset: 0x90
	[SerializeField]
	protected Image _linesIcon; //Field offset: 0x98
	[SerializeField]
	private RectTransform _linesContainer; //Field offset: 0xA0
	[SerializeField]
	protected CanvasGroup _optionsCanvasGroup; //Field offset: 0xA8
	protected ClientDialogController dialogController; //Field offset: 0xB0
	protected readonly CompositeDisposable stateDisposable; //Field offset: 0xB8
	protected readonly List rowsSpawned; //Field offset: 0xC0
	protected Nullable lastNpcId; //Field offset: 0xC8
	protected Dictionary traderInfos; //Field offset: 0xE8
	protected MongoID mainTraderId; //Field offset: 0xF0
	private bool _hasAnimator; //Field offset: 0x108
	private int _currentPageIndex; //Field offset: 0x10C
	private BaseTraderDialog _lastDialog; //Field offset: 0x110

	private int LinesOnPage
	{
		private get { } //Length: 72
	}

	public TraderDialogWindow() { }

	[CompilerGenerated]
	private void <RenderPaginatedLines>b__31_0() { }

	[CompilerGenerated]
	private void <RenderPaginatedLines>b__31_1() { }

	protected TraderDialogWindowOptionRow AddLine() { }

	protected override void AssemblePlayerRows(BaseTraderDialog dialog) { }

	private void Block(bool block) { }

	private int get_LinesOnPage() { }

	protected void HideHistory() { }

	private void HideUnusedRows(int usedCount) { }

	private void RebuildCurrentPage() { }

	protected override void Redraw(BaseTraderDialog dialog) { }

	private int RenderLines(IReadOnlyCollection lines, int linesReady) { }

	private int RenderPaginatedLines(IReadOnlyCollection playerLines, int linesReady) { }

	protected override void SetHidePlayerChoices(bool isHidden) { }

	public void Show(ClientDialogController clientDialogController, MongoID traderId, Dictionary profileTraderInfos, bool hasAnimator = false) { }

	private void ToggleHistory(bool isActive) { }

}

