namespace EFT.InventoryLogic.Operations;

public abstract class SearchContentOperation : AbstractOperation
{
	internal readonly SearchableItem Item; //Field offset: 0x40
	[CompilerGenerated]
	private DateTime <StartTime>k__BackingField; //Field offset: 0x48

	public private DateTime StartTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	protected SearchContentOperation(ushort id, ItemController controller, SearchableItem item) { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	public DateTime get_StartTime() { }

	private void Init() { }

	[CompilerGenerated]
	private void set_StartTime(DateTime value) { }

	public abstract void Terminate() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

