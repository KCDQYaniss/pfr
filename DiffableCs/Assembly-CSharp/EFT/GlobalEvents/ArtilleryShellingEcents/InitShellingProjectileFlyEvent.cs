namespace EFT.GlobalEvents.ArtilleryShellingEcents;

[Obfuscation(Exclude = True)]
public class InitShellingProjectileFlyEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <ProjectileID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <Speed>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Vector3 <StartPosition>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <EndPosition>k__BackingField; //Field offset: 0x2C

	public private Vector3 EndPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private int ProjectileID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float Speed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private Vector3 StartPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public InitShellingProjectileFlyEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public Vector3 get_EndPosition() { }

	[CompilerGenerated]
	public int get_ProjectileID() { }

	[CompilerGenerated]
	public float get_Speed() { }

	[CompilerGenerated]
	public Vector3 get_StartPosition() { }

	public void Invoke(int id, float speed, Vector3 startPosition, Vector3 endPosition) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_EndPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_ProjectileID(int value) { }

	[CompilerGenerated]
	private void set_Speed(float value) { }

	[CompilerGenerated]
	private void set_StartPosition(Vector3 value) { }

}

