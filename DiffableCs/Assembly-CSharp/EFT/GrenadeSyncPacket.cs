namespace EFT;

public struct GrenadeSyncPacket
{
	private static readonly QuaternionQuantizer _rotationQuantizer; //Field offset: 0x0
	private static readonly Vector3Quantizer _velocityQuantizer; //Field offset: 0x8
	private static readonly Vector3Quantizer _angularVelocityQuantizer; //Field offset: 0x10
	public int Id; //Field offset: 0x0
	public Vector3 Position; //Field offset: 0x4
	public Quaternion Rotation; //Field offset: 0x10
	public Vector3 Velocity; //Field offset: 0x20
	public Vector3 AngularVelocity; //Field offset: 0x2C
	public byte CollisionNumber; //Field offset: 0x38
	public bool Done; //Field offset: 0x39
	public bool IsNew; //Field offset: 0x3A
	public string ItemId; //Field offset: 0x40
	public string TemplateId; //Field offset: 0x48
	public int PlayerRaidId; //Field offset: 0x50

	private static GrenadeSyncPacket() { }

	public void Deserialize(IBitReaderStream reader) { }

	public void Serialize(IBitWriterStream writer) { }

}

