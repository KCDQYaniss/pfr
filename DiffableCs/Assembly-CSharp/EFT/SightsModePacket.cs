namespace EFT;

public struct SightsModePacket
{
	public bool ChangeSightMode; //Field offset: 0x0
	public SightModeStatus[] SightModeStatuses; //Field offset: 0x8

	public static void Serialize(IBitStream stream, ref SightsModePacket packet) { }

}

