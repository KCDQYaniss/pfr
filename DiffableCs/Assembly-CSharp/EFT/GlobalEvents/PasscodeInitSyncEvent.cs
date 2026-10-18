namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class PasscodeInitSyncEvent : SyncEventFromServer
{
	internal sealed class Entry
	{
		public string PasscodeId; //Field offset: 0x10
		public readonly List Hints; //Field offset: 0x18

		public Entry() { }

	}

	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	public readonly List Entries; //Field offset: 0x20

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public PasscodeInitSyncEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	public void Invoke(int playerRaidId, IReadOnlyDictionary hintsByPasscodeId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

}

