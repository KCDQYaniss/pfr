//Type is in global namespace

public class AIGrenadeThrowPlace : AIPlaceInfoLogic, IAIDataGrenedaThrowPlace
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__38_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal <>f__AnonymousType2 <EditorCheck>b__38_2(<>f__AnonymousType1 s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public AIGrenadeThrowPlace <>4__this; //Field offset: 0x10
		public AIPlaceInfo aIPlace; //Field offset: 0x18
		public Vector3 center; //Field offset: 0x20
		public List list; //Field offset: 0x30
		public List additionalThrowPositions; //Field offset: 0x38
		public int countRt; //Field offset: 0x40

		public <>c__DisplayClass38_0() { }

		internal <>f__AnonymousType1 <EditorCheck>b__1(<>f__AnonymousType0 s) { }

		internal float <EditorCheck>b__3(<>f__AnonymousType2 s) { }

		internal void <EditorCheck>g__RunRadiusRingCardinalPass|4(ref <>c__DisplayClass38_1 unnamed_param_0) { }

		internal void <EditorCheck>g__RunRadiusRingRandomPass|5(ref <>c__DisplayClass38_1 unnamed_param_0) { }

		internal bool <EditorCheck>g__TryFindPlace|0(Vector3 vector3) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass38_1
	{
		public float ringMin; //Field offset: 0x0
		public float ringMax; //Field offset: 0x4
		public Vector3[] cardinalDirs; //Field offset: 0x8
		public Transform placeTf; //Field offset: 0x10

	}

	[IsReadOnly]
	private struct TryFindPlaceDebugSample
	{
		public readonly Vector3 Position; //Field offset: 0x0
		public readonly GrenadeTryFindPlaceDebugOutcome Outcome; //Field offset: 0xC

		public TryFindPlaceDebugSample(Vector3 position, GrenadeTryFindPlaceDebugOutcome outcome) { }

	}

	private const float DebugTryFindPlaceSphereRadius = 0.12; //Field offset: 0x0
	private const float MAX_POINTS = 7; //Field offset: 0x0
	private const float MIN_THROW_DIST = 3; //Field offset: 0x0
	private const float MIN2_THROW_DIST = 5; //Field offset: 0x0
	private const float ThrowFromHeightOffset = 1.4; //Field offset: 0x0
	private static List _baseVectors; //Field offset: 0x0
	public Transform CenterThrowPlace; //Field offset: 0x20
	[SerializeField]
	private float OffsetCoefMin; //Field offset: 0x28
	[SerializeField]
	private float OffsetCoefMax; //Field offset: 0x2C
	[SerializeField]
	private bool _isActive; //Field offset: 0x30
	[SerializeField]
	private bool _addNoCenterThrow; //Field offset: 0x31
	[SerializeField]
	private bool _tryFindPlaceByCircle; //Field offset: 0x32
	[SerializeField]
	private bool _tryFindPlaceByRadiusRing; //Field offset: 0x33
	[SerializeField]
	private bool _radiusRingCardinalDirectionsFirst; //Field offset: 0x34
	[SerializeField]
	private float _throwRingRadiusMin; //Field offset: 0x38
	[SerializeField]
	private float _throwRingRadiusMax; //Field offset: 0x3C
	[SerializeField]
	private bool _tryFindPlaceByPerimiter; //Field offset: 0x40
	[SerializeField]
	private Vector3 NavMeshSampleOffset; //Field offset: 0x44
	[SerializeField]
	private bool _perimeterOnlyFarSide; //Field offset: 0x50
	[SerializeField]
	private float _perimeterOffsetInner; //Field offset: 0x54
	[SerializeField]
	private bool _drawAllDebug; //Field offset: 0x58
	[SerializeField]
	private bool _debugTryFindPlaceSpheres; //Field offset: 0x59
	[SerializeField]
	private bool _skipPointInOabbCheck; //Field offset: 0x5A
	private float _nextCanThrowPeriod; //Field offset: 0x5C
	private List _debugCheckedPoints; //Field offset: 0x60
	private List _debugTryFindPlaceSamples; //Field offset: 0x68
	[SerializeField]
	private List pointToThrowA; //Field offset: 0x70

	public override AIGreandeAng AIGreandeAng
	{
		 get { } //Length: 6
	}

	public override bool IsActive
	{
		 get { } //Length: 5
	}

	public override string Name
	{
		 get { } //Length: 98
	}

	public override List PointToThrowA
	{
		 get { } //Length: 5
	}

	private static AIGrenadeThrowPlace() { }

	public AIGrenadeThrowPlace() { }

	public override bool CanThrowTo() { }

	private List CheckListOnPossibleDestinations(List list) { }

	private static void DrawGizmoCircleXZ(Vector3 center, float radius, int segments) { }

	public virtual void EditorCheck(AIPlaceInfo aIPlace) { }

	public override AIGreandeAng get_AIGreandeAng() { }

	public override bool get_IsActive() { }

	public override string get_Name() { }

	public override List get_PointToThrowA() { }

	private static Vector3[] GetRadiusRingCardinalWorldDirsXZ(Transform placeTransform) { }

	private Transform GetRadiusRingOrientationTransform() { }

	private Vector3 GetThrowCenterForGizmo() { }

	private static Color GetTryFindPlaceDebugColor(GrenadeTryFindPlaceDebugOutcome outcome) { }

	public virtual void Init(AIPlaceInfo aiPlaceInfo, BotsController botsController) { }

	private void OnDrawGizmosSelected() { }

	public override void SetStartThrow() { }

}

