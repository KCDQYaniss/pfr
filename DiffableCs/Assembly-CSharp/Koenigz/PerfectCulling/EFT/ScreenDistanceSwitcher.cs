namespace Koenigz.PerfectCulling.EFT;

[DisallowMultipleComponent]
[ExecuteAlways]
public sealed class ScreenDistanceSwitcher : MonoBehaviour
{
	internal static readonly List AllSwitchers; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <AllowRuntimeUpdate>k__BackingField; //Field offset: 0x8
	[SerializeField]
	private bool _enableSwitch; //Field offset: 0x20
	[SerializeField]
	private LODGroup _controlLodGroup; //Field offset: 0x28
	private float _runtimeSize; //Field offset: 0x30
	private Vector3 _runtimeCenter; //Field offset: 0x34
	private float _runtimeRelativeScreenSwitchHeight; //Field offset: 0x40
	[SerializeField]
	private int _numRenderersSwitch; //Field offset: 0x44
	private bool _isVisible; //Field offset: 0x48
	public bool IsAutocullVisible; //Field offset: 0x49
	public bool IsBakedAutocullVisible; //Field offset: 0x4A
	private IBakedLODDelegate[] _runtimeDelegates; //Field offset: 0x50
	private Renderer[] _runtimeRenderers; //Field offset: 0x58
	[HideInInspector]
	[SerializeField]
	private bool _firstSetupWasPerformed; //Field offset: 0x60

	internal static bool AllowRuntimeUpdate
	{
		[CompilerGenerated]
		internal get { } //Length: 84
		[CompilerGenerated]
		internal set { } //Length: 89
	}

	public Vector3 CenterPoint
	{
		 get { } //Length: 709
	}

	internal static bool IsRuntimeModeUpdate
	{
		internal get { } //Length: 524
	}

	public bool IsVisible
	{
		 get { } //Length: 10
	}

	public int NumRenderersSwitch
	{
		 get { } //Length: 4
	}

	public float RelativeScreenSwitchHeight
	{
		 get { } //Length: 376
	}

	public Vector3 RuntimeCenter
	{
		 get { } //Length: 19
	}

	public float RuntimeRelativeScreenSwitchHeight
	{
		 get { } //Length: 6
	}

	public float RuntimeSize
	{
		 get { } //Length: 6
	}

	public float Size
	{
		 get { } //Length: 532
	}

	private static ScreenDistanceSwitcher() { }

	public ScreenDistanceSwitcher() { }

	private void Awake() { }

	internal void EnableScreenDistanceSwitcher(bool flag) { }

	[CompilerGenerated]
	internal static bool get_AllowRuntimeUpdate() { }

	public Vector3 get_CenterPoint() { }

	internal static bool get_IsRuntimeModeUpdate() { }

	public bool get_IsVisible() { }

	public int get_NumRenderersSwitch() { }

	public float get_RelativeScreenSwitchHeight() { }

	public Vector3 get_RuntimeCenter() { }

	public float get_RuntimeRelativeScreenSwitchHeight() { }

	public float get_RuntimeSize() { }

	public float get_Size() { }

	public MeshRenderer[] GetBakedLodRenderers() { }

	internal void Initialize() { }

	private void OnDestroy() { }

	private void PerformInitialSetup() { }

	private void RuntimeCacheValues() { }

	[CompilerGenerated]
	internal static void set_AllowRuntimeUpdate(bool value) { }

	private void Show(bool flag) { }

	internal void Shutdown() { }

	private void Update() { }

	private void UpdateSwitch() { }

}

