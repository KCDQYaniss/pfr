namespace EFT.GlobalEvents;

public class StartSpectatingForTeammateEvent : SyncEventFromServer
{
	internal struct SpectatingTeammateInfo
	{
		public int RaidID; //Field offset: 0x0
		public string NickName; //Field offset: 0x8
		public EMemberCategory SelectedMemberCategory; //Field offset: 0x10
		public int PrestigeLevel; //Field offset: 0x14
		public Dictionary NormalizedHealthDict; //Field offset: 0x18

		public SpectatingTeammateInfo(int raidID, string nickName, EMemberCategory selectedMemberCategory, int prestigeLevel, Dictionary normalizedHealthDict) { }

	}

	[CompilerGenerated]
	private int <PlayerRaidID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <CurrentSpectatingTeammateRaidID>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private SpectatingTeammateInfo[] <PlayerTeammatesInfo>k__BackingField; //Field offset: 0x20

	public private int CurrentSpectatingTeammateRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int PlayerRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private SpectatingTeammateInfo[] PlayerTeammatesInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public StartSpectatingForTeammateEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_CurrentSpectatingTeammateRaidID() { }

	[CompilerGenerated]
	public int get_PlayerRaidID() { }

	[CompilerGenerated]
	public SpectatingTeammateInfo[] get_PlayerTeammatesInfo() { }

	public void Invoke(int playerRaidId, int currentSpectatingIndex, SpectatingTeammateInfo[] playerTeammatesInfo) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_CurrentSpectatingTeammateRaidID(int value) { }

	[CompilerGenerated]
	public void set_PlayerRaidID(int value) { }

	[CompilerGenerated]
	private void set_PlayerTeammatesInfo(SpectatingTeammateInfo[] value) { }

}

