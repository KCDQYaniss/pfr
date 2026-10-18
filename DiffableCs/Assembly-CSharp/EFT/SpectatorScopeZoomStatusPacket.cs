namespace EFT;

public struct SpectatorScopeZoomStatusPacket
{
	public bool HasStatus; //Field offset: 0x0
	public SpectatorScopeZoomStatus[] Statuses; //Field offset: 0x8

	public static void Serialize(IBitStream stream, ref SpectatorScopeZoomStatusPacket packet) { }

}

