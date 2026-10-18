//Type is in global namespace

public class ObservedCullingManager : MonoBehaviour
{
	private struct CullingItem
	{
		public BoundingSphere Sphere; //Field offset: 0x0
		public CullingObjectData Data; //Field offset: 0x10

	}

	private struct ObservedCullingJob : IJob
	{
		public static readonly CullingJobParameters JobParameters; //Field offset: 0x0
		public static ObservedCullingManager Instance; //Field offset: 0x8

		private static ObservedCullingJob() { }

		public override void Execute() { }

	}

	private Camera _currentPlayerCamera; //Field offset: 0x20
	private IndexedList _spheres; //Field offset: 0x28
	private JobHandle _cullingJob; //Field offset: 0x30
	private List _observedCullingObjects; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsUsingGrid>k__BackingField; //Field offset: 0x48

	public private bool IsUsingGrid
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ObservedCullingManager() { }

	private void ApplyCulling() { }

	private void Awake() { }

	private void ChangeCullingCamera(Camera cam) { }

	private void FinishCullingJob() { }

	[CompilerGenerated]
	public bool get_IsUsingGrid() { }

	private void OnCheckCamRegistered(Camera cam) { }

	private void OnCullingGridCreated() { }

	private void OnDestroy() { }

	public int Register(ObservedCullingObject o) { }

	private void ScheduleCullingJob() { }

	[CompilerGenerated]
	private void set_IsUsingGrid(bool value) { }

	private void SyncShapes() { }

	public void Unregister(ObservedCullingObject o) { }

	private void Update() { }

	public void UpdateSphere(ICullable o) { }

	public void UpdateSphere(ICullable o, int index) { }

}

