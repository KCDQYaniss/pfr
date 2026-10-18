namespace EFT.NetworkPackets.Serialization;

[Extension]
public static class LauncherReloadInfoSerializationExtensions
{
	private const int MAX_AMMO_IDS = 15; //Field offset: 0x0

	[Extension]
	public static void Serialize(IBitStream writer, ref LauncherReloadInfo info) { }

}

