namespace EFT;

public sealed class TraderServicesItemPaymaster
{
	[CompilerGenerated]
	private struct <TryToPay>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable availableItems; //Field offset: 0x20
		public TraderServicesItemPaymaster <>4__this; //Field offset: 0x28
		public ItemController itemController; //Field offset: 0x30
		private Enumerator <>7__wrap1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Dictionary _itemsToPay; //Field offset: 0x10
	private readonly Dictionary _itemsLeftCache; //Field offset: 0x18
	private readonly List _removeResults; //Field offset: 0x20

	public TraderServicesItemPaymaster(GlobalsDictionary itemsToPayData) { }

	[AsyncStateMachine(typeof(<TryToPay>d__4))]
	public Task TryToPay(IEnumerable availableItems, ItemController itemController) { }

}

