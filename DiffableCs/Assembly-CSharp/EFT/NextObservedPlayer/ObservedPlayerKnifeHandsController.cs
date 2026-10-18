namespace EFT.NextObservedPlayer;

public class ObservedPlayerKnifeHandsController : BaseObservedPlayerHandsController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public ObservedPlayerHandsController handsController; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal Vector3 <.ctor>b__0() { }

		internal PlayerBones <.ctor>b__1() { }

	}

	[CompilerGenerated]
	private struct <BreakMeleeCombo>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerKnifeHandsController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Execute>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ICommandMessage command; //Field offset: 0x20
		public ObservedPlayerKnifeHandsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ManualUpdate>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cToken; //Field offset: 0x20
		public ObservedPlayerKnifeHandsController <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerKnifeHandsController <>4__this; //Field offset: 0x20
		public ExamineWeaponCommandMessage command; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpecificExecute>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerKnifeHandsController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float LERP_DIRECTION_T = 0.9; //Field offset: 0x0
	private readonly KnifeAnimationHandsController _specificHandsAnimationController; //Field offset: 0x28
	public Vector3 GlobalSwingDirection; //Field offset: 0x30
	private KnifeCollider _knifeCollider; //Field offset: 0x40
	private Vector3 _previousColliderPosition; //Field offset: 0x48
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x58
	private Knife _knife; //Field offset: 0x60
	private bool _isInAttack; //Field offset: 0x68

	private ObservedPlayerKnifeHandsController(KnifeAnimationHandsController handsAnimationController, ObservedPlayerHandsController handsController) { }

	[CompilerGenerated]
	private void <SpecificExecute>b__16_0() { }

	[CompilerGenerated]
	private void <SpecificExecute>b__16_1() { }

	[AsyncStateMachine(typeof(<BreakMeleeCombo>d__21))]
	private Task BreakMeleeCombo() { }

	public static ObservedPlayerKnifeHandsController CreateInstance(GameObject gameObject, ObservedPlayerHandsController handsController) { }

	public virtual void Destroy() { }

	[AsyncStateMachine(typeof(<Execute>d__15))]
	public virtual Task Execute(ICommandMessage command) { }

	[AsyncStateMachine(typeof(<ManualUpdate>d__10))]
	private Task ManualUpdate(CancellationToken cToken) { }

	private void OnKnifeHittedSomething(KnifeRaycastHit kHitInfo) { }

	private void SetDeflected(bool deflected) { }

	private Task SpecificExecute(MeleeAttackCommandMessage command) { }

	private Task SpecificExecute(ZombieMeleeAttackCommandMessage command) { }

	private Task SpecificExecute(IdleStateSyncCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__19))]
	private Task SpecificExecute(ExamineWeaponCommandMessage command) { }

	[AsyncStateMachine(typeof(<SpecificExecute>d__20))]
	private Task SpecificExecute(BreakMeleeComboCombatMessage command) { }

	public virtual Task Unspawn(float animationSpeed, bool fastHide) { }

}

