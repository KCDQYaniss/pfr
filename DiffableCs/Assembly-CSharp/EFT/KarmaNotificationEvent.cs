namespace EFT;

[Obfuscation(Exclude = True)]
public class KarmaNotificationEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsPositive>k__BackingField; //Field offset: 0x1C

	public private bool IsPositive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public KarmaNotificationEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public bool get_IsPositive() { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	public static void Invoke(int playerId, bool isPositive) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_IsPositive(bool value) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

}

