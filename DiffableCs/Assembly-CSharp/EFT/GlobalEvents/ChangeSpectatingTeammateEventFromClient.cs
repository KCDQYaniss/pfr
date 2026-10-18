namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class ChangeSpectatingTeammateEventFromClient : SyncEventFromClient
{
	public const int NoSkipTargetRaidId = -1; //Field offset: 0x0
	[CompilerGenerated]
	private int <PlayerRaidID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <NextSpectatingIndex>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <SkipTargetRaidID>k__BackingField; //Field offset: 0x28

	public bool NextSpectatingIndex
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

	public int SkipTargetRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ChangeSpectatingTeammateEventFromClient() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_NextSpectatingIndex() { }

	[CompilerGenerated]
	public int get_PlayerRaidID() { }

	[CompilerGenerated]
	public int get_SkipTargetRaidID() { }

	public void Invoke(int playerRaidId, bool nextSpectatingIndex, int skipTargetRaidId = -1) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	public void set_NextSpectatingIndex(bool value) { }

	[CompilerGenerated]
	public void set_PlayerRaidID(int value) { }

	[CompilerGenerated]
	public void set_SkipTargetRaidID(int value) { }

}

