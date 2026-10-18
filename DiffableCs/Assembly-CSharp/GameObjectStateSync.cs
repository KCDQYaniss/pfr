//Type is in global namespace

public class GameObjectStateSync : ISyncAble
{

	public GameObjectStateSync() { }

	public virtual void Deserialize(IBitReaderStream readerStream) { }

	public virtual void Serialize(IBitWriterStream writerStream) { }

}

