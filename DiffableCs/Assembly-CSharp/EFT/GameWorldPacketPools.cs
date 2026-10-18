namespace EFT;

public static class GameWorldPacketPools
{
	public static ListPool LootSyncPacketsPool; //Field offset: 0x0
	public static ListPool CorpseSyncPacketsPool; //Field offset: 0x8
	public static ListPool GrenadeSyncPacketsPool; //Field offset: 0x10
	public static ListPool ArtilleryShellSyncPacketPool; //Field offset: 0x18
	public static ListPool PlatformSyncPacketsPool; //Field offset: 0x20
	public static ListPool BorderZonePacketsPool; //Field offset: 0x28
	public static ListPool SynchronizableObjectPacketsPool; //Field offset: 0x30
	public static ListPool VolumeSpawnPacketsPool; //Field offset: 0x38
	public static ListPool VolumeDeltaPacketsPool; //Field offset: 0x40
	public static ListPool VolumeRemovePacketsPool; //Field offset: 0x48

	private static GameWorldPacketPools() { }

}

