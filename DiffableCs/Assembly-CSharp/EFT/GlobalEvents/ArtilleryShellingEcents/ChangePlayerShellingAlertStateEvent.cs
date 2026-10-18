namespace EFT.GlobalEvents.ArtilleryShellingEcents;

[Obfuscation(Exclude = True)]
public class ChangePlayerShellingAlertStateEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ZoneId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <NearestPoint>k__BackingField; //Field offset: 0x28

	public private Vector3 NearestPoint
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string ZoneId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ChangePlayerShellingAlertStateEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public Vector3 get_NearestPoint() { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	[CompilerGenerated]
	public string get_ZoneId() { }

	public void Invoke(int playerId, string alertStage, Vector3 nearestPoint) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_NearestPoint(Vector3 value) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

	[CompilerGenerated]
	private void set_ZoneId(string value) { }

}

