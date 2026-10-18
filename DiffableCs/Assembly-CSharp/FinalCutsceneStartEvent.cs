//Type is in global namespace

[Obfuscation(Exclude = True)]
public class FinalCutsceneStartEvent : SyncEventFromClient
{

	public FinalCutsceneStartEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

}

