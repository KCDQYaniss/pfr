namespace EFT.InventoryLogic.Operations;

public sealed class FaceshieldMarkOperation : AbstractOperation, IObservedOperation, IOperationInfo
{
	private readonly FaceShieldComponent _faceShield; //Field offset: 0x40
	private readonly ItemAddress _from; //Field offset: 0x48

	internal FaceshieldMarkOperation(ushort id, ItemController controller, FaceShieldComponent faceShield) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

