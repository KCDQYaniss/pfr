namespace Audio.SpatialSystem;

[IsReadOnly]
public struct SourceBoundsCache
{
	public readonly Vector3 center; //Field offset: 0x0
	private readonly Vector3 _min; //Field offset: 0xC
	private readonly Vector3 _max; //Field offset: 0x18
	private readonly Vector3 _size; //Field offset: 0x24

	public SourceBoundsCache(Bounds bounds) { }

	public bool IntersectsOBB(in AudioRoomAreaColliderCache cache) { }

	public Bounds ToBounds() { }

}

