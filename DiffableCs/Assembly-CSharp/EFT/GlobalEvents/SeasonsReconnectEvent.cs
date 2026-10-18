namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class SeasonsReconnectEvent : SyncEventFromServer
{
	public int PlayerRaidID; //Field offset: 0x18
	[CompilerGenerated]
	private ESeasonStatus <SeasonStatus>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private SeasonsSettings <SeasonsSettings>k__BackingField; //Field offset: 0x20

	private AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public private SeasonsSettings SeasonsSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ESeasonStatus SeasonStatus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public SeasonsReconnectEvent() { }

	public virtual void Deserialize(ref IBitReaderStream stream) { }

	private AbstractLogger get_Logger() { }

	[CompilerGenerated]
	public SeasonsSettings get_SeasonsSettings() { }

	[CompilerGenerated]
	public ESeasonStatus get_SeasonStatus() { }

	public void Invoke(int playerID, ESeasonStatus seasonStatus, SeasonsSettings seasonsSettings) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream stream) { }

	[CompilerGenerated]
	private void set_SeasonsSettings(SeasonsSettings value) { }

	[CompilerGenerated]
	private void set_SeasonStatus(ESeasonStatus value) { }

}

