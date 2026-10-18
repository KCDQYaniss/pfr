namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class StormStartedEvent : SyncEventFromServer
{

	public StormStartedEvent() { }

	public virtual void Deserialize(ref IBitReaderStream stream) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream stream) { }

}

