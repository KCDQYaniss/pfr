namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class BtrReadyToDepartureEvent : SyncEventFromServer
{

	public BtrReadyToDepartureEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

}

