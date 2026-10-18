namespace EFT.InventoryLogic.Operations;

public abstract class AbstractMagOperation`1 : AbstractOperation, IParentOperation, IInventoryOperation, IObservedOperation, IOperationInfo
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public AbstractMagOperation <>4__this; //Field offset: 0x0
		public Callback callback; //Field offset: 0x0

		public <>c__DisplayClass4_0() { }

		internal void <ExecuteInternal>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private readonly AbstractOperation <InternalOperation>k__BackingField; //Field offset: 0x0

	public override AbstractOperation InternalOperation
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected AbstractMagOperation`1(ushort id, ItemController controller, AbstractOperation internalOperation) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	[CompilerGenerated]
	public override AbstractOperation get_InternalOperation() { }

	protected abstract void SucceedAmmoManipulationHandler() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

