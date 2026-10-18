namespace EFT.InventoryLogic.Operations;

public sealed class CheckMagazineOperation : AbstractOperation
{
	private readonly Item _item; //Field offset: 0x40
	private readonly bool _checkStatus; //Field offset: 0x48
	private readonly byte _skillLevel; //Field offset: 0x49
	private readonly IInventoryProfileInfo _profile; //Field offset: 0x50

	public CheckMagazineOperation(ushort id, ItemController controller, bool checkStatus, int skill, Item item, IInventoryProfileInfo profile) { }

	public static void CheckMagazine(ItemController controller, Magazine magazine, IInventoryProfileInfo profile, bool status, int skill, bool notify = true) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

