namespace EFT;

public struct RollCylinderPacket
{
	public bool RollCylinder; //Field offset: 0x0
	public bool RollToZeroCamora; //Field offset: 0x1

	public static void Serialize(IBitStream serializer, ref RollCylinderPacket rollCylinderPacket) { }

}

