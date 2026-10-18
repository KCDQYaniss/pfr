namespace EFT.Water;

[ScriptOrder(19000)]
public class WaterRenderer : MonoBehaviour
{
	private const float DYNAMIC_UPDATE_AFTER_RAID_START = 7; //Field offset: 0x0
	private const float TIMER_DISABLED = -1; //Field offset: 0x0
	[CompilerGenerated]
	private static WaterRenderer <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <SnowMaskState>k__BackingField; //Field offset: 0x8
	private readonly CommandBufferManager _cmdReflections; //Field offset: 0x20
	private readonly CommandBufferManager _cmdForwardAlpha; //Field offset: 0x28
	private readonly List _drawingResults; //Field offset: 0x30
	private readonly List _containers; //Field offset: 0x38
	private readonly Dictionary _cameraVersions; //Field offset: 0x40
	private readonly WaterHashTracker _hashTracker; //Field offset: 0x48
	private WaterDrawer _waterDrawer; //Field offset: 0x50
	private bool _dynamicUpdate; //Field offset: 0x58
	private bool _isInitialized; //Field offset: 0x59
	private bool _skipNextPreRender; //Field offset: 0x5A
	private bool _drawingResultsDirty; //Field offset: 0x5B
	private float _timer; //Field offset: 0x5C
	[SerializeField]
	private WaterProperties _waterProperties; //Field offset: 0x60

	public List Containers
	{
		 get { } //Length: 5
	}

	public WaterHashTracker HashTracker
	{
		 get { } //Length: 5
	}

	public private static WaterRenderer Instance
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public bool IsInitialized
	{
		 get { } //Length: 5
	}

	public WaterProperties Properties
	{
		 get { } //Length: 5
	}

	public private static bool SnowMaskState
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 65
	}

	public WaterDrawer WaterDrawer
	{
		 get { } //Length: 5
	}

	public WaterRenderer() { }

	private void Add(WaterContainer water) { }

	private void Awake() { }

	private bool CanBeRender(Camera camera) { }

	public static void DisableSnowMask(bool state) { }

	public void EnsureDrawingResults() { }

	public List get_Containers() { }

	public WaterHashTracker get_HashTracker() { }

	[CompilerGenerated]
	public static WaterRenderer get_Instance() { }

	public bool get_IsInitialized() { }

	public WaterProperties get_Properties() { }

	[CompilerGenerated]
	public static bool get_SnowMaskState() { }

	public WaterDrawer get_WaterDrawer() { }

	public void Initialize() { }

	private void MarkDrawingResultsDirty() { }

	private void OnAfterRaidStarted() { }

	public void OnDisable() { }

	public void OnEnable() { }

	private void OnGraphicsSettingsChanged() { }

	private void OnOpticChanged() { }

	public void OnPreRenderCamera(Camera camera) { }

	private void Remove(WaterContainer water) { }

	public void Render(Camera camera) { }

	[CompilerGenerated]
	private static void set_Instance(WaterRenderer value) { }

	[CompilerGenerated]
	private static void set_SnowMaskState(bool value) { }

	public void SetDynamicState(bool state) { }

	private bool ShouldProcessCamera(Camera camera) { }

	private bool ShouldRender(Camera camera) { }

	private void StartDynamicUpdate() { }

	private void StopDynamicUpdate() { }

	private void Subscribe() { }

	private void TickDynamicUpdateTimer() { }

	private void Unsubscribe() { }

	private void Update() { }

}

