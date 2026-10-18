namespace EFT.Hideout.ShootingRange;

public class RailTargetControl : InteractiveShootingRange
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public HideoutPlayerOwner owner; //Field offset: 0x10
		public RailTargetControl <>4__this; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <InteractionStates>b__0() { }

	}

	[CompilerGenerated]
	private struct <Inspect>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargetControl <>4__this; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Shooting>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargetControl <>4__this; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Stop>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargetControl <>4__this; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int MAX_SHOOTING_SPEED = 2; //Field offset: 0x0
	[SerializeField]
	[Space]
	private RailTargets _targets; //Field offset: 0x50
	[SerializeField]
	private Transform _switch; //Field offset: 0x58
	[SerializeField]
	[Space]
	private SharedTargetControl _sharedTargetControl; //Field offset: 0x60
	[SerializeField]
	[Space]
	private AudioSource _clickAudio; //Field offset: 0x68
	[SerializeField]
	private AudioSource _switchAudio; //Field offset: 0x70
	private AvailableInteractionState _prevAvailableInteractionState; //Field offset: 0x78
	private int _currentShootingSpeed; //Field offset: 0x80
	private bool _shootingEnabled; //Field offset: 0x84
	private bool _energized; //Field offset: 0x85
	private RailTargetShootingScenario _railTargetShootingScenario; //Field offset: 0x88
	private RailTargetStopScenario _railTargetStopScenario; //Field offset: 0x90
	private RailTargetInspectScenario _railTargetInspectScenario; //Field offset: 0x98
	private RailTargetFoldScenario _railTargetFoldScenario; //Field offset: 0xA0
	private Vector3[] _switchAngles; //Field offset: 0xA8

	public RailTargetControl() { }

	public virtual void Disable() { }

	private void Fold() { }

	private void IncrementShootingSpeed() { }

	[AsyncStateMachine(typeof(<Inspect>d__22))]
	private void Inspect() { }

	public virtual AvailableInteractionState InteractionStates(HideoutPlayerOwner owner) { }

	private int NextShootingSpeed() { }

	private void ResetShootingSpeed() { }

	[AsyncStateMachine(typeof(<Shooting>d__20))]
	private void Shooting() { }

	private void Start() { }

	[AsyncStateMachine(typeof(<Stop>d__21))]
	private void Stop() { }

	public void TurnOffEnergy() { }

	public void TurnOnEnergy() { }

	private void UpdateShootingSpeedSwitch() { }

	private void UpdateShootingSpeedTargets() { }

}

