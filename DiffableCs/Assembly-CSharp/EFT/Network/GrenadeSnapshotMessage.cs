namespace EFT.Network;

public struct GrenadeSnapshotMessage : Snapshot
{
	[CompilerGenerated]
	private double <remoteTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private double <localTime>k__BackingField; //Field offset: 0x8
	public Vector3 Position; //Field offset: 0x10
	public Quaternion Rotation; //Field offset: 0x1C
	public Vector3 Velocity; //Field offset: 0x2C
	public Vector3 AngularVelocity; //Field offset: 0x38
	public byte CollisionNumber; //Field offset: 0x44
	public bool Done; //Field offset: 0x45

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
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public static GrenadeSnapshotMessage FromPacket(GrenadeSyncPacket packet, float remoteTime, float localTime) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_localTime() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_remoteTime() { }

	public static GrenadeSnapshotMessage Interpolate(GrenadeSnapshotMessage from, GrenadeSnapshotMessage to, float t) { }

	[CompilerGenerated]
	public override void set_localTime(double value) { }

	[CompilerGenerated]
	public override void set_remoteTime(double value) { }

}

