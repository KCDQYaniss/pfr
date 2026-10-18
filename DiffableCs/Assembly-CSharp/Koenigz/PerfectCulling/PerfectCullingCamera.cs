namespace Koenigz.PerfectCulling;

[RequireComponent(typeof(Camera))]
public class PerfectCullingCamera : MonoBehaviour
{
	public static List AllCameras; //Field offset: 0x0
	private static int _lastFrame; //Field offset: 0x8
	private static int _lastFrameHash; //Field offset: 0xC
	private static int _calculatedFrameHash; //Field offset: 0x10
	[CompilerGenerated]
	private bool <VisualizeFrustumCulling>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <ObservePosition>k__BackingField; //Field offset: 0x24
	private Camera _camera; //Field offset: 0x30
	private FastArray _runtimeVolumesToUpdate; //Field offset: 0x38
	private FastArray _runtimeGroupsToUpdate; //Field offset: 0x40
	private Nullable lastJobHandle; //Field offset: 0x48

	public private Vector3 ObservePosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public bool VisualizeFrustumCulling
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static PerfectCullingCamera() { }

	public PerfectCullingCamera() { }

	private void Awake() { }

	private void CamPreCull(Camera camera) { }

	internal void CamPreCullOptimized() { }

	private void DoVisualizeFrustumCulling(Camera camera) { }

	internal void EditorInitialize() { }

	[CompilerGenerated]
	public Vector3 get_ObservePosition() { }

	[CompilerGenerated]
	public bool get_VisualizeFrustumCulling() { }

	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private void set_ObservePosition(Vector3 value) { }

	[CompilerGenerated]
	public void set_VisualizeFrustumCulling(bool value) { }

	internal void SetDirty() { }

	private void Update() { }

}

