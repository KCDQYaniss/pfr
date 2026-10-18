namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class BtrSpawnOnThePathEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Quaternion <Rotation>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x34

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private Quaternion Rotation
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public BtrSpawnOnThePathEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	[CompilerGenerated]
	public Vector3 get_Position() { }

	[CompilerGenerated]
	public Quaternion get_Rotation() { }

	public void Invoke(Vector3 position, Quaternion rotation, int playerRaidId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

	[CompilerGenerated]
	private void set_Position(Vector3 value) { }

	[CompilerGenerated]
	private void set_Rotation(Quaternion value) { }

}

