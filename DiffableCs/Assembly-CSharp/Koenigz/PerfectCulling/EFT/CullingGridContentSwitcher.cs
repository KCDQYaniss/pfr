namespace Koenigz.PerfectCulling.EFT;

public sealed class CullingGridContentSwitcher : IDisposable
{
	private struct DynamicVisibilityUpdateJob : IJobParallelFor
	{

		public override void Execute(int index) { }

	}

	private struct StaticVisibilityQueueUpdateJob : IJob
	{

		public override void Execute() { }

	}

	private struct StaticVisibilityTestJob : IJobParallelFor
	{

		public override void Execute(int index) { }

	}

	[CompilerGenerated]
	private static CullingGridContentSwitcher <Instance>k__BackingField; //Field offset: 0x0
	public const float FRAME_SWITCH_AMOUNT_FACTOR = 0.1; //Field offset: 0x0
	public const int SWITCH_COUNT_PER_FRAME = 150; //Field offset: 0x0
	private static List _staticObjects; //Field offset: 0x8
	private static BitArray _staticObjectVisibility; //Field offset: 0x10
	private static Stack _staticSwitchQueueActivate; //Field offset: 0x18
	private static Stack _staticSwitchQueueDeactivate; //Field offset: 0x20
	private static List _dynamicObjects; //Field offset: 0x28
	private static List _dynamicObjectsToAdd; //Field offset: 0x30
	private static List _dynamicObjectsToRemove; //Field offset: 0x38
	private static CullingGridVisibilityQueryResult _lastCameraQuery; //Field offset: 0x40
	private static int _numDynamicVisibleLastFrame; //Field offset: 0x60
	private static int _lastCullingCellId; //Field offset: 0x64
	private static bool _cullDynamicObjects; //Field offset: 0x68
	private JobHandle _dynamicVisibilityUpdateJobHandle; //Field offset: 0x10
	private JobHandle _staticVisibilityJobUpdateHandle; //Field offset: 0x20
	private CullingGridVisibilitySampler _sampler; //Field offset: 0x30
	private PerfectCullingCamera _cullingCamera; //Field offset: 0x38

	public private static CullingGridContentSwitcher Instance
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 167
	}

	public static CullingGridVisibilityQueryResult LastQuery
	{
		 get { } //Length: 104
	}

	public static int NumDynamicObjects
	{
		 get { } //Length: 114
	}

	public static int NumDynamicVisibleLastFrame
	{
		 get { } //Length: 83
	}

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"activate", "deactivate"})]
	public static ValueTuple SwitchQueueSizes
	{
		 get { } //Length: 153
	}

	private static CullingGridContentSwitcher() { }

	public CullingGridContentSwitcher(CullingGridVisibilitySampler sampler, PerfectCullingCamera cullingCamera) { }

	public static void AddDynamic(IAutocullAutomated obj) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public static CullingGridContentSwitcher get_Instance() { }

	public static CullingGridVisibilityQueryResult get_LastQuery() { }

	public static int get_NumDynamicObjects() { }

	public static int get_NumDynamicVisibleLastFrame() { }

	public static ValueTuple get_SwitchQueueSizes() { }

	private List GetAllStaticContent() { }

	private AutocullLODGroupCell[] GetAutocullLODGroupCells() { }

	public void LateUpdate() { }

	private void PrepareStaticContent() { }

	public static void RemoveDynamic(IAutocullAutomated obj) { }

	private void ScheduleDynamicVisibilityUpdate() { }

	[CompilerGenerated]
	private static void set_Instance(CullingGridContentSwitcher value) { }

	public static void SetCullDynamicObjects(bool flag) { }

	public void Update() { }

	private static void UpdateDynamicObjects(CullingGridVisibilityQueryResult query) { }

	private void UpdateStaticObjects() { }

	private void UpdateStaticObjectsSwitchQueue() { }

}

