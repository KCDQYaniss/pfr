namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class HalloweenSyncExitsEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private string <ExitName>k__BackingField; //Field offset: 0x18

	public private string ExitName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HalloweenSyncExitsEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public string get_ExitName() { }

	public void Invoke(string exitName) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_ExitName(string value) { }

}

