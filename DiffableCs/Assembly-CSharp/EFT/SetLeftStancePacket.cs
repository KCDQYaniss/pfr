namespace EFT;

public struct SetLeftStancePacket
{
	public bool HasNewValue; //Field offset: 0x0
	public bool LeftStanceState; //Field offset: 0x1

	public static void Serialize(IBitStream stream, ref SetLeftStancePacket packet) { }

}

