namespace Koenigz.PerfectCulling.EFT;

public struct OrientedBounds : IBinarySerializable
{
	public Bounds bounds; //Field offset: 0x0
	public Quaternion rotation; //Field offset: 0x18

	public Bounds AABB
	{
		 get { } //Length: 1909
	}

	public Vector3 ClosestPointOriented(Vector3 p, out bool isPointInside) { }

	public bool Contains(Vector3 worldPosition) { }

	public float Distance(Vector3 point) { }

	public Bounds get_AABB() { }

	public bool IntersectFrustum(Plane[] frustumPlanes) { }

	public bool IntersectRay(Ray ray, out float distance) { }

	public override void Read(BinaryReader reader) { }

	public float SqrDistance(Vector3 point) { }

	public virtual string ToString() { }

	public override void Write(BinaryWriter writer) { }

}

