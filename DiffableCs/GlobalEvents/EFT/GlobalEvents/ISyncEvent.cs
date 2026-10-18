namespace EFT.GlobalEvents;

public interface ISyncEvent : IEvent
{

	public void Deserialize(ref IBitReaderStream readerStream) { }

	public void Serialize(ref IBitWriterStream writerStream) { }

}

