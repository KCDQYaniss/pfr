namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerGrenadeHandsController : BaseObservedPlayerHandsController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public PlayerBones playerBones; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal Transform <.ctor>b__0(string x) { }

	}

	[CompilerGenerated]
	private struct <Execute>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ICommandMessage command; //Field offset: 0x20
		public ObservedPlayerGrenadeHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerGrenadeHandsController <>4__this; //Field offset: 0x20
		public ChangeFireModeCommandMessage commandMessage; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerGrenadeHandsController <>4__this; //Field offset: 0x20
		public ThrowGrenadeCommandMessage commandMessage; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum EThrowState
	{
		None = 0,
		Idling = 1,
		Throwing = 2,
		Threw = 3,
	}

	private EThrowState _throwState; //Field offset: 0x28
	private Transform[] _throwingObjectsForDisable; //Field offset: 0x30
	private bool _grenadeDropped; //Field offset: 0x38
	private readonly GrenadeAnimationHandsController _specificHandsAnimationController; //Field offset: 0x40
	private readonly ObservedPlayerHandsController _handsController; //Field offset: 0x48
	private readonly IPlayer _player; //Field offset: 0x50
	private readonly PlayerBones _playerBones; //Field offset: 0x58
	private GrenadeEmission _grenadeEmission; //Field offset: 0x60

	public ObservedPlayerGrenadeHandsController(GrenadeAnimationHandsController handsAnimationController, IPlayer player, PlayerBones playerBones, ObservedPlayerHandsController handsController) { }

	public static ObservedPlayerGrenadeHandsController CreateInstance(GameObject gameObject, IPlayer player, PlayerBones playerBones, ObservedPlayerHandsController handsController) { }

	[AsyncStateMachine(typeof(<Execute>d__10))]
	public virtual Task Execute(ICommandMessage command) { }

	private void HandleCook() { }

	private void HandleDrop() { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__11))]
	private Task SpecificExecute(ChangeFireModeCommandMessage commandMessage) { }

	private Task SpecificExecute(SwingGrenadeCommandMessage commandMessage) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__13))]
	private Task SpecificExecute(ThrowGrenadeCommandMessage commandMessage) { }

}

