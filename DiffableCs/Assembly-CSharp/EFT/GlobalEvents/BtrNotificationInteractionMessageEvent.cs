namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class BtrNotificationInteractionMessageEvent : SyncEventFromServer
{
	public int PlayerRaidId; //Field offset: 0x18
	public EBtrInteractionStatus InteractionStatus; //Field offset: 0x1C

	public BtrNotificationInteractionMessageEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	public void Invoke(int playerId, EBtrInteractionStatus interactionStatus) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

}

