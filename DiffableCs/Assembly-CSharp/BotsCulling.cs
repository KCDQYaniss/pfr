//Type is in global namespace

public class BotsCulling
{
	public bool DeserializeDone; //Field offset: 0x10
	public HashSet PlayerIdToForcedHidden; //Field offset: 0x18

	public BotsCulling() { }

	public void Deserialize(IBitReaderStream readerStream) { }

	public bool GetForcedHidden(int playerId) { }

	public bool Remove(int playerId) { }

	public void Serialize(IBitWriterStream writerStream) { }

	public bool SetForcedHidden(int playerId, bool forcedHidden) { }

}

