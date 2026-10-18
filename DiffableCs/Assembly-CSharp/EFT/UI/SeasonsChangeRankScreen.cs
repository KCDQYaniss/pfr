namespace EFT.UI;

public class SeasonsChangeRankScreen : EftScreen
{
	[CompilerGenerated]
	private struct <Claim>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsChangeRankScreen <>4__this; //Field offset: 0x20
		private SeasonsChangeRankScreenController <controller>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Confirm>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsChangeRankScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConfirmRankEnd>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsChangeRankScreenController controller; //Field offset: 0x20
		public SeasonsChangeRankScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadVideo>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsChangeRankScreen <>4__this; //Field offset: 0x20
		public SeasonsChangeRankScreenController controller; //Field offset: 0x28
		private CancellationTokenSource <loadingCancellation>5__2; //Field offset: 0x30
		private CancellationToken <token>5__3; //Field offset: 0x38
		private float <timeoutAt>5__4; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x44

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowWithVideo>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsChangeRankScreen <>4__this; //Field offset: 0x20
		public SeasonsChangeRankScreenController controller; //Field offset: 0x28
		private IResult <result>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class SeasonsChangeRankScreenController : EftScreenController
	{
		[CompilerGenerated]
		private int <OldRank>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private int <NewRank>k__BackingField; //Field offset: 0x5C
		[CompilerGenerated]
		private bool <HasRewards>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private readonly IEftSession <Session>k__BackingField; //Field offset: 0x68

		public bool HasRewards
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public int NewRank
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public int OldRank
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public IEftSession Session
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public SeasonsChangeRankScreenController(int oldRank, int newRank, bool hasRewards, IEftSession session, bool debug = false) { }

		[CompilerGenerated]
		public bool get_HasRewards() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public int get_NewRank() { }

		[CompilerGenerated]
		public int get_OldRank() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public IEftSession get_Session() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		[CompilerGenerated]
		public void set_HasRewards(bool value) { }

		[CompilerGenerated]
		public void set_NewRank(int value) { }

		[CompilerGenerated]
		public void set_OldRank(int value) { }

	}

	internal class TweenConfig
	{
		public float InitialDelay; //Field offset: 0x10
		public float GlobalFadeTime; //Field offset: 0x14
		public float TitleFadeTime; //Field offset: 0x18
		public float OldRankFadeTime; //Field offset: 0x1C
		public float OldRankMoveTime; //Field offset: 0x20
		public float NewRankMoveTime; //Field offset: 0x24
		public float RewardsStartTime; //Field offset: 0x28
		public float IconMoveTime; //Field offset: 0x2C
		public float RewardsMoveTime; //Field offset: 0x30
		public RectTransform IconTarget; //Field offset: 0x38
		public float ClaimButtonY; //Field offset: 0x40
		public float RewardsPosX; //Field offset: 0x44

		public TweenConfig() { }

	}

	private const string RANK_UP_KEY = "Seasons/Ranks/RankUp"; //Field offset: 0x0
	private const string RANK_STAY_KEY = "Seasons/Ranks/RankStay"; //Field offset: 0x0
	private const string RANK_DOWN_KEY = "Seasons/Ranks/RankDown"; //Field offset: 0x0
	private const string VIDEO_ASSET_PATH = "Ranks/Rank_{0}-{1}.webm"; //Field offset: 0x0
	private const string LOADING_TIMEOUT_ERROR = "Screen closed or loading timeout"; //Field offset: 0x0
	private const float VIDEO_LOAD_TIMEOUT_SECONDS = 10; //Field offset: 0x0
	[SerializeField]
	private VideoPlayer _videoPlayer; //Field offset: 0xA0
	[SerializeField]
	private Image _rankIcon; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _claimButton; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _confirmButton; //Field offset: 0xB8
	[SerializeField]
	private SeasonRankRewardPageView _rewards; //Field offset: 0xC0
	[SerializeField]
	private RectTransform _rewardsRoot; //Field offset: 0xC8
	[SerializeField]
	private TMP_Text _titleLabel; //Field offset: 0xD0
	[SerializeField]
	private TMP_Text _oldRankLabel; //Field offset: 0xD8
	[SerializeField]
	private TMP_Text _newRankLabel; //Field offset: 0xE0
	[SerializeField]
	private TMP_Text _stayRankLabel; //Field offset: 0xE8
	[SerializeField]
	private Color _rankUpColor; //Field offset: 0xF0
	[SerializeField]
	private Color _rankDownColor; //Field offset: 0x100
	[SerializeField]
	private Color _rankStayColor; //Field offset: 0x110
	[SerializeField]
	private TweenConfig _tweenConfig; //Field offset: 0x120
	[SerializeField]
	private CanvasGroup _contentCanvas; //Field offset: 0x128
	private CancellationTokenSource _loadingAssetsCancellation; //Field offset: 0x130
	private RectTransform _iconRt; //Field offset: 0x138
	private bool _showRewards; //Field offset: 0x140
	private bool _busy; //Field offset: 0x141
	private Sequence _showSequence; //Field offset: 0x148

	public SeasonsChangeRankScreen() { }

	[CompilerGenerated]
	private void <Awake>b__29_0() { }

	[CompilerGenerated]
	private void <Awake>b__29_1() { }

	[CompilerGenerated]
	private void <BuildRewardsTween>b__42_0() { }

	private void Awake() { }

	private Tween BuildRewardsTween() { }

	private Tween BuildShowTween(bool useVideo) { }

	[AsyncStateMachine(typeof(<Claim>d__30))]
	private Task Claim() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<Confirm>d__31))]
	private Task Confirm() { }

	[AsyncStateMachine(typeof(<ConfirmRankEnd>d__32))]
	private Task ConfirmRankEnd(SeasonsChangeRankScreenController controller) { }

	private Color GetRankChangeColor(int oldRank, int newRank) { }

	private EUISoundType GetRankChangeSoundType(int oldRank, int newRank) { }

	private string GetRankChangeTitle(int oldRank, int newRank) { }

	private void KillTweens() { }

	[AsyncStateMachine(typeof(<LoadVideo>d__37))]
	private Task LoadVideo(SeasonsChangeRankScreenController controller) { }

	private void OnVideoError(VideoPlayer source, string message) { }

	private void PrepareTween() { }

	public virtual void Show(SeasonsChangeRankScreenController controller) { }

	private void ShowWithIcon() { }

	[AsyncStateMachine(typeof(<ShowWithVideo>d__34))]
	private Task ShowWithVideo(SeasonsChangeRankScreenController controller) { }

	private void StartTween(bool useVideo) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryApplyRewards() { }

	private void UnsubscribeFromVideoEvents() { }

}

