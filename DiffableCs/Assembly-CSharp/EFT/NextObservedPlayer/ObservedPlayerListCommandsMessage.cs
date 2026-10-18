namespace EFT.NextObservedPlayer;

public class ObservedPlayerListCommandsMessage : BaseObservedPlayerListMessage
{
	public float WorldTime; //Field offset: 0x48

	public ObservedPlayerListCommandsMessage(int capacity) { }

	public virtual ObservedPlayerCommandsMessage CreateInstanceValue() { }

	public virtual void ReadFields(NetworkReader reader) { }

	public virtual void WriteFields(NetworkWriter writer) { }

}

