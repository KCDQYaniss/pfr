//Type is in global namespace

public struct SynchronizableObjectPacket
{
	internal struct Data
	{
		public AirplaneDataPacket AirplaneDataPacket; //Field offset: 0x0
		public AirdropDataPacket AirdropDataPacket; //Field offset: 0x0
		public DevelopDataPacket DevelopDataPacket; //Field offset: 0x0
		public TripwireDataPacket TripwireDataPacket; //Field offset: 0x0

	}

	private static readonly QuaternionQuantizer RotationQuantizer; //Field offset: 0x0
	public bool Develop; //Field offset: 0x0
	public int ObjectId; //Field offset: 0x4
	public Vector3 Position; //Field offset: 0x8
	public Vector3 Rotation; //Field offset: 0x14
	public SynchronizableObjectType ObjectType; //Field offset: 0x20
	public bool Outdated; //Field offset: 0x24
	public bool IsStatic; //Field offset: 0x25
	public bool IsActive; //Field offset: 0x26
	public Data PacketData; //Field offset: 0x28

	private static SynchronizableObjectPacket() { }

}

