namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class TransitInteractionEvent : SyncEventFromServer
{
	internal enum EType
	{
		Show = 0,
		Hide = 1,
		CheckAccess = 2,
		InactivePoint = 3,
		Confirm = 4,
		TransitInitialRequirementsFailed = 5,
		OverGroupSize = 6,
	}

	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <PointId>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private EType <Type>k__BackingField; //Field offset: 0x20

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int PointId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private EType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public TransitInteractionEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	[CompilerGenerated]
	public int get_PointId() { }

	[CompilerGenerated]
	public EType get_Type() { }

	public void Invoke(int playerId, int pointId, EType type) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

	[CompilerGenerated]
	private void set_PointId(int value) { }

	[CompilerGenerated]
	private void set_Type(EType value) { }

}

