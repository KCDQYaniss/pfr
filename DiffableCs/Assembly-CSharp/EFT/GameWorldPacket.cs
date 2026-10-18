namespace EFT;

public struct GameWorldPacket : IDisposable
{
	[CompilerGenerated]
	private int <PriorityCounter>k__BackingField; //Field offset: 0x0
	public float RemoteTime; //Field offset: 0x4
	public Nullable InteractiveObjectsStatusPacket; //Field offset: 0x8
	public Nullable UpdateExfiltrationPointPacket; //Field offset: 0x20
	public Nullable LampChangeStatePacket; //Field offset: 0x50
	public Nullable WindowHitPacket; //Field offset: 0x68
	public List LootSyncPackets; //Field offset: 0x88
	public List CorpseSyncPackets; //Field offset: 0x90
	public List GrenadeSyncPackets; //Field offset: 0x98
	public List ArtilleryShellSyncPackets; //Field offset: 0xA0
	public List PlatformSyncPackets; //Field offset: 0xA8
	public List BorderZonePackets; //Field offset: 0xB0
	public List SynchronizableObjectPackets; //Field offset: 0xB8
	public List VolumetricSystemSpawnPackets; //Field offset: 0xC0
	public List VolumetricSystemDeltaPackets; //Field offset: 0xC8
	public List VolumetricSystemRemovePackets; //Field offset: 0xD0

	public bool HasData
	{
		 get { } //Length: 535
	}

	public int PriorityCounter
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	public GameWorldPacket Clone() { }

	public static GameWorldPacket Create() { }

	public override void Dispose() { }

	public bool get_HasData() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_PriorityCounter() { }

	[CompilerGenerated]
	public void set_PriorityCounter(int value) { }

}

