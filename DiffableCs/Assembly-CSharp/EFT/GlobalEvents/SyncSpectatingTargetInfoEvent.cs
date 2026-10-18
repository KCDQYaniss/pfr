namespace EFT.GlobalEvents;

public class SyncSpectatingTargetInfoEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <SpectateTargetRaidID>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private EBodyPart <BodyPart>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <NormalizedHealthValue>k__BackingField; //Field offset: 0x24

	public private EBodyPart BodyPart
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float NormalizedHealthValue
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public int PlayerRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private int SpectateTargetRaidID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public SyncSpectatingTargetInfoEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public EBodyPart get_BodyPart() { }

	[CompilerGenerated]
	public float get_NormalizedHealthValue() { }

	[CompilerGenerated]
	public int get_PlayerRaidID() { }

	[CompilerGenerated]
	public int get_SpectateTargetRaidID() { }

	public void Invoke(int playerRaidId, int spectateTargetRaidID, EBodyPart bodyPart, float normalizedHealth) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_BodyPart(EBodyPart value) { }

	[CompilerGenerated]
	private void set_NormalizedHealthValue(float value) { }

	[CompilerGenerated]
	public void set_PlayerRaidID(int value) { }

	[CompilerGenerated]
	private void set_SpectateTargetRaidID(int value) { }

}

