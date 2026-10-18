namespace EFT;

public struct SpectatorScopeZoomStatus
{
	public string Id; //Field offset: 0x0
	public int ScopeIndexInsideSight; //Field offset: 0x8
	public float ScopeZoomValue; //Field offset: 0xC

	public static void Serialize(IBitStream stream, ref SpectatorScopeZoomStatus status) { }

}

