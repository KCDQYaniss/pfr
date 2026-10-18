namespace EFT.Hideout;

public sealed class ConstructionTimePanel : AbstractPanel
{
	[CompilerGenerated]
	private struct <ShowContents>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ConstructionTimePanel <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string HOURS_LABEL = "HOURS"; //Field offset: 0x0
	private const string INSTANT_LABEL = "INSTANT"; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _constructTimeLabel; //Field offset: 0xA0

	public ConstructionTimePanel() { }

	public virtual void SetInfo() { }

	[AsyncStateMachine(typeof(<ShowContents>d__3))]
	public virtual Task ShowContents() { }

}

