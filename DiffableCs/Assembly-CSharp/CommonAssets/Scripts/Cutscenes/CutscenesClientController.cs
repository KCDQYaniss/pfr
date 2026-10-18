namespace CommonAssets.Scripts.Cutscenes;

public class CutscenesClientController : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public CutscenesClientController <>4__this; //Field offset: 0x10
		public PreloaderUI preloader; //Field offset: 0x18

		public <>c__DisplayClass44_0() { }

		internal void <OnSkipEvent>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public int localPlayerId; //Field offset: 0x10

		public <>c__DisplayClass46_0() { }

		internal bool <OnSkipIntentionEvent>b__0(int playerId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public KeyValuePair playableDirectorByScene; //Field offset: 0x10

		public <>c__DisplayClass48_0() { }

		internal double <StartShowTimeline>b__1() { }

	}

	[CompilerGenerated]
	private struct <Init>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CutscenesClientController <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartShowTimeline>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CutscenesClientController <>4__this; //Field offset: 0x20
		public string timelineId; //Field offset: 0x28
		public float initTime; //Field offset: 0x30
		private Player <player>5__2; //Field offset: 0x38
		private int <i>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x44

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <TrimForOffset>d__49 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private SubtitleParams <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerable data; //Field offset: 0x28
		public IEnumerable <>3__data; //Field offset: 0x30
		private float offset; //Field offset: 0x38
		public float <>3__offset; //Field offset: 0x3C
		private IEnumerator <>7__wrap1; //Field offset: 0x40

		private override SubtitleParams System.Collections.Generic.IEnumerator<EFT.AnimationSequencePlayer.SubtitleParams>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <TrimForOffset>d__49(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.AnimationSequencePlayer.SubtitleParams>.GetEnumerator() { }

		[DebuggerHidden]
		private override SubtitleParams System.Collections.Generic.IEnumerator<EFT.AnimationSequencePlayer.SubtitleParams>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const float CUTSCENE_SKIP_BLACK_FADE_OUT_PAUSE = 0.05; //Field offset: 0x0
	private const string SEATS_SHIP_MESSAGE_KEY = "FinalSeatsOnTheShip"; //Field offset: 0x0
	private const float CUTSCENE_SKIP_BLACK_FADE_SPEED = 2; //Field offset: 0x0
	private Dictionary _directorsByScene; //Field offset: 0x10
	private Dictionary _cutscenePlayableDirectorByScene; //Field offset: 0x18
	private MapTimelinesBank _timelinesMapBank; //Field offset: 0x20
	private MapTimelineData _currentTimelineData; //Field offset: 0x28
	private CutsceneAudioConfigurator _cutsceneAudioConfigurator; //Field offset: 0x80
	private Action _unsubscribeOnDestroy; //Field offset: 0x88
	private bool _offlineMode; //Field offset: 0x90
	private bool _needStartTimeline; //Field offset: 0x91
	private float _timelineTimeStart; //Field offset: 0x94
	private string _cutsceneId; //Field offset: 0x98
	private int _cutsceneProcessId; //Field offset: 0xA0
	private bool _clientOnlyCutscenePlay; //Field offset: 0xA4
	private bool _currentCutsceneClientOnly; //Field offset: 0xA5
	private bool _currentCutsceneViewerOnly; //Field offset: 0xA6
	private bool _skipUiActive; //Field offset: 0xA7
	private bool _skipIntentionSent; //Field offset: 0xA8
	private int _currentCutscenePlayersCount; //Field offset: 0xAC
	private int _waitFramesLeft; //Field offset: 0xB0
	private CutsceneSkipUI _cutsceneSkipUI; //Field offset: 0xB8
	private readonly Dictionary _gameUIChildrenActiveStates; //Field offset: 0xC0
	private Dictionary _actions; //Field offset: 0xC8
	private List _playersIDs; //Field offset: 0xD0
	private CancellationTokenSource _initializeCancellationTokenSource; //Field offset: 0xD8
	private CutsceneScreenController _cutsceneScreenController; //Field offset: 0xE0
	private float _syncTimeTriggerTime; //Field offset: 0xE8
	private List _myPlayerchangedTacticalLights; //Field offset: 0xF0

	public bool IsClientOnlyCutscenesPlay
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public CutscenesClientController() { }

	[CompilerGenerated]
	private bool <StartShowTimeline>g__IsAnyPlaying|48_0() { }

	private bool CanShowCutsceneSkipUI() { }

	private void DeinitAllActions() { }

	private void DisableNoCutsceneObjectsViews() { }

	private void DisableRenderOnObject(GameObject gameObject) { }

	public override void Dispose() { }

	private void EnableNoCutsceneObjectsViews() { }

	private void EnableRenderOnObject(GameObject gameObject) { }

	private void FindMapTimelinesBank() { }

	public bool get_IsClientOnlyCutscenesPlay() { }

	private ObservedPlayerView GetSpectatingTarget() { }

	private void HideCutsceneSkipUI(bool notifyServer) { }

	[AsyncStateMachine(typeof(<Init>d__37))]
	private Task Init(CancellationToken cancellationToken) { }

	private void InitAction(string actionId, List playersId = null) { }

	private void OnFinalExitZoneInitEvent(FinalExitZoneInitEvent finalExitZoneEvent) { }

	private void OnLocalSkipHoldCompleted() { }

	private void OnLocalSkipRequested() { }

	private void OnPlayableDirectorStopped(PlayableDirector director) { }

	private void OnPlayerHandsControllerChanged(AbstractHandsController oldHC, AbstractHandsController newHC) { }

	private void OnSkipEvent(CutsceneSkipEventFromServer skipEvent) { }

	private void OnSkipIntentionEvent(CutsceneSkipIntentionEventFromServer skipIntentionEvent) { }

	private void OnSyncCutsceneEvent(CorrectCutsceneTimerEvent syncEvent) { }

	private void OnUpdate(float deltaTime) { }

	private void ReconnectCutsceneEventHandler(CutSceneReconnectEvent reconnectCutsceneEvent) { }

	public void RegisterCutSceneAction(CutsceneBaseAction action, bool isSignalAction = false) { }

	public void RegisterCutscenePlayableDirector(string sceneId, CutscenePlayableDirector director) { }

	public void RegisterPlayableDirector(string sceneId, PlayableDirector director) { }

	private void SendSkipIntention(bool wantsToSkip) { }

	public void set_IsClientOnlyCutscenesPlay(bool value) { }

	public void SetSubtitlesToCurrentTimelineData(string subtitleId) { }

	private void SetupSignalTracks(TimelineAsset timelineAsset, PlayableDirector director) { }

	private bool ShouldShowForSpectatingTarget(int[] playerIds) { }

	private bool ShouldShowForSpectatingTarget(int playerId) { }

	private void ShowCutsceneSkipUI() { }

	private void StartCutsceneGroupEventHandler(CutSceneStartEvent startCutsceneEvent) { }

	[AsyncStateMachine(typeof(<StartShowTimeline>d__48))]
	private Task StartShowTimeline(string timelineId, float initTime) { }

	private void StopCutscene(PlayableDirector director, bool skip = false) { }

	private void Subscribe() { }

	private void TimelineShowed(string timelineId, bool skip = false) { }

	private void TimelineSignalHandler(string eventId) { }

	private void ToggleMyLights(bool toggle) { }

	[IteratorStateMachine(typeof(<TrimForOffset>d__49))]
	private IEnumerable TrimForOffset(IEnumerable data, float offset) { }

	private void TrySetGameUICanvasState(bool state) { }

	private void Unsubscribe() { }

}

