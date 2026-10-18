namespace EFT.UI;

[Obfuscation(Exclude = True)]
public class QuestListItemView : UIElement
{
	[CompilerGenerated]
	private struct <UpdateTimer>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestListItemView <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Button _questButton; //Field offset: 0x70
	[SerializeField]
	private Image _typeIcon; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _title; //Field offset: 0x80
	[SerializeField]
	private Image _starIcon; //Field offset: 0x88
	[SerializeField]
	private Image _statusIcon; //Field offset: 0x90
	[SerializeField]
	private HoverTooltipArea _statusTooltip; //Field offset: 0x98
	[SerializeField]
	private Sprite _handoverStatusSprite; //Field offset: 0xA0
	[SerializeField]
	private Sprite _newStatusSprite; //Field offset: 0xA8
	[SerializeField]
	private Sprite _lockedStatusSprite; //Field offset: 0xB0
	[SerializeField]
	private Sprite _readyToFinishStatusSprite; //Field offset: 0xB8
	[SerializeField]
	private CustomTextMeshProUGUI _timer; //Field offset: 0xC0
	[SerializeField]
	private Image _timerIcon; //Field offset: 0xC8
	[SerializeField]
	private Image _selectedIcon; //Field offset: 0xD0
	[SerializeField]
	private Image _background; //Field offset: 0xD8
	[SerializeField]
	private GameObject _dailyBackground; //Field offset: 0xE0
	[SerializeField]
	private Image _scavBackground; //Field offset: 0xE8
	[SerializeField]
	private ColorMap _backColors; //Field offset: 0xF0
	[SerializeField]
	private ColorMap _scavBackColors; //Field offset: 0xF8
	[SerializeField]
	private ColorMap _textColors; //Field offset: 0x100
	public Quest Quest; //Field offset: 0x108
	private Action _onSelect; //Field offset: 0x110
	private QuestController _questController; //Field offset: 0x118
	[CompilerGenerated]
	private Action ViewChanged; //Field offset: 0x120
	private bool _isSelected; //Field offset: 0x128
	private IEnumerator _timerWorker; //Field offset: 0x130
	private CancellationTokenSource _timerCancellation; //Field offset: 0x138

	public event Action ViewChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public Color BackgroundColor
	{
		 get { } //Length: 65
	}

	public bool IsSelected
	{
		 get { } //Length: 8
	}

	public QuestListItemView() { }

	[CompilerGenerated]
	private void <Awake>b__32_0() { }

	[CompilerGenerated]
	public void add_ViewChanged(Action value) { }

	private void Awake() { }

	public virtual void Close() { }

	public Color get_BackgroundColor() { }

	public bool get_IsSelected() { }

	private bool HandleDailyTimer(DailyQuest dailyQuest) { }

	private bool HandleDefaultTimer(int timeToFail) { }

	public void Init(Quest quest, Action onSelect, QuestController questController) { }

	private void OnEnable() { }

	private void OnHandoverConditionChanged(ConditionProgressChecker _) { }

	private void OnQuestStatusChanged(Quest quest, bool notify) { }

	private void PrepareTimer() { }

	public void RefreshStatus() { }

	[CompilerGenerated]
	public void remove_ViewChanged(Action value) { }

	public void SetSelected(bool selected) { }

	private void StopTimer() { }

	private void SubscribeToQuest() { }

	private void UnsubscribeFromQuest() { }

	private void UpdateDailyView(DailyQuest daily, bool isSelected) { }

	[AsyncStateMachine(typeof(<UpdateTimer>d__44))]
	private Task UpdateTimer(CancellationToken token) { }

	private void UpdateView() { }

}

