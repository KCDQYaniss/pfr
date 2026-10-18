namespace EFT.GlobalEvents.ArtilleryShellingEcents;

[Obfuscation(Exclude = True)]
public class LastShellingExplosionZoneEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private string <ZoneId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <Radius>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <Center>k__BackingField; //Field offset: 0x24

	public private Vector3 Center
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private float Radius
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private string ZoneId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public LastShellingExplosionZoneEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public Vector3 get_Center() { }

	[CompilerGenerated]
	public float get_Radius() { }

	[CompilerGenerated]
	public string get_ZoneId() { }

	public void Invoke(string id, float radius, Vector3 center) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_Center(Vector3 value) { }

	[CompilerGenerated]
	private void set_Radius(float value) { }

	[CompilerGenerated]
	private void set_ZoneId(string value) { }

}

