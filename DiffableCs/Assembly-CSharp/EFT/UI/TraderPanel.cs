namespace EFT.UI;

public sealed class TraderPanel : UIElement
{
	private const double INTERVAL_SECONDS = 1; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _nickName; //Field offset: 0x70
	[SerializeField]
	private RankPanel _rankPanel; //Field offset: 0x78
	[SerializeField]
	private GameObject _questionMark; //Field offset: 0x80
	[SerializeField]
	private GameObject _newTraderLabel; //Field offset: 0x88
	[SerializeField]
	private TraderAvatar _traderAvatar; //Field offset: 0x90
	[SerializeField]
	private CustomTextMeshProUGUI _standing; //Field offset: 0x98
	[SerializeField]
	private CustomTextMeshProUGUI _timeLeft; //Field offset: 0xA0
	[SerializeField]
	private TraderHoverPanel _proceedPanel; //Field offset: 0xA8
	[SerializeField]
	private CanvasGroup _baseInfoGroup; //Field offset: 0xB0
	[SerializeField]
	private GameObject _detailsGroup; //Field offset: 0xB8
	[SerializeField]
	private GameObject _hiddenGroup; //Field offset: 0xC0
	[SerializeField]
	private GameObject _timeGroup; //Field offset: 0xC8
	[SerializeField]
	private GameObject _restockedGroup; //Field offset: 0xD0
	private TraderTooltip _tooltip; //Field offset: 0xD8
	private DateTime _lastTimerUpdate; //Field offset: 0xE0
	private TraderInfo _traderInfo; //Field offset: 0xE8
	private Action _onBarterSelected; //Field offset: 0xF0

	public string TraderId
	{
		 get { } //Length: 33
	}

	public TraderPanel() { }

	[CompilerGenerated]
	private void <Awake>b__20_0(PointerEventData _) { }

	[CompilerGenerated]
	private void <Awake>b__20_1(PointerEventData _) { }

	[CompilerGenerated]
	private void <Show>b__21_0() { }

	[CompilerGenerated]
	private void <Show>b__21_1() { }

	[CompilerGenerated]
	private void <Show>b__21_2() { }

	public void Awake() { }

	public string get_TraderId() { }

	public void SelectBarter() { }

	public void Show(TraderInfo trader, QuestController quests, TraderTooltip tooltip, bool traderHasDialogue, Action onBarterSelected) { }

	private void Update() { }

	private void UpdateLoyalty() { }

	private void UpdateStanding() { }

	private void UpdateTraderInfo() { }

}

