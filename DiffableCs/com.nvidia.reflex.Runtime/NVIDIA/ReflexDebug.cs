namespace NVIDIA;

[AddComponentMenu("NVIDIA/Reflex Debug")]
public class ReflexDebug : MonoBehaviour
{
	private bool m_Enabled; //Field offset: 0x20
	private NvReflex_LATENCY_RESULT_PARAMS markers; //Field offset: 0x28
	private NvReflex_GET_SLEEP_STATUS_PARAMS sleepStatusParams; //Field offset: 0x30
	private Reflex m_Reflex; //Field offset: 0x38

	public ReflexDebug() { }

	private void AddScrollbar(float range, float size, float start) { }

	private void OnGUI() { }

	private void Start() { }

	private void Update() { }

}

