namespace EFT.Interactive.SecretExfiltrations;

[Obfuscation(Exclude = True)]
public class SecretExfiltrationPointFoundShareEvent : SyncEventFromServer
{
	public string GroupId; //Field offset: 0x18
	public string TeamId; //Field offset: 0x20
	public string ExitName; //Field offset: 0x28

	public SecretExfiltrationPointFoundShareEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	public void Invoke(string groupId, string teamId, string exitName) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

}

