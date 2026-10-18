namespace Cinemachine;

internal class ConfinerOven
{
	[IsReadOnly]
	private struct AspectStretcher
	{
		[CompilerGenerated]
		private readonly float <Aspect>k__BackingField; //Field offset: 0x0
		private readonly float m_InverseAspect; //Field offset: 0x4
		private readonly float m_CenterX; //Field offset: 0x8

		public float Aspect
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public AspectStretcher(float aspect, float centerX) { }

		[CompilerGenerated]
		public float get_Aspect() { }

		public Vector2 Stretch(Vector2 p) { }

		public Vector2 Unstretch(Vector2 p) { }

	}

	internal class BakedSolution
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			public IntPoint point; //Field offset: 0x10

			public <>c__DisplayClass9_0() { }

			internal bool <ConfinePoint>b__4(List t) { }

		}

		private const double k_ClipperEpsilon = 1000; //Field offset: 0x0
		private float m_FrustumSizeIntSpace; //Field offset: 0x10
		private readonly AspectStretcher m_AspectStretcher; //Field offset: 0x14
		private readonly bool m_HasBones; //Field offset: 0x20
		private readonly double m_SqrPolygonDiagonal; //Field offset: 0x28
		private List m_OriginalPolygon; //Field offset: 0x30
		private List m_Solution; //Field offset: 0x38

		public BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, Rect polygonBounds, List originalPolygon, List solution) { }

		[CompilerGenerated]
		internal static float <ConfinePoint>g__ClosestPointOnSegment|9_2(IntPoint point, IntPoint s0, IntPoint s1) { }

		[CompilerGenerated]
		private bool <ConfinePoint>g__DoesIntersectOriginal|9_3(IntPoint l1, IntPoint l2) { }

		[CompilerGenerated]
		internal static IntPoint <ConfinePoint>g__IntPointLerp|9_0(IntPoint a, IntPoint b, float lerp) { }

		[CompilerGenerated]
		private bool <ConfinePoint>g__IsInsideOriginal|9_1(IntPoint point) { }

		[CompilerGenerated]
		internal static double <FindIntersection>g__IntPointDiffSqrMagnitude|10_0(IntPoint point1, IntPoint point2) { }

		public Vector2 ConfinePoint(in Vector2 pointToConfine) { }

		private static int FindIntersection(in IntPoint p1, in IntPoint p2, in IntPoint p3, in IntPoint p4) { }

		public bool IsValid() { }

	}

	internal enum BakingState
	{
		BAKING = 0,
		BAKED = 1,
		TIMEOUT = 2,
	}

	private struct BakingStateCache
	{
		public ClipperOffset offsetter; //Field offset: 0x0
		public List solutions; //Field offset: 0x8
		public PolygonSolution rightCandidate; //Field offset: 0x10
		public PolygonSolution leftCandidate; //Field offset: 0x20
		public List maxCandidate; //Field offset: 0x30
		public float stepSize; //Field offset: 0x38
		public float maxFrustumHeight; //Field offset: 0x3C
		public float userSetMaxFrustumHeight; //Field offset: 0x40
		public float theoriticalMaxFrustumHeight; //Field offset: 0x44
		public float currentFrustumHeight; //Field offset: 0x48
		public float bakeTime; //Field offset: 0x4C

	}

	private struct PolygonSolution
	{
		public List polygons; //Field offset: 0x0
		public float frustumHeight; //Field offset: 0x8

		public bool IsNull
		{
			 get { } //Length: 8
		}

		public bool get_IsNull() { }

		public bool StateChanged(in List paths) { }

	}

	private const long k_FloatToIntScaler = 100000; //Field offset: 0x0
	private const float k_IntToFloatScaler = 1E-05; //Field offset: 0x0
	private const float k_MinStepSize = 0.0005; //Field offset: 0x0
	private float m_MinFrustumHeightWithBones; //Field offset: 0x10
	private float m_SkeletonPadding; //Field offset: 0x14
	private List m_OriginalPolygon; //Field offset: 0x18
	private IntPoint m_MidPoint; //Field offset: 0x20
	private List m_Skeleton; //Field offset: 0x30
	private Rect m_PolygonRect; //Field offset: 0x38
	private AspectStretcher m_AspectStretcher; //Field offset: 0x48
	private float m_MaxComputationTimeForFullSkeletonBakeInSeconds; //Field offset: 0x54
	[CompilerGenerated]
	private BakingState <State>k__BackingField; //Field offset: 0x58
	public float bakeProgress; //Field offset: 0x5C
	private BakingStateCache m_Cache; //Field offset: 0x60

	public private BakingState State
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ConfinerOven(in List inputPath, in float aspectRatio, float maxFrustumHeight, float skeletonPadding) { }

	[CompilerGenerated]
	private void <BakeConfiner>g__ComputeSkeleton|25_0(in List solutions) { }

	[CompilerGenerated]
	internal static Rect <Initialize>g__GetPolygonBoundingBox|24_0(in List polygons) { }

	[CompilerGenerated]
	internal static IntPoint <Initialize>g__MidPointOfIntRect|24_1(IntRect bounds) { }

	public void BakeConfiner(float maxComputationTimePerFrameInSeconds) { }

	[CompilerGenerated]
	public BakingState get_State() { }

	public BakedSolution GetBakedSolution(float frustumHeight) { }

	private void Initialize(in List inputPath, in float aspectRatio, float maxFrustumHeight, float skeletonPadding) { }

	[CompilerGenerated]
	private void set_State(BakingState value) { }

}

