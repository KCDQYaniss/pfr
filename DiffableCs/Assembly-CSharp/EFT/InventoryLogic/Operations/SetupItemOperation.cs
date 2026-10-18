namespace EFT.InventoryLogic.Operations;

public sealed class SetupItemOperation : AbstractAsyncOperation, IOneItemOperation, IInventoryOperation, IObservedOperation, IOperationInfo
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SetupItemOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public readonly Item Item; //Field offset: 0x68
	private readonly Vector3 _position; //Field offset: 0x70
	private readonly Quaternion _rotation; //Field offset: 0x7C
	private readonly string _zoneId; //Field offset: 0x90
	private readonly float _setupTime; //Field offset: 0x98
	private readonly ItemAddress _from; //Field offset: 0xA0
	private readonly IPlayer _player; //Field offset: 0xA8
	private IEnumerator _timer; //Field offset: 0xB0

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.From1
	{
		private get { } //Length: 8
	}

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.Item1
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.To1
	{
		private get { } //Length: 3
	}

	public SetupItemOperation(ushort id, ItemController controller, DiscardResult discardResult, string zoneId, Vector3 position, Quaternion rotation, IPlayer player, float setupTime) { }

	[CompilerGenerated]
	private void <Dispose>b__19_0() { }

	public virtual void Dispose() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__15))]
	protected virtual Task ExecuteInternal() { }

	private void LootItemDestroyedHandler(IKillable killable) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

