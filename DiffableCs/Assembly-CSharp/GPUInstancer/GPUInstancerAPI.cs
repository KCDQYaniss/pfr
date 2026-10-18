namespace GPUInstancer;

public static class GPUInstancerAPI
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Camera camera; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal void <SetCamera>b__0(GPUInstancerManager m) { }

	}


	public static void AddInstancesToPrefabPrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prefabPrototype, IEnumerable instances) { }

	public static void AddPrefabInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance) { }

	public static void AddVariation(GPUInstancerPrefab prefabInstance, string bufferName, T value) { }

	public static void ChangeMaterial(GPUInstancerManager manager, GPUInstancerPrototype prototype, Material material, int lodLevel = 0, int rendererIndex = 0, int subMeshIndex = 0) { }

	public static void ChangeMesh(GPUInstancerManager manager, GPUInstancerPrototype prototype, Mesh mesh, int lodLevel = 0, int rendererIndex = 0, int subMeshIndex = 0) { }

	public static void ClearRegisteredPrefabInstances(GPUInstancerPrefabManager manager, GPUInstancerPrototype prototype) { }

	public static void ClearRegisteredPrefabInstances(GPUInstancerPrefabManager manager) { }

	public static void DefineAndAddVariationFromArray(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray) { }

	public static GPUInstancerPrefabPrototype DefineGameObjectAsPrefabPrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GameObject prototypeGameObject) { }

	public static void DefinePrototypeVariationBuffer(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName) { }

	public static void DisableIntancingForInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true) { }

	public static void EnableInstancingForInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool setRenderersDisabled = true) { }

	public static List GetActiveManagers() { }

	public static int[,] GetDetailLayer(GPUInstancerDetailManager manager, int layerIndex) { }

	public static List GetDetailMapData(GPUInstancerDetailManager manager) { }

	public static Matrix4x4[] GetInstanceDataArray(GPUInstancerManager manager, GPUInstancerPrototype prototype) { }

	public static List GetPrototypeList(GPUInstancerManager manager) { }

	public static ComputeBuffer GetTransformDataBuffer(GPUInstancerManager manager, GPUInstancerPrototype prototype) { }

	public static GPUInstancerRuntimeData InitializeGPUInstancer(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype) { }

	public static void InitializeGPUInstancer(GPUInstancerManager manager, bool forceNew = true) { }

	public static void InitializeWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array) { }

	public static void RegisterPrefabInstanceList(GPUInstancerPrefabManager manager, IEnumerable prefabInstanceList) { }

	public static void RemoveInstancesInsideBounds(GPUInstancerManager manager, Bounds bounds, float offset = 0, List prototypeFilter = null) { }

	public static void RemoveInstancesInsideCollider(GPUInstancerManager manager, Collider collider, float offset = 0, List prototypeFilter = null) { }

	public static void RemovePrefabInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true) { }

	public static void RemovePrototypeAtRuntime(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prefabPrototype) { }

	public static void SetCamera(GPUInstancerManager manager, Camera camera) { }

	public static void SetCamera(Camera camera) { }

	public static void SetDetailMapData(GPUInstancerDetailManager manager, List detailMapData) { }

	public static void SetGlobalPositionOffset(GPUInstancerManager manager, Vector3 offsetPosition) { }

	public static void SetInstanceCount(GPUInstancerManager manager, GPUInstancerPrototype prototype, int instanceCount) { }

	public static void SetLODBias(GPUInstancerManager manager, float newLODBias, List prototypeFilter = null) { }

	public static void SetupManagerWithTerrain(GPUInstancerTerrainManager manager, Terrain terrain) { }

	public static void StartListeningGPUIEvent(GPUInstancerEventType eventType, UnityAction callback) { }

	public static void StopListeningGPUIEvent(GPUInstancerEventType eventType, UnityAction callback) { }

	public static void UnregisterPrefabInstanceList(GPUInstancerPrefabManager manager, IEnumerable prefabInstanceList) { }

	public static void UpdateDetailInstances(GPUInstancerDetailManager manager, bool updateMeshes = false) { }

	public static void UpdateTerrainNormalMapDetailInstance(GPUInstancerDetailManager manager) { }

	public static void UpdateTransformDataForInstance(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance) { }

	public static void UpdateVariation(GPUInstancerPrefabManager manager, GPUInstancerPrefab prefabInstance, string bufferName, T value) { }

	public static void UpdateVariationFromArray(GPUInstancerPrefabManager manager, GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0) { }

	public static void UpdateVisibilityBufferWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0) { }

}

