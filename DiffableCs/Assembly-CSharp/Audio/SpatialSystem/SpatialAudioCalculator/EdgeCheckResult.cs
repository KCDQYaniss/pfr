namespace Audio.SpatialSystem.SpatialAudioCalculator;

public struct EdgeCheckResult
{
	public bool needsEdgeSearch; //Field offset: 0x0
	public float3 sourceHitPoint; //Field offset: 0x4
	public float3 listenerHitPoint; //Field offset: 0x10
	public float3 sourceHitNormal; //Field offset: 0x1C
	public float3 listenerHitNormal; //Field offset: 0x28
	public int sourceHitColliderId; //Field offset: 0x34
	public int listenerHitColliderId; //Field offset: 0x38
	public float sourceToHitDist; //Field offset: 0x3C
	public float listenerToHitDist; //Field offset: 0x40
	public float3 dirSl; //Field offset: 0x44
	public float3 dirLs; //Field offset: 0x50
	public float directDistance; //Field offset: 0x5C

}

