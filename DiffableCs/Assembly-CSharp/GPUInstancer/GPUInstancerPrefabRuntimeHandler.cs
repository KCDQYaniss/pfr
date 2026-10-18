namespace GPUInstancer;

public class GPUInstancerPrefabRuntimeHandler : MonoBehaviour
{
	private static Dictionary _managerDictionary; //Field offset: 0x0
	[HideInInspector]
	public GPUInstancerPrefab gpuiPrefab; //Field offset: 0x20
	private GPUInstancerPrefabManager _prefabManager; //Field offset: 0x28

	public GPUInstancerPrefabRuntimeHandler() { }

	[CompilerGenerated]
	private bool <GetPrefabManager>b__6_0(GPUInstancerManager manager) { }

	[CompilerGenerated]
	private bool <GetPrefabManager>b__6_1(GPUInstancerManager manager) { }

	private void Awake() { }

	private GPUInstancerPrefabManager GetPrefabManager() { }

	private void OnDisable() { }

	private void Start() { }

}

