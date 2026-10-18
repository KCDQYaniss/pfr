namespace Cutscene;

public class InGameCutsceneController
{
	[CompilerGenerated]
	private struct <StartMyPlayerCutsceneTask>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Player player; //Field offset: 0x20
		public InGameCutsceneController <>4__this; //Field offset: 0x28
		public BaseCutsceneTrigger causedTrigger; //Field offset: 0x30
		public CancellationToken cToken; //Field offset: 0x38
		private bool <waitForSetPose>5__2; //Field offset: 0x40
		private ApproachState <approachState>5__3; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private YieldAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static InGameCutsceneController _instance; //Field offset: 0x0
	public Dictionary cutscenesTriggers; //Field offset: 0x10
	private CancellationTokenSource _cancelCutsceneToken; //Field offset: 0x18
	private PlayerCameraController _playerCameraController; //Field offset: 0x20
	private Player _currentPlayerActor; //Field offset: 0x28
	private PlayableDirector _myPlayerDirector; //Field offset: 0x30
	private BaseCutsceneTrigger _currentCutsceneTrigger; //Field offset: 0x38
	private Scene _cameraOriginalScene; //Field offset: 0x40

	public static InGameCutsceneController Instance
	{
		 get { } //Length: 86
	}

	public InGameCutsceneController() { }

	public void AddActiveCutsceneTrigger(BaseCutsceneTrigger trigger) { }

	public static StartPlayerValues CalculateMyPlayerInfoOnStartCutscene(Player player) { }

	private void Dispose() { }

	public static InGameCutsceneController get_Instance() { }

	private static void Initialize() { }

	public bool IsPlaying() { }

	private void OnPlayerCameraControllerCreated(PlayerCameraController playerCameraController, Camera camera) { }

	private void StartCutscene(BaseCutsceneTrigger causedTrigger, Player player) { }

	[AsyncStateMachine(typeof(<StartMyPlayerCutsceneTask>d__17))]
	private Task StartMyPlayerCutsceneTask(BaseCutsceneTrigger causedTrigger, Player player, CancellationToken cToken) { }

	private void StopMyPlayerCutscene(PlayableDirector director) { }

}

