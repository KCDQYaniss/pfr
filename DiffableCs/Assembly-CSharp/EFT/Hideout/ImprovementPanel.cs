namespace EFT.Hideout;

public sealed class ImprovementPanel : AbstractPanel
{
	[CompilerGenerated]
	private struct <ShowContents>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ImprovementPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private ImprovementView _improvementViewTemplate; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _container; //Field offset: 0xA8
	private Dictionary _views; //Field offset: 0xB0
	private AsyncViewList _viewList; //Field offset: 0xB8

	public ImprovementPanel() { }

	[CompilerGenerated]
	private ImprovementView <ShowContents>b__4_0(Improvement arg) { }

	[CompilerGenerated]
	private Transform <ShowContents>b__4_1(Improvement arg) { }

	[CompilerGenerated]
	private void <ShowContents>b__4_2(Improvement improvement, ImprovementView view) { }

	public virtual void SetInfo() { }

	[AsyncStateMachine(typeof(<ShowContents>d__4))]
	public virtual Task ShowContents() { }

}

