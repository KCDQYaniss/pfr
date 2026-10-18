namespace EFT;

public class StartMissionController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__14_0; //Field offset: 0x8
		public static Func <>9__25_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <OnStartRaising>b__14_0(Result _) { }

		internal bool <ShowMainQuestNotification>b__25_0(Quest x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		private struct <<BattleUiOpenedHandler>g__DelayedTriggerTutorialHint|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass19_0 <>4__this; //Field offset: 0x20
			private YieldAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public StartMissionController <>4__this; //Field offset: 0x10
		public TutorialHintData lastHint; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		[AsyncStateMachine(typeof(<<BattleUiOpenedHandler>g__DelayedTriggerTutorialHint|0>d))]
		internal Task <BattleUiOpenedHandler>g__DelayedTriggerTutorialHint|0() { }

	}

	[CompilerGenerated]
	private struct <PreloadSounds>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StartMissionController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowMainQuestNotification>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StartMissionController <>4__this; //Field offset: 0x20
		private Quest <quest>5__2; //Field offset: 0x28
		private string <message>5__3; //Field offset: 0x30
		private MainQuest <mainQuest>5__4; //Field offset: 0x38
		private QuestChapter <chapter>5__5; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string EXAMINATION_BOT_TRIGGER = "bot_in_examination_zone_enter"; //Field offset: 0x0
	private const string FINAL_BOT_TRIGGER = "bot_in_final_zone_enter"; //Field offset: 0x0
	private Action _dispose; //Field offset: 0x10
	private Player _player; //Field offset: 0x18
	private StartZoneTriggersConfig _hintsConfig; //Field offset: 0x20
	private readonly Dictionary _triggerActivationsLeft; //Field offset: 0x28
	private TutorialHintData _lastActivatedHint; //Field offset: 0x30
	private TutorialHintData _activeTriggerZoneHint; //Field offset: 0x38
	private DateTime _lastHintActivationTime; //Field offset: 0x40
	private readonly List _hintControllers; //Field offset: 0x48
	private readonly StartMissionAudioController _audioController; //Field offset: 0x50

	public StartMissionController() { }

	[CompilerGenerated]
	private void <Init>b__11_0() { }

	private void BattleUiOpenedHandler(EEftScreenType screen) { }

	private bool CanActivateHint(TutorialHintData hint) { }

	private bool CanReactivateLastHint(out TutorialHintData lastHint) { }

	private void CloseHint(TutorialHintData hint) { }

	public void Dispose() { }

	public void Init(Player player) { }

	private void OnFinishRaising(IAnimatorEventParameter param) { }

	private void OnPlaySound(IAnimatorEventParameter param) { }

	private void OnStartRaising(IAnimatorEventParameter param) { }

	[AsyncStateMachine(typeof(<PreloadSounds>d__12))]
	public Task PreloadSounds() { }

	[AsyncStateMachine(typeof(<ShowMainQuestNotification>d__25))]
	private Task ShowMainQuestNotification() { }

	private void StartTutorialAnimationHandler(EEftScreenType screenType) { }

	private void Subscribe() { }

	private void TriggerZoneEventHandler(TriggerEvent triggerEvent) { }

	private void TryActivateHint(TutorialHintData hint) { }

	private void Unsubscribe() { }

}

