//Type is in global namespace

[ExecuteInEditMode]
public class CullingManager : MonoBehaviour
{
	private struct CullingJob : IJob
	{
		public static readonly Dictionary JobParameters; //Field offset: 0x0
		public int JobId; //Field offset: 0x0

		private static CullingJob() { }

		private void Execute(CullingJobParameters parameters) { }

		public override void Execute() { }

	}

	internal sealed class CullingJobParameters
	{
		public BoundingFrustum CameraFrustrum; //Field offset: 0x10
		public Camera CameraInstance; //Field offset: 0x18
		public bool IsCameraEnabled; //Field offset: 0x20
		public Vector3 CameraPosition; //Field offset: 0x24
		public bool IsOpticCamera; //Field offset: 0x30
		public float FovMultiplicator; //Field offset: 0x34

		public CullingJobParameters() { }

		public void Clear() { }

		public bool UpdateParameters() { }

	}

	internal struct CullingObjectData
	{
		public ICullable CullingObject; //Field offset: 0x0
		public float CullingDistanceSqr; //Field offset: 0x8
		public VisibilityData VisibilityData; //Field offset: 0xC
		public bool JobVisibilityFlag; //Field offset: 0x18

		public void Reset() { }

		public virtual string ToString() { }

	}

	internal struct VisibilityData
	{
		public bool InOpticFructum; //Field offset: 0x0
		public bool InFpsFrustum; //Field offset: 0x1
		public bool IsCulledByDistance; //Field offset: 0x2
		public float CurrentCameraDistanceSqr; //Field offset: 0x4
		public bool IsAimingOn; //Field offset: 0x8
		public bool CullingByDistanceOnly; //Field offset: 0x9

		public bool IsObjectVisible() { }

		public void Reset() { }

		public virtual string ToString() { }

	}

	private static CullingManager _instance; //Field offset: 0x0
	private const int MaxCulledObjectCount = 10000; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnInstanceCreated; //Field offset: 0x8
	[CompilerGenerated]
	private static Action OnInstanceDestroyed; //Field offset: 0x10
	private static readonly List _earlyObjects; //Field offset: 0x18
	[SerializeField]
	private Camera _debugCamera; //Field offset: 0x20
	private int _spheresUsed; //Field offset: 0x28
	private readonly Dictionary _cameras; //Field offset: 0x30
	private readonly Queue _freeIndices; //Field offset: 0x38
	private readonly BoundingSphere[] _spheres; //Field offset: 0x40
	private readonly List _activeSpheresIndices; //Field offset: 0x48
	private readonly CullingObjectData[] _objectsData; //Field offset: 0x50
	private Camera _lastOpticCam; //Field offset: 0x58
	private bool _lockState; //Field offset: 0x60
	private List _cullingJobs; //Field offset: 0x68

	public static event Action OnInstanceCreated
	{
		[CompilerGenerated]
		 add { } //Length: 335
		[CompilerGenerated]
		 remove { } //Length: 335
	}

	public static event Action OnInstanceDestroyed
	{
		[CompilerGenerated]
		 add { } //Length: 335
		[CompilerGenerated]
		 remove { } //Length: 335
	}

	public static CullingManager Instance
	{
		 get { } //Length: 83
		 set { } //Length: 446
	}

	private static CullingManager() { }

	public CullingManager() { }

	[CompilerGenerated]
	public static void add_OnInstanceCreated(Action value) { }

	[CompilerGenerated]
	public static void add_OnInstanceDestroyed(Action value) { }

	private void AddCameraForCullingJob(Camera cam) { }

	public static void AddEarlyObject(ICullable cullableObject) { }

	private void AddEarlyObjectsToCullingObjects() { }

	private void Awake() { }

	private void CameraRender(Camera cam) { }

	private void ClearAllData() { }

	private void ClearCamData() { }

	private void ClearCullingJobData() { }

	private void FinishCullingJob() { }

	public void ForceEnable(bool enable) { }

	public static CullingManager get_Instance() { }

	public float GetCameraDistanceSqr(int index) { }

	private void Init() { }

	private void InitializeCullingJob() { }

	public bool IsOpticEnabled() { }

	public void LockState(bool lockState) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public int Register(ICullable cullableObject) { }

	public void Reload() { }

	[CompilerGenerated]
	public static void remove_OnInstanceCreated(Action value) { }

	[CompilerGenerated]
	public static void remove_OnInstanceDestroyed(Action value) { }

	public static void RemoveEarlyObject(ICullable cullableObject) { }

	private void ScheduleCullingJobs() { }

	public static void set_Instance(CullingManager value) { }

	public void Unregister(ICullable o) { }

	private void Update() { }

	private void UpdateCulledInfo(Camera cam, CullingGroup cullingGroup, bool isOpticCam) { }

	private void UpdateCullingJobVisibilityPlaymode() { }

	private void UpdateCullingSettings(ICullable cullableObject, int index) { }

	public void UpdateSphere(ICullable cullingObject, int index) { }

	public void UpdateSphere(ICullable cullingObject) { }

}

