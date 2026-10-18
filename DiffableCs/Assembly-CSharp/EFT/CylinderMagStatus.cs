namespace EFT;

public struct CylinderMagStatus
{
	private const int MAX_CAMORA_INDEX = 6; //Field offset: 0x0
	public bool StatusChanged; //Field offset: 0x0
	public int CamoraIndex; //Field offset: 0x4
	public bool HammerClosed; //Field offset: 0x8

	public static void Serialize(IBitStream serializer, ref CylinderMagStatus magStatus) { }

}

