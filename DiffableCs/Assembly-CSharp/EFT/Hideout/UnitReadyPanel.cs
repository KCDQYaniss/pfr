namespace EFT.Hideout;

public sealed class UnitReadyPanel : AbstractPanel
{
	[CompilerGenerated]
	private struct <ShowContents>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UnitReadyPanel <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string UNIT_READY_TEXT = "Unit is ready to be installed"; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _statusLabel; //Field offset: 0xA0
	[SerializeField]
	private CustomTextMeshProUGUI _descriptionLabel; //Field offset: 0xA8

	public UnitReadyPanel() { }

	public virtual void SetInfo() { }

	[AsyncStateMachine(typeof(<ShowContents>d__3))]
	public virtual Task ShowContents() { }

}

