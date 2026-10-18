namespace EFT.UI.Ragfair;

public sealed class RagfairGetOffersOperation : RagfairAbstractOperation
{
	[CompilerGenerated]
	private struct <ExecuteOnce>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RagfairGetOffersOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly bool _updateCategories; //Field offset: 0x20
	private readonly FilterRule _filterRule; //Field offset: 0x28

	public string HandbookId
	{
		 get { } //Length: 103
	}

	public RagfairGetOffersOperation(RagFair ragfair, bool updateCategories) { }

	[AsyncStateMachine(typeof(<ExecuteOnce>d__5))]
	protected virtual Task ExecuteOnce() { }

	public string get_HandbookId() { }

}

