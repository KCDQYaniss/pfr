namespace EFT;

public struct LauncherRangeStatePacket
{
	public bool ChangeLauncherRange; //Field offset: 0x0
	public int RangeValue; //Field offset: 0x4
	public int LastRangeValue; //Field offset: 0x8

	public static void Serialize(IBitStream stream, ref LauncherRangeStatePacket packet) { }

}

