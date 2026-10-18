namespace EFT;

public struct MovementShortInfoPacket : Snapshot
{
	private const float ROTATION_VERTICAL_MIN = -90; //Field offset: 0x0
	private const float ROTATION_VERTICAL_MAX = 90; //Field offset: 0x0
	private const float MOVEMENT_DIRECTION_MIN = -1; //Field offset: 0x0
	private const float MOVEMENT_DIRECTION_MAX = 1; //Field offset: 0x0
	public byte Iteration; //Field offset: 0x0
	public float LastServerTime; //Field offset: 0x4
	public float ClientTime; //Field offset: 0x8
	public Vector3 TransformPosition; //Field offset: 0xC
	public Vector2 Rotation; //Field offset: 0x18
	public Vector2 MovementDirection; //Field offset: 0x20
	public EPlayerState State; //Field offset: 0x28
	[CompilerGenerated]
	private double <remoteTime>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private double <localTime>k__BackingField; //Field offset: 0x38

	public override double localTime
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override double remoteTime
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public void Deserialize(IBitReaderStream reader) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_localTime() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_remoteTime() { }

	private void MovementDirectionDeserialize(IBitReaderStream reader) { }

	private void MovementDirectionSerialize(IBitWriterStream writer) { }

	private void RotationDeserialize(IBitReaderStream reader) { }

	private void RotationSerialize(IBitWriterStream writer) { }

	public void Serialize(IBitWriterStream writer) { }

	[CompilerGenerated]
	public override void set_localTime(double value) { }

	[CompilerGenerated]
	public override void set_remoteTime(double value) { }

}

