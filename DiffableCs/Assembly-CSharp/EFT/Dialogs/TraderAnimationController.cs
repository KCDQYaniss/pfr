namespace EFT.Dialogs;

public class TraderAnimationController : ITraderAnimationController
{
	[CompilerGenerated]
	private struct <ExecuteDialogOption>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CombinedAnimationData animationData; //Field offset: 0x20
		public TraderAnimationController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly NPCObject <Animator>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ClientDialogController <ClientDialogController>k__BackingField; //Field offset: 0x18

	public override NPCObject Animator
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override ClientDialogController ClientDialogController
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public TraderAnimationController(NPCObject npc, ClientDialogController dialogController) { }

	[AsyncStateMachine(typeof(<ExecuteDialogOption>d__7))]
	public override Task ExecuteDialogOption(CombinedAnimationData animationData) { }

	[CompilerGenerated]
	public override NPCObject get_Animator() { }

	[CompilerGenerated]
	public override ClientDialogController get_ClientDialogController() { }

	public override void SkipAnimation() { }

}

