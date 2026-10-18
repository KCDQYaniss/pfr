namespace EFT.UI;

public sealed class SeasonWidget : ButtonFeedback
{
	private struct EnvironmentOverride
	{
		[SerializeField]
		private EEnvironmentUIType _environmentUiType; //Field offset: 0x0
		[SerializeField]
		private bool _overrideHoverTextColor; //Field offset: 0x4
		[SerializeField]
		private Color _hoverTextColor; //Field offset: 0x8
		[SerializeField]
		private bool _overrideLineColor; //Field offset: 0x18
		[SerializeField]
		private Color _lineColor; //Field offset: 0x1C
		[SerializeField]
		private bool _overrideArrowColor; //Field offset: 0x2C
		[SerializeField]
		private Color _arrowColor; //Field offset: 0x30
		[SerializeField]
		private bool _overrideHoverBackgroundColor; //Field offset: 0x40
		[SerializeField]
		private Color _hoverBackgroundColor; //Field offset: 0x44

		public EEnvironmentUIType EnvironmentUiType
		{
			 get { } //Length: 3
		}

		public EEnvironmentUIType get_EnvironmentUiType() { }

		public bool TryGetArrowColor(out Color color) { }

		public bool TryGetHoverBackgroundColor(out Color color) { }

		public bool TryGetHoverTextColor(out Color color) { }

		public bool TryGetLineColor(out Color color) { }

	}

	private const string TIME_LEFT_KEY = "UI/TimeLeft/DHM{0}{1}{2}"; //Field offset: 0x0
	[SerializeField]
	private SpriteAnimationPlayer[] _spriteAnimationPlayers; //Field offset: 0xA8
	[SerializeField]
	private StreamingVideoPlayer _logoVideoPlayer; //Field offset: 0xB0
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0xB8
	[SerializeField]
	private Image _backgroundHoverImage; //Field offset: 0xC0
	[SerializeField]
	private Sprite _darkBackgroundSprite; //Field offset: 0xC8
	[SerializeField]
	private Sprite _darkHoverBackgroundSprite; //Field offset: 0xD0
	[SerializeField]
	private Sprite _lightBackgroundSprite; //Field offset: 0xD8
	[SerializeField]
	private Sprite _lightHoverBackgroundSprite; //Field offset: 0xE0
	[SerializeField]
	private EEnvironmentUIType[] _darkBackgroundEnvironments; //Field offset: 0xE8
	[SerializeField]
	private TextMeshProUGUI _hoverText; //Field offset: 0xF0
	[SerializeField]
	private Image _battlePassActionLine; //Field offset: 0xF8
	[SerializeField]
	private Image _battlePassActionArrows; //Field offset: 0x100
	[SerializeField]
	private Image _hoverBlockBackgroundImage; //Field offset: 0x108
	[SerializeField]
	private EnvironmentOverride[] _environmentOverrides; //Field offset: 0x110
	[SerializeField]
	private TextMeshProUGUI _battlePassRewardsLabel; //Field offset: 0x118
	[SerializeField]
	private CanvasGroup _battlePassAction; //Field offset: 0x120
	[SerializeField]
	private GameObject _availableRewardsBlock; //Field offset: 0x128
	[SerializeField]
	private TextMeshProUGUI _availableRewardsLabel; //Field offset: 0x130
	[SerializeField]
	private GameObject _timerBlock; //Field offset: 0x138
	[SerializeField]
	private TextMeshProUGUI _timerLabel; //Field offset: 0x140
	[SerializeField]
	private Color _timerNormalColor; //Field offset: 0x148
	[SerializeField]
	private Color _timerCriticalColor; //Field offset: 0x158
	[SerializeField]
	private int _criticalTimeThresholdMinutes; //Field offset: 0x168
	[SerializeField]
	private bool _showTimerBlock; //Field offset: 0x16C
	[SerializeField]
	private bool _showAvailableRewardsBlock; //Field offset: 0x16D
	[SerializeField]
	private bool _handleClick; //Field offset: 0x16E
	[SerializeField]
	private AudioClipConfig _hoverLoopConfig; //Field offset: 0x170
	private SeasonWidgetData _data; //Field offset: 0x178
	private int _endTimestamp; //Field offset: 0x184
	private DateTime _lastTimerUpdateUtc; //Field offset: 0x188
	private bool _timerActive; //Field offset: 0x190
	private Nullable _defaultHoverTextColor; //Field offset: 0x194
	private Nullable _defaultLineColor; //Field offset: 0x1A8
	private Nullable _defaultArrowColor; //Field offset: 0x1BC
	private Nullable _defaultHoverBlockBackgroundColor; //Field offset: 0x1D0
	private readonly CompositeDisposable _environmentDisposable; //Field offset: 0x1E8
	private readonly BindableEvent _onClick; //Field offset: 0x1F0

	public IBindableEvent OnClick
	{
		 get { } //Length: 8
	}

	public SeasonWidget() { }

	private void ApplyBackgroundTheme(EEnvironmentUIType environmentUiType) { }

	private void ApplyBlocksVisibility() { }

	private void ApplyEnvironmentOverride(EEnvironmentUIType environmentUiType) { }

	private void Awake() { }

	public virtual void Close() { }

	private string FormatTimeLeft(TimeSpan timeLeft) { }

	public IBindableEvent get_OnClick() { }

	private TimeSpan GetTimeLeft() { }

	private string GetTimeLeftText() { }

	private bool IsDarkBackgroundEnvironment(EEnvironmentUIType environmentUiType) { }

	private bool IsTimeCritical() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	private void RefreshContent(bool forced) { }

	private void SetHoverState(bool hoverState) { }

	private void SetLogoVideoPlaying(bool playing) { }

	private void SetSpriteAnimationPlayersHover(bool hoverState) { }

	public void Show(SeasonWidgetData data) { }

	private void StopHoverLoop(bool allowFadeout) { }

	private void Update() { }

	private void UpdateAvailableRewards() { }

	private void UpdateBattlePassRewards() { }

	public void UpdateData(SeasonWidgetData data) { }

	private void UpdateTimer(bool forced = false) { }

}

