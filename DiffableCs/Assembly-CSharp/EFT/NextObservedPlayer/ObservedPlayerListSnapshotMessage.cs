namespace EFT.NextObservedPlayer;

public class ObservedPlayerListSnapshotMessage : BaseObservedPlayerListMessage
{
	public float WorldTime; //Field offset: 0x48

	public ObservedPlayerListSnapshotMessage(int capacity) { }

	public virtual ObservedPlayerSnapshotMessage CreateInstanceValue() { }

	public virtual void ReadFields(NetworkReader reader) { }

	public virtual void WriteFields(NetworkWriter writer) { }

}

