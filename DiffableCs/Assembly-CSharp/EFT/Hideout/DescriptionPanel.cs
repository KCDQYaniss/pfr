namespace EFT.Hideout;

public sealed class DescriptionPanel : AbstractPanel
{
	[CompilerGenerated]
	private struct <ShowContents>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DescriptionPanel <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private CustomTextMeshProUGUI _descriptionLabel; //Field offset: 0xA8

	public DescriptionPanel() { }

	public virtual void SetInfo() { }

	[AsyncStateMachine(typeof(<ShowContents>d__1))]
	public virtual Task ShowContents() { }

}

