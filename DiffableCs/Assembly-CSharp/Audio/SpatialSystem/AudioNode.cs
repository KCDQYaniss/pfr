namespace Audio.SpatialSystem;

[IsReadOnly]
public struct AudioNode
{
	internal enum ENodeType
	{
		Emitter = 0,
		Portal = 1,
		Listener = 2,
	}

	public readonly ENodeType Type; //Field offset: 0x0
	public readonly float3 Position; //Field offset: 0x4
	public readonly float PortalClosureLevel; //Field offset: 0x10
	public readonly float PortalTraversalMaxCost; //Field offset: 0x14
	public readonly float PortalDepth; //Field offset: 0x18
	public readonly float FrontRoomWallOcclusion; //Field offset: 0x1C
	public readonly float BackRoomWallOcclusion; //Field offset: 0x20
	public readonly bool IsFrontRoomOutdoor; //Field offset: 0x24
	public readonly bool IsBackRoomOutdoor; //Field offset: 0x25

	public AudioNode(ENodeType type, float3 position, float portalClosureLevel = 0, float portalTraversalMaxCost = 0, float portalDepth = 0, float frontRoomWallOcclusion = 1, float backRoomWallOcclusion = 1, bool isFrontRoomOutdoor = false, bool isBackRoomOutdoor = false) { }

	public AudioNode Clone() { }

}

