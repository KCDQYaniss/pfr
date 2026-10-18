namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class SpectatingEnableEvent : SyncEventFromClient
{
	[CompilerGenerated]
	private int <PlayerRaidID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Enable>k__BackingField; //Field offset: 0x24

	public bool Enable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int PlayerRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SpectatingEnableEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_Enable() { }

	[CompilerGenerated]
	public int get_PlayerRaidID() { }

	public void Invoke(int playerRaidId, bool enable) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	public void set_Enable(bool value) { }

	[CompilerGenerated]
	public void set_PlayerRaidID(int value) { }

}

