namespace EFT.NextObservedPlayer;

public class ObservedPlayerRecorderHandsController : BaseObservedPlayerHandsController
{
	[CompilerGenerated]
	private struct <Execute>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ICommandMessage command; //Field offset: 0x20
		public ObservedPlayerRecorderHandsController <>4__this; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	private ObservedPlayerRecorderHandsController(BaseAnimationHandsController handsAnimationController) { }

	public static ObservedPlayerRecorderHandsController CreateInstance(GameObject gameObject) { }

	[AsyncStateMachine(typeof(<Execute>d__2))]
	public virtual Task Execute(ICommandMessage command) { }

}

