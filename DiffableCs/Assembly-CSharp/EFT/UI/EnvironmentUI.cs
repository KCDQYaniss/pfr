namespace EFT.UI;

public sealed class EnvironmentUI : MonoBehaviourSingleton
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__46_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal EEnvironmentUIType <GetRandomEnvironment>b__46_0(CustomizationEnvironmentUI environment) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Image imageToFadeOut; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal void <SwitchGlows>b__0() { }

	}

	[CompilerGenerated]
	private struct <RefreshEnvironmentAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EnvironmentUI <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ScheduleEnvironmentLoading>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string sceneName; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public EnvironmentUI <>4__this; //Field offset: 0x30
		private Scene <scene>5__2; //Field offset: 0x38
		private EnvironmentUIRoot <environmentRoot>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetEnvironmentAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EEnvironmentUIType environmentUiType; //Field offset: 0x20
		public EnvironmentUI <>4__this; //Field offset: 0x28
		private EnvironmentData <environment>5__2; //Field offset: 0x30
		private CancellationTokenSource <loadCancellation>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class EnvironmentData
	{
		public EEnvironmentUIType Type; //Field offset: 0x10
		public string SceneName; //Field offset: 0x18

		public EnvironmentData() { }

	}

	private const float DEFAULT_ALPHA = 0.6; //Field offset: 0x0
	private static readonly List _gameObjectBuffer; //Field offset: 0x0
	private static readonly EEnvironmentUIType DEFAULT_ENVIRONMENT; //Field offset: 0x8
	[SerializeField]
	private Camera _alignmentCamera; //Field offset: 0x20
	[SerializeField]
	private GameObject _commonContainer; //Field offset: 0x28
	[SerializeField]
	private Image _topGlowRegularImage; //Field offset: 0x30
	[SerializeField]
	private Image _topGlowPveImage; //Field offset: 0x38
	[SerializeField]
	private Image _topGlowPvpSeasonImage; //Field offset: 0x40
	[SerializeField]
	private EnvironmentData[] _environments; //Field offset: 0x48
	[SerializeField]
	private EnvironmentShading _environmentShading; //Field offset: 0x50
	private EnvironmentUIRoot _currentEnvironment; //Field offset: 0x58
	private EEnvironmentUIType _currentEnvironmentUiType; //Field offset: 0x60
	private Nullable _loadingEnvironmentUiType; //Field offset: 0x64
	private bool _lastVisibleStateEnvironment; //Field offset: 0x6C
	private bool _lastVisibleStateCamera; //Field offset: 0x6D
	private readonly CompositeDisposable _compositeDisposable; //Field offset: 0x70
	private bool _isMainScreen; //Field offset: 0x78
	private EEventType[] _events; //Field offset: 0x80
	private CancellationTokenSource _environmentLoadCancellation; //Field offset: 0x88
	private Sequence _currentSequence; //Field offset: 0x90
	private EGameMode _gameMode; //Field offset: 0x98
	private bool _isGameModeVisualInitialized; //Field offset: 0x9C

	public EEventType[] Events
	{
		 get { } //Length: 8
		 set { } //Length: 156
	}

	public bool IsActive
	{
		 get { } //Length: 233
	}

	private static EnvironmentUI() { }

	public EnvironmentUI() { }

	[CompilerGenerated]
	private void <Awake>b__28_0(EEnvironmentUIType uiType) { }

	[CompilerGenerated]
	private void <ShowEnvironment>b__40_0() { }

	[CompilerGenerated]
	private void <ShowEnvironment>b__40_1() { }

	public virtual void Awake() { }

	public void ChangeShading(EShadingType shadingType) { }

	public void EnableOverlay(bool enable) { }

	public EEventType[] get_Events() { }

	public bool get_IsActive() { }

	private Image GetGameModeGlow(EGameMode gameMode) { }

	private EEnvironmentUIType GetRandomEnvironment() { }

	public virtual void OnDestroy() { }

	[AsyncStateMachine(typeof(<RefreshEnvironmentAsync>d__35))]
	public Task RefreshEnvironmentAsync() { }

	public void ResetRotation() { }

	public void ResetShading() { }

	public void Rotate() { }

	[AsyncStateMachine(typeof(<ScheduleEnvironmentLoading>d__37))]
	private Task ScheduleEnvironmentLoading(string sceneName, CancellationToken cancellationToken) { }

	public void set_Events(EEventType[] value) { }

	public void SetAsMain(bool isMain, bool rotateForced) { }

	[AsyncStateMachine(typeof(<SetEnvironmentAsync>d__36))]
	public Task SetEnvironmentAsync(EEnvironmentUIType environmentUiType) { }

	public void SetGameModeVisual(EGameMode gameMode, bool forced) { }

	private void SetGlowStateImmediately(Image activeGlow) { }

	private static void SetGlowVisible(Image glow, bool visible, float alpha) { }

	public void ShowCameraContainer(bool value) { }

	public void ShowEnvironment(bool value) { }

	private void SwitchGlows(Image imageToFadeOut, Image imageToFadeIn, bool forced) { }

}

