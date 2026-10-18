namespace EFT;

public sealed class BotsSmokesVisionSystem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_1; //Field offset: 0x8
		public static Func <>9__12_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <OnGrenadeEmissionEnd>b__12_0(GrenadeData data) { }

		internal int <TryAddGrenade>b__11_1(GrenadeData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <TryAddGrenade>b__0(GrenadeData data) { }

	}

	private sealed class GrenadeData : IEquatable
	{
		public readonly int Id; //Field offset: 0x10
		public float WorldRadius; //Field offset: 0x14
		public float WorldRadiusSqr; //Field offset: 0x18
		public Vector3 WorldPosition; //Field offset: 0x1C

		public GrenadeData(int id, Vector3 worldPosition) { }

		public override bool Equals(GrenadeData other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	private const float UPDATE_INTERVAL = 1; //Field offset: 0x0
	private readonly BotsList _botsList; //Field offset: 0x10
	private readonly AICoversData _coversData; //Field offset: 0x18
	private readonly List _activeSmokes; //Field offset: 0x20
	private readonly Dictionary _affectedVoxelsMap; //Field offset: 0x28
	private readonly Dictionary _botsInSmokes; //Field offset: 0x30
	private readonly List _smokeGrenadesAlongRayBuffer; //Field offset: 0x38
	private readonly Vector3[] _boundsExtendsBuffer; //Field offset: 0x40
	private float _nextUpdateTime; //Field offset: 0x48

	public BotsSmokesVisionSystem(BotsList botsList, AICoversData coversData) { }

	private void AddGrenadeToVoxel(GrenadeData grenadeData, Vector3Int affectedVoxelIdx) { }

	private static bool DoesSegmentIntersectSphere(Vector3 segmentStart, Vector3 segmentEnd, Vector3 sphereCenter, float sphereRadiusSqr, out Vector3 hitPoint) { }

	private Vector3[] GetSixFaceCentersNonAlloc(Bounds bounds) { }

	private List GetSmokeGrenadesAlongRayNonAlloc(Vector3 from, Vector3 to) { }

	public bool IsRayIntersectAnySmoke(Vector3 from, Vector3 to, out SphereCollider hitCollider, out Vector3 intersectionPoint, out int grenadesAlongWayCount) { }

	private void OnGrenadeEmissionEnd(Grenade obj) { }

	public void TryAddGrenade(int id, Vector3 position) { }

	public void Update() { }

	private void UpdateAffectedVoxels(GrenadeData grenadeData, Bounds bounds) { }

	private void UpdateBotsInsideSmokes(GrenadeData grenadeData) { }

}

