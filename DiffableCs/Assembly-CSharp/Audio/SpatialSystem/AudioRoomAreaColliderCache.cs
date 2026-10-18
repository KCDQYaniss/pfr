namespace Audio.SpatialSystem;

public struct AudioRoomAreaColliderCache
{
	public Vector3 worldCenter; //Field offset: 0x0
	public Quaternion inverseRotation; //Field offset: 0xC
	public Vector3 halfSize; //Field offset: 0x1C

	[IsReadOnly]
	public bool ContainsPoint(Vector3 worldPoint) { }

}

