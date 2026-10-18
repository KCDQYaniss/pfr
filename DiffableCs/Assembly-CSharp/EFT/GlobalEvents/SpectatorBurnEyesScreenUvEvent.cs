namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class SpectatorBurnEyesScreenUvEvent : SyncEventFromClient
{
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <Strength>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private Vector2 <ScreenUv>k__BackingField; //Field offset: 0x30

	public private Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private Vector2 ScreenUv
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private float Strength
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public SpectatorBurnEyesScreenUvEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public Vector3 get_Position() { }

	[CompilerGenerated]
	public Vector2 get_ScreenUv() { }

	[CompilerGenerated]
	public float get_Strength() { }

	public void Invoke(Vector3 position, float strength, Vector2 screenUv) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_Position(Vector3 value) { }

	[CompilerGenerated]
	private void set_ScreenUv(Vector2 value) { }

	[CompilerGenerated]
	private void set_Strength(float value) { }

}

