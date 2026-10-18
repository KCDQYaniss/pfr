namespace EFT.NextObservedPlayer;

public class ObservedPlayerMedsController : BaseObservedPlayerHandsController
{
	[CompilerGenerated]
	private struct <Execute>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	private ObservedPlayerMedsController(BaseAnimationHandsController handsAnimationController) { }

	public static ObservedPlayerMedsController CreateInstance(GameObject gameObject) { }

	[AsyncStateMachine(typeof(<Execute>d__2))]
	public virtual Task Execute(ICommandMessage command) { }

}

