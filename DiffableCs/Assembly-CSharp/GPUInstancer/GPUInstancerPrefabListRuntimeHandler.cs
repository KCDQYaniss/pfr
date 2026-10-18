namespace GPUInstancer;

public class GPUInstancerPrefabListRuntimeHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnEnable>b__4_0(GPUInstancerPrototype p) { }

	}

	public GPUInstancerPrefabManager prefabManager; //Field offset: 0x20
	private IEnumerable _gpuiPrefabs; //Field offset: 0x28
	private bool _isIntancesAdded; //Field offset: 0x30
	public bool runInThreads; //Field offset: 0x31

	public GPUInstancerPrefabListRuntimeHandler() { }

	public void AddPrefabInstancesAsync(object param) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void RemovePrefabInstancesAsync(object param) { }

	public void SetManager(GPUInstancerPrefabManager prefabManager) { }

}

