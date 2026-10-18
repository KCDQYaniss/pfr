namespace EFT;

public class LighthouseKeeperZone : MonoBehaviour
{
	[CompilerGenerated]
	private struct <SetCutscenePlayerRotationAfterDelay>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LighthouseKeeperZone <>4__this; //Field offset: 0x20
		public Player myPlayer; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryExit>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LighthouseKeeperZone <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private NPCObject _npc; //Field offset: 0x20
	[SerializeField]
	private BaseCutsceneTrigger _enterZoneTrigger; //Field offset: 0x28
	[SerializeField]
	private BaseCutsceneTrigger _exitZoneTrigger; //Field offset: 0x30
	[SerializeField]
	private BufferGates _bufferGates; //Field offset: 0x38
	[SerializeField]
	private Door _keeperEntranceDoor; //Field offset: 0x40
	[SerializeField]
	private SmoothLookAt _lookAt; //Field offset: 0x48
	[SerializeField]
	private Transform _transformForFollowPlayerCam; //Field offset: 0x50
	[SerializeField]
	private float _fovInDialog; //Field offset: 0x58
	[SerializeField]
	private PlayerCameraFovChanger _playerCameraCamFovChanger; //Field offset: 0x60
	[SerializeField]
	private List _rendersOnlyForCutscene; //Field offset: 0x68
	private Action _unsubscribeFromGlobalEvents; //Field offset: 0x70
	private bool _isMyPlayerInsideZone; //Field offset: 0x78
	private bool _isZoneBlocked; //Field offset: 0x79
	private TraderDialogScreenController _dialogUI; //Field offset: 0x80
	private LightkeeperDialogReaction _keeperDialogReaction; //Field offset: 0x88
	private EInteractState _state; //Field offset: 0x90

	public LighthouseKeeperZone() { }

	[CompilerGenerated]
	private void <Awake>b__18_0(BufferInnerZoneStatusEvent invokedEvent) { }

	[CompilerGenerated]
	private void <Awake>b__18_1(MyPlayerInBufferZoneStatusEvent invokedEvent) { }

	private void Awake() { }

	private void DialogControllerOnOnActionFinished(DialogAction action) { }

	private TraderDialogScreenController GetDialogUI() { }

	private void OnBufferGatesStateChanged(WorldInteractiveObject obj, EDoorState prevState, EDoorState nextState) { }

	private void OnBufferZoneStatusChangedForMyPlayer(BufferInnerZoneStatusEvent zoneEvent) { }

	private void OnDestroy() { }

	private void OnEnteredZone(Player myPlayer) { }

	private void OnEnteringZone(BaseCutsceneTrigger trigger, Player myPlayer) { }

	private void OnExitedZone(Player myPlayer) { }

	private void OnExitingZone(BaseCutsceneTrigger trigger, Player myPlayer) { }

	private void OnKeeperDoorStateChanged(WorldInteractiveObject obj, EDoorState prevState, EDoorState nextState) { }

	private void OnMyPlayerInBufferZoneStatusChange(MyPlayerInBufferZoneStatusEvent invokedEvent) { }

	[AsyncStateMachine(typeof(<SetCutscenePlayerRotationAfterDelay>d__28))]
	private Task SetCutscenePlayerRotationAfterDelay(Player myPlayer) { }

	private void Start() { }

	[AsyncStateMachine(typeof(<TryExit>d__17))]
	private Task TryExit() { }

}

