namespace EFT.UI;

public sealed class SpectatorScreen : EftScreen
{
	[CompilerGenerated]
	private struct <<AwaitIconsLoading>g__WaitSafely|42_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task task; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__40_0; //Field offset: 0x8
		public static Func <>9__40_1; //Field offset: 0x10
		public static Func <>9__40_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal SpectatorViewController <Show>b__40_0(SpectatingTeammateInfo x) { }

		internal int <Show>b__40_1(SpectatorViewController k) { }

		internal SpectatorViewController <Show>b__40_2(SpectatorViewController v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public ISpectatorController spectatorController; //Field offset: 0x10
		public SpectatorScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal void <Show>b__3() { }

		internal void <Show>b__4() { }

		internal void <Show>b__5() { }

		internal void <Show>b__6() { }

		internal void <Show>b__7() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		private struct <<SpectatorChangedHandler>g__WaitForMinTime|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass43_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public SpectatorScreen <>4__this; //Field offset: 0x10
		public double timeLeftTillRequest; //Field offset: 0x18
		public int raidId; //Field offset: 0x20

		public <>c__DisplayClass43_0() { }

		internal void <SpectatorChangedHandler>g__FinishSwap|2() { }

		internal void <SpectatorChangedHandler>g__Swap|1() { }

		[AsyncStateMachine(typeof(<<SpectatorChangedHandler>g__WaitForMinTime|0>d))]
		internal Task <SpectatorChangedHandler>g__WaitForMinTime|0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__WaitSafely; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <AwaitIconsLoading>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpectatorScreen <>4__this; //Field offset: 0x20
		public IEnumerable tasks; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestSwap>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpectatorScreen <>4__this; //Field offset: 0x20
		public bool next; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowAsync>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpectatorScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StopInfiniteNoSignal>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpectatorScreen <>4__this; //Field offset: 0x20
		private CancellationToken <token>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class BodyPartViewContainer
	{
		public Image Icon; //Field offset: 0x10
		public EBodyPart BodyPart; //Field offset: 0x18

		public BodyPartViewContainer() { }

	}

	internal sealed class SpectatorScreenController : EftScreenController
	{
		[CompilerGenerated]
		private readonly IList <PlayersInfo>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private int <CurrentPlayerRaidId>k__BackingField; //Field offset: 0x60
		public readonly Dictionary IconsCache; //Field offset: 0x68
		private readonly RaidMainMenuScreenController _mainMenuScreenController; //Field offset: 0x70
		public readonly ISpectatorController SpectatorController; //Field offset: 0x78
		public readonly ISpectatorAudio Audio; //Field offset: 0x80

		public int CurrentPlayerRaidId
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public bool DelayOnShow
		{
			 get { } //Length: 157
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public IList PlayersInfo
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		public SpectatorScreenController(ISpectatorController spectatorController, ISpectatorAudio audio, IList playersInfo, int firstPlayerRaidId) { }

		[CompilerGenerated]
		public int get_CurrentPlayerRaidId() { }

		public bool get_DelayOnShow() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public IList get_PlayersInfo() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected virtual EStateSwitcher get_UnrestrictedFrameRate() { }

		private void LeaveHandler() { }

		[CompilerGenerated]
		public void set_CurrentPlayerRaidId(int value) { }

		public void ShowLeaveScreen() { }

		public void StopAudio() { }

		public void SwapPlayer(bool next) { }

	}

	private sealed class SpectatorViewController : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass23_0
		{
			public Sprite defaultIcon; //Field offset: 0x10
			public TaskCompletionSource completionSource; //Field offset: 0x18
			public ItemIcon icon; //Field offset: 0x20
			public SpectatorViewController <>4__this; //Field offset: 0x28
			public Dictionary iconsCache; //Field offset: 0x30

			public <>c__DisplayClass23_0() { }

			internal void <LoadIcon>b__2() { }

			internal void <LoadIcon>g__Complete|0() { }

			internal void <LoadIcon>g__SetSprite|1(Sprite iconSprite) { }

		}

		public readonly int RaidID; //Field offset: 0x10
		public readonly string Nickname; //Field offset: 0x18
		public readonly EMemberCategory SelectedMemberCategory; //Field offset: 0x20
		public readonly int PrestigeLevel; //Field offset: 0x24
		public Dictionary NormalizedHealthDict; //Field offset: 0x28
		public Dictionary HealthEffects; //Field offset: 0x30
		[CompilerGenerated]
		private bool <IsAlive>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private Sprite <Icon>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private SpectatorPlayerView <View>k__BackingField; //Field offset: 0x48
		private ISpectatorController _spectatorController; //Field offset: 0x50
		private readonly CompositeDisposable _dispose; //Field offset: 0x58

		public private Sprite Icon
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private bool IsAlive
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private SpectatorPlayerView View
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public SpectatorViewController(SpectatingTeammateInfo info) { }

		public override void Dispose() { }

		[CompilerGenerated]
		public Sprite get_Icon() { }

		[CompilerGenerated]
		public bool get_IsAlive() { }

		[CompilerGenerated]
		public SpectatorPlayerView get_View() { }

		public Task Load(SpectatorPlayerView view, Dictionary iconsCache, ISpectatorController spectatorController, CancellationToken cancellationToken) { }

		private Task LoadIcon(Dictionary iconsCache, ISpectatorController spectatorController, CancellationToken cancellationToken) { }

		[CompilerGenerated]
		private void set_Icon(Sprite value) { }

		[CompilerGenerated]
		private void set_IsAlive(bool value) { }

		[CompilerGenerated]
		private void set_View(SpectatorPlayerView value) { }

		public void SetDead(bool dead) { }

		public void ValidateHealthEffects() { }

	}

	private const float BODY_PART_SATURATION = 0.5; //Field offset: 0x0
	[SerializeField]
	private SpectatorPlayerView _viewTemplate; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _selectorRoot; //Field offset: 0xA8
	[SerializeField]
	private SpectatorPlayerView _currentPlayerView; //Field offset: 0xB0
	[SerializeField]
	private TMP_Text _nickname; //Field offset: 0xB8
	[SerializeField]
	private SpectatorNoSignalEffectController _noSignal; //Field offset: 0xC0
	[SerializeField]
	private Image _prestigeLevelImage; //Field offset: 0xC8
	[SerializeField]
	private float _noSignalLineDelay; //Field offset: 0xD0
	[SerializeField]
	private GameObject[] _swapEnableObjects; //Field offset: 0xD8
	[SerializeField]
	private GameObject[] _swapDisableObjects; //Field offset: 0xE0
	[SerializeField]
	private Button _nextButton; //Field offset: 0xE8
	[SerializeField]
	private Button _prevButton; //Field offset: 0xF0
	[SerializeField]
	private BodyPartViewContainer[] _bodyParts; //Field offset: 0xF8
	[SerializeField]
	private SpectatorScreenSoundHandler _soundHandler; //Field offset: 0x100
	[SerializeField]
	private RectTransform _healthEffectPanel; //Field offset: 0x108
	[SerializeField]
	private SimpleEffectIcon _healthEffectIconTemplate; //Field offset: 0x110
	[SerializeField]
	private Image _recIcon; //Field offset: 0x118
	[SerializeField]
	private float _recLoopTime; //Field offset: 0x120
	[SerializeField]
	private float _recAlpha; //Field offset: 0x124
	[SerializeField]
	private GameObject _noSignalIcon; //Field offset: 0x128
	[SerializeField]
	private GameObject _currentPlayerRoot; //Field offset: 0x130
	private SpectatorScreenController _screenController; //Field offset: 0x138
	private Dictionary _viewsControllers; //Field offset: 0x140
	private int _activeRaidId; //Field offset: 0x148
	private bool _isSwapping; //Field offset: 0x14C
	private bool _canSwapping; //Field offset: 0x14D
	private DateTime _noSignalStartTime; //Field offset: 0x150
	private EHealthColorScheme _colorScheme; //Field offset: 0x158
	private Dictionary _healthEffectIcons; //Field offset: 0x160
	private List _effectsToHide; //Field offset: 0x168
	private Tween _recTween; //Field offset: 0x170
	private CancellationTokenSource _stopInfiniteNoSignalCancellation; //Field offset: 0x178
	private CancellationTokenSource _initCancellation; //Field offset: 0x180
	private bool _soundStarted; //Field offset: 0x188
	private SpectatingGlobalSettings _globalSettings; //Field offset: 0x190
	private bool _infiniteNoSignalActive; //Field offset: 0x198

	public SpectatorScreen() { }

	[AsyncStateMachine(typeof(<<AwaitIconsLoading>g__WaitSafely|42_0>d))]
	[CompilerGenerated]
	internal static Task <AwaitIconsLoading>g__WaitSafely|42_0(Task task) { }

	[CompilerGenerated]
	private void <SetNoSignalVisual>b__69_0() { }

	[AsyncStateMachine(typeof(<AwaitIconsLoading>d__42))]
	private Task AwaitIconsLoading(IEnumerable tasks) { }

	private void Awake() { }

	private void ClearEffects() { }

	public virtual void Close() { }

	private static Type GetEffectType(EHealthEffectType effectType) { }

	private void HealthEffectDisplayChangedHandler(int raidId, bool clear, EHealthEffectType effect, int count) { }

	private void HideAllEffects() { }

	private void HideEffect(EHealthEffectType effect) { }

	private void InfiniteNoSignalActiveChangedHandler(bool enable) { }

	private void PlayRecTween() { }

	private void PlaySwapSound() { }

	private void RedrawEffects(SpectatorViewController viewController) { }

	[AsyncStateMachine(typeof(<RequestSwap>d__56))]
	private Task RequestSwap(bool next) { }

	private void SelectNext() { }

	private void SelectPlayer(int raidId) { }

	private void SelectPrev() { }

	private void SetEffectCount(EHealthEffectType effect, int count) { }

	private void SetNoSignal(bool active, bool infinite = false) { }

	private void SetNoSignalVisual(bool active, bool infinite = false) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public virtual void Show(SpectatorScreenController controller) { }

	[AsyncStateMachine(typeof(<ShowAsync>d__41))]
	private Task ShowAsync() { }

	private void SpectatorChangedHandler(int raidId, Dictionary healthDict, Dictionary healthEffects) { }

	public void StopAudio() { }

	[AsyncStateMachine(typeof(<StopInfiniteNoSignal>d__70))]
	private Task StopInfiniteNoSignal() { }

	private void StopRecTween() { }

	private void TeammateDeathHandler(int raidId) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryDebugSwap(bool next) { }

	private bool TryGetBodyPartImage(EBodyPart bodyPart, out Image icon) { }

	private static bool TryGetEffectType(EHealthEffectType effectType, out Type type) { }

	private void UpdateHealth(EBodyPart bodyPart, float normalizedValue) { }

	private void UpdateHealth(int raidId, EBodyPart bodyPart, float normalizedValue) { }

	private void ValidateCanSwapFlag() { }

	private void ValidateSwapObjects() { }

}

