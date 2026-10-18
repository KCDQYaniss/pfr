namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public abstract class SyncEvent : BaseEvent, ISyncEvent, IEvent
{

	protected SyncEvent() { }

	public abstract void Deserialize(ref IBitReaderStream readerStream) { }

	public abstract void Serialize(ref IBitWriterStream writerStream) { }

}

