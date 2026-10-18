//Type is in global namespace

public class ScopePrefabCache : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__32_0; //Field offset: 0x8
		public static Func <>9__32_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Awake>b__32_0(ScopeModeInfo sm) { }

		internal bool <Awake>b__32_1(ScopeModeInfo sm) { }

	}

	internal struct DistaneAngle
	{
		public float Distance; //Field offset: 0x0
		public float Angle; //Field offset: 0x4

	}

	internal class ScopeModeInfo
	{
		public GameObject ModeGameObject; //Field offset: 0x10
		public CollimatorSight CollimatorSight; //Field offset: 0x18
		public OpticSight OpticSight; //Field offset: 0x20
		public bool IgnoreOpticsForCameraPlane; //Field offset: 0x28

		public ScopeModeInfo() { }

	}

	private const string MODE_TRANSFORM_NAME = "mode_"; //Field offset: 0x0
	[SerializeField]
	public bool CanChangeAngleByDistance; //Field offset: 0x20
	[SerializeField]
	public Transform WeaponScopeAxis; //Field offset: 0x28
	[SerializeField]
	public DistaneAngle[] AngleByRange; //Field offset: 0x30
	[SerializeField]
	private ScopeModeInfo[] _scopeModeInfos; //Field offset: 0x38
	private int _currentModeId; //Field offset: 0x40
	[CompilerGenerated]
	private bool <HasOptics>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <HasCollimators>k__BackingField; //Field offset: 0x45

	public int CurrentModeId
	{
		 get { } //Length: 4
	}

	public bool CurrentModHasOptics
	{
		 get { } //Length: 254
	}

	public bool CurrentModIgnoreOpticsForCameraPlane
	{
		 get { } //Length: 52
	}

	public OpticSight CurrentModOpticSight
	{
		 get { } //Length: 52
	}

	public CollimatorSight FirstCollimator
	{
		 get { } //Length: 388
	}

	public OpticSight FirstOptic
	{
		 get { } //Length: 388
	}

	public private bool HasCollimators
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool HasOptics
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int ModesCount
	{
		 get { } //Length: 26
	}

	public ScopePrefabCache() { }

	private void Awake() { }

	public int get_CurrentModeId() { }

	public bool get_CurrentModHasOptics() { }

	public bool get_CurrentModIgnoreOpticsForCameraPlane() { }

	public OpticSight get_CurrentModOpticSight() { }

	public CollimatorSight get_FirstCollimator() { }

	public OpticSight get_FirstOptic() { }

	[CompilerGenerated]
	public bool get_HasCollimators() { }

	[CompilerGenerated]
	public bool get_HasOptics() { }

	public int get_ModesCount() { }

	public float GetAnyOpticsDistanceToCamera() { }

	public Vector3 GetCollimatorWorldCameraPosition(Vector3 localCameraTarget) { }

	public Transform GetLensCenter() { }

	public Vector3 GetLensTransformForward() { }

	public Vector3 GetLocalCollimatorCameraTarget(Vector3 worldCameraTarget) { }

	public Vector3 GetLocalOpticCameraTarget(Vector3 worldCameraTarget) { }

	[CanBeNull]
	public OpticSight GetOpticSight(int index) { }

	public Vector3 GetOpticsWorldCameraPosition(Vector3 localCameraTarget) { }

	public ScopeModeInfo GetScopeModeInfo(int index) { }

	private bool HasAngleForDistance(float distance, out float angle) { }

	public bool IsOpticBone(Transform bone) { }

	public void LookAt(Vector3 point, Vector3 worldUp) { }

	public void LookAtCollimatorOnly(Vector3 point, Vector3 worldUp) { }

	public void RotateToAngleByDistance(float distance) { }

	[CompilerGenerated]
	private void set_HasCollimators(bool value) { }

	[CompilerGenerated]
	private void set_HasOptics(bool value) { }

	public void SetMode(int modeId) { }

}

