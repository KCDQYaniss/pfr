//Type is in global namespace

[Extension]
public static class SynchronizableObjectPacketExtensions
{
	private static readonly Vector3Quantizer RotationQuantizer; //Field offset: 0x0

	[Extension]
	public static void Serialize(IBitStream stream, ref SynchronizableObjectPacket packet) { }

	[Extension]
	public static void Serialize(IBitStream stream, ref AirdropDataPacket packet) { }

	[Extension]
	public static void Serialize(IBitStream stream, ref AirplaneDataPacket packet) { }

	[Extension]
	public static void Serialize(IBitStream stream, ref DevelopDataPacket packet) { }

	[Extension]
	public static void Serialize(IBitStream stream, ref TripwireDataPacket packet) { }

}

