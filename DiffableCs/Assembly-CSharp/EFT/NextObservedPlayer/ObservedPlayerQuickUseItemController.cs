namespace EFT.NextObservedPlayer;

public class ObservedPlayerQuickUseItemController : BaseObservedPlayerHandsController
{
	[CompilerGenerated]
	private struct <Spawn>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerQuickUseItemController <>4__this; //Field offset: 0x20
		public float animationSpeed; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly QuickUseItemAnimationHandsController _specificHandsAnimationController; //Field offset: 0x28

	private ObservedPlayerQuickUseItemController(QuickUseItemAnimationHandsController handsAnimationController) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(float animationSpeed) { }

	public static ObservedPlayerQuickUseItemController CreateInstance(GameObject gameObject) { }

	public virtual Task Execute(ICommandMessage command) { }

	[AsyncStateMachine(typeof(<Spawn>d__3))]
	public virtual Task Spawn(float animationSpeed) { }

}

