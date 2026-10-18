namespace EFT.InventoryLogic.Operations;

public sealed class WeaponRechamberOperation : AbstractAsyncOperation, IOneItemOperation, IInventoryOperation
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WeaponRechamberOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public readonly Ammo AmmoInChamber; //Field offset: 0x68
	private readonly Weapon _weapon; //Field offset: 0x70
	private readonly ItemAddress _from; //Field offset: 0x78
	private readonly Item _ammoInMagazine; //Field offset: 0x80
	[CanBeNull]
	private readonly Magazine _magazine; //Field offset: 0x88

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.From1
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.Item1
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.To1
	{
		private get { } //Length: 3
	}

	internal WeaponRechamberOperation(ushort id, ItemController controller, Weapon weapon, DiscardResult discardResult) { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__12))]
	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

