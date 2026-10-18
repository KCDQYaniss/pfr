namespace UnityEngine.Rendering.PostProcessing;

[AddComponentMenu("Rendering/Post-process Debug", 1002)]
[ExecuteAlways]
public sealed class PostProcessDebug : MonoBehaviour
{
	public PostProcessLayer postProcessLayer; //Field offset: 0x20
	private PostProcessLayer m_PreviousPostProcessLayer; //Field offset: 0x28
	public bool lightMeter; //Field offset: 0x30
	public bool histogram; //Field offset: 0x31
	public bool waveform; //Field offset: 0x32
	public bool vectorscope; //Field offset: 0x33
	public DebugOverlay debugOverlay; //Field offset: 0x34
	private Camera m_CurrentCamera; //Field offset: 0x38
	private CommandBuffer m_CmdAfterEverything; //Field offset: 0x40

	public PostProcessDebug() { }

	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnGUI() { }

	private void OnPostRender() { }

	private void Reset() { }

	private void Update() { }

	private void UpdateStates() { }

}

