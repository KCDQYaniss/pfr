namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class NotifyEvent : SyncEventFromServer
{
	internal enum EMessageType
	{
		ArtilleryBusy = 0,
	}

	public EMessageType MessageType; //Field offset: 0x18
	public int ReceiverId; //Field offset: 0x1C

	public NotifyEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

}

