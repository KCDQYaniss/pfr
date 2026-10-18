namespace EFT;

public sealed class BoundingFrustum
{
	internal struct CullingBox
	{
		public Vector3 BoxCenter; //Field offset: 0x0
		public Vector3 BoxExtents; //Field offset: 0xC
		public bool IsInFrustum; //Field offset: 0x18

	}

	internal struct CullingSphere
	{
		public Vector3 SphereCenter; //Field offset: 0x0
		public float SphereRadius; //Field offset: 0xC
		public bool IsInFrustum; //Field offset: 0x10

	}

	internal enum IntersectionType
	{
		Disjoint = 0,
		Intersects = 1,
		Contains = 2,
	}

	public const int PlaneCount = 6; //Field offset: 0x0
	public const int CornerCount = 8; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; //Field offset: 0x10
	private Vector3[] _corners; //Field offset: 0x20
	private Plane[] _planes; //Field offset: 0x28
	private Vector3[] _absNormals; //Field offset: 0x30
	private Vector3[] _planeNormal; //Field offset: 0x38
	private float[] _planeDistance; //Field offset: 0x40

	public private Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public BoundingFrustum() { }

	private void calculateFrustumCornersOrthographic(Camera camera) { }

	private void calculateFrustumCornersOrthographicEx(Vector3 position, Quaternion orientation, float farClipPlane, float nearClipPlane, float orthographicSize, float aspect) { }

	private void calculateFrustumCornersPerspective(ref Vector3 position, ref Quaternion orientation, float fov, float nearClipPlane, float farClipPlane, float aspect) { }

	public bool Contains(ref Vector3 point) { }

	public void CopyTo(BoundingFrustum other) { }

	public void CullBoxes(CullingBox[] boxes, int boxCount) { }

	public void CullSpheres(CullingSphere[] spheres, int sphereCount) { }

	[CompilerGenerated]
	public Vector3 get_Position() { }

	public IntersectionType GetBoxIntersection(ref Bounds box, float frustumPadding = 0) { }

	public void GetCorners(Vector3[] outCorners) { }

	public float GetNearHeight() { }

	public IntersectionType GetOrientedBoxIntersection(ref Bounds box, ref Vector3 right, ref Vector3 up, ref Vector3 forward, float frustumPadding = 0) { }

	public void GetPlanes(Plane[] outPlanes) { }

	public IntersectionType GetSphereIntersection(ref Vector3 center, float radius, float frustumPadding = 0) { }

	public IntersectionType GetSphereIntersection(ref BoundingSphere sphere, float frustumPadding = 0) { }

	public bool IntersectsBox(ref Bounds box, float frustumPadding = 0) { }

	public bool IntersectsOrientedBox(ref Bounds box, ref Vector3 right, ref Vector3 up, ref Vector3 forward, float frustumPadding = 0) { }

	public bool IntersectsSphere(ref Vector3 center, float radius, float frustumPadding = 0) { }

	public bool IntersectsSphere(ref BoundingSphere sphere, float frustumPadding = 0) { }

	[CompilerGenerated]
	private void set_Position(Vector3 value) { }

	public void Update(Camera camera) { }

	public void Update(Camera camera, float farClipPlane) { }

	public void Update(Vector3 position, Quaternion orientation, float fov, float nearClipPlane, float farClipPlane, float aspect) { }

	public void UpdateEx(Vector3 position, Quaternion orientation, bool orthographic, float farClipPlane, float nearClipPlane, float fieldOfView, float aspect, float orthographicSize) { }

}

