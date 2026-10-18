namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class BotCullingStateSyncEvent : SyncEventFromServer
{
	public HashSet CullingForceHide; //Field offset: 0x18

	public BotCullingStateSyncEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

}

