namespace EFT.GameTriggers;

[Obfuscation(Exclude = True)]
public class TriggerEventClient : SyncEventFromClient
{
	[CompilerGenerated]
	private int <TriggerId>k__BackingField; //Field offset: 0x20

	public int TriggerId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public TriggerEventClient() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_TriggerId() { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	public void set_TriggerId(int value) { }

}

