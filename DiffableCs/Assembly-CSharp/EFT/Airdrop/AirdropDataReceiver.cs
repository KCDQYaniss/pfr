namespace EFT.Airdrop;

public sealed class AirdropDataReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <ParseItemData>b__1_0(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public NetworkReader reader; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal Item <ParseItemData>b__1() { }

	}

	[CompilerGenerated]
	private struct <ParseAirdropContainerData>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public byte[] data; //Field offset: 0x20
		private NetworkReaderPooled <reader>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseItemData>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NetworkReader reader; //Field offset: 0x20
		private Item <parsedItem>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public AirdropDataReceiver() { }

	[AsyncStateMachine(typeof(<ParseAirdropContainerData>d__0))]
	public Task ParseAirdropContainerData(byte[] data) { }

	[AsyncStateMachine(typeof(<ParseItemData>d__1))]
	private static Task ParseItemData(NetworkReader reader) { }

}

