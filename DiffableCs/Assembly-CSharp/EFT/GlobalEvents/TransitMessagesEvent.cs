namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class TransitMessagesEvent : SyncEventFromServer
{
	internal enum EType
	{
		NonAllTeammates = 0,
		NonReady = 1,
	}

	[CompilerGenerated]
	private Dictionary <Messages>k__BackingField; //Field offset: 0x18

	public private Dictionary Messages
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public TransitMessagesEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public Dictionary get_Messages() { }

	public void Invoke(Dictionary messages) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_Messages(Dictionary value) { }

}

