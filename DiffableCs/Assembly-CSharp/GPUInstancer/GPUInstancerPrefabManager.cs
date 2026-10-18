namespace GPUInstancer;

public class GPUInstancerPrefabManager : GPUInstancerManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__34_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RemovePrefabInstance>b__34_0(GPUInstancerPrefab pi) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public GPUInstancerRuntimeData runtimeData; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal void <AddPrefabInstances>b__0() { }

		internal void <AddPrefabInstances>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public GPUInstancerRuntimeData runtimeData; //Field offset: 0x10
		public int instanceCount; //Field offset: 0x18
		public int bufferSize; //Field offset: 0x1C

		public <>c__DisplayClass33_0() { }

		internal void <UpdateInstanceDataArray>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0`1
	{
		public GPUInstancerPrefabPrototype prototype; //Field offset: 0x0
		public string bufferName; //Field offset: 0x0

		public <>c__DisplayClass42_0`1() { }

		internal bool <DefinePrototypeVariationBuffer>b__0(IPrefabVariationData v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0`1
	{
		public GPUInstancerPrefab prefabInstance; //Field offset: 0x0
		public string bufferName; //Field offset: 0x0

		public <>c__DisplayClass43_0`1() { }

		internal bool <UpdateVariationData>b__0(IPrefabVariationData v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0`1
	{
		public GPUInstancerPrefabPrototype prototype; //Field offset: 0x0
		public string bufferName; //Field offset: 0x0

		public <>c__DisplayClass45_0`1() { }

		internal bool <UpdateVariationsFromArray>b__0(IPrefabVariationData v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public GPUInstancerPrefabPrototype prefabPrototype; //Field offset: 0x10

		public <>c__DisplayClass47_0() { }

		internal bool <AddInstancesToPrefabPrototypeAtRuntime>b__0(RegisteredPrefabsData d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public GPUInstancerPrefabPrototype prefabPrototype; //Field offset: 0x10

		public <>c__DisplayClass48_0() { }

		internal bool <RemovePrototypeAtRuntime>b__0(RegisteredPrefabsData d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public GPUInstancerPrefab prefabInstance; //Field offset: 0x10

		public <>c__DisplayClass49_0() { }

		internal bool <AddRegisteredPrefab>b__0(RegisteredPrefabsData rpd) { }

	}

	private static readonly string dryColorBufferName; //Field offset: 0x0
	private static readonly string healthyColorBufferName; //Field offset: 0x8
	[SerializeField]
	public List registeredPrefabs; //Field offset: 0xD0
	[SerializeField]
	public List prefabList; //Field offset: 0xD8
	public bool enableMROnManagerDisable; //Field offset: 0xE0
	public bool enableMROnRemoveInstance; //Field offset: 0xE1
	protected List _modificationColliders; //Field offset: 0xE8
	protected Dictionary _registeredPrefabsRuntimeData; //Field offset: 0xF0
	protected List _variationDataList; //Field offset: 0xF8
	protected bool _addRemoveInProgress; //Field offset: 0x100
	public bool IsActive; //Field offset: 0x101
	private ComputeBuffer _dryColorBuffer; //Field offset: 0x108
	private ComputeBuffer _healthyColorBuffer; //Field offset: 0x110

	protected virtual bool isCulled
	{
		 get { } //Length: 11
	}

	private static GPUInstancerPrefabManager() { }

	public GPUInstancerPrefabManager() { }

	[CompilerGenerated]
	private void <AddPrefabInstances>b__31_0() { }

	[CompilerGenerated]
	private void <RemovePrefabInstances>b__35_0() { }

	public void AddInstancesToPrefabPrototypeAtRuntime(GPUInstancerPrefabPrototype prefabPrototype, IEnumerable instances) { }

	public void AddModificationCollider(GPUInstancerModificationCollider modificationCollider) { }

	public void AddPrefabInstance(GPUInstancerPrefab prefabInstance, bool automaticallyIncreaseBufferSize = false) { }

	public void AddPrefabInstances(IEnumerable prefabInstances, bool isThreading = false) { }

	public void AddPrefabInstances(GPUInstancerPrefabPrototype prototype, IEnumerable prefabInstances, bool isThreading = false) { }

	public void AddRegisteredPrefab(GPUInstancerPrefab prefabInstance) { }

	public void AddRuntimeRegisteredPrefab(GPUInstancerPrefab prefabInstance) { }

	public virtual void Awake() { }

	public virtual void ClearInstancingData() { }

	public void ClearRegisteredPrefabInstances() { }

	public void ClearRegisteredPrefabInstances(GPUInstancerPrototype p) { }

	public PrefabVariationData DefineAndAddVariationFromArray(GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray) { }

	public GPUInstancerPrefabPrototype DefineGameObjectAsPrefabPrototypeAtRuntime(GameObject prototypeGameObject) { }

	public PrefabVariationData DefinePrototypeVariationBuffer(GPUInstancerPrefabPrototype prototype, string bufferName) { }

	public virtual void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true) { }

	public void DisableIntancingForInstance(GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true) { }

	public void EnableInstancingForInstance(GPUInstancerPrefab prefabInstance, bool setRenderersDisabled = true) { }

	public virtual void GeneratePrototypes(bool forceNew = false) { }

	public void GeneratePrototypesForWinter() { }

	protected virtual bool get_isCulled() { }

	public int GetEnabledPrefabCount() { }

	public Dictionary GetRegisteredPrefabsRuntimeData() { }

	public virtual void InitializeRuntimeDataAndBuffers(bool forceNew = true) { }

	public override GPUInstancerRuntimeData InitializeRuntimeDataForPrefabPrototype(GPUInstancerPrefabPrototype p, int additionalBufferSize = 0) { }

	private void InitializeRuntimeDataRegisteredPrefabs(int additionalBufferSize = 0) { }

	public void RegisterPrefabInstanceList(IEnumerable prefabInstanceList) { }

	public void RegisterPrefabsInScene() { }

	public void RemovePrefabInstance(GPUInstancerPrefab prefabInstance, bool setRenderersEnabled = true) { }

	public void RemovePrefabInstances(IEnumerable prefabInstances, bool isThreading = false) { }

	public void RemovePrefabInstances(GPUInstancerPrefabPrototype prototype, IEnumerable prefabInstances, bool isThreading = false) { }

	public void RemovePrototypeAtRuntime(GPUInstancerPrefabPrototype prefabPrototype) { }

	public virtual void Reset() { }

	public void SetColorBuffers(List dryColor, List healthyColor) { }

	public override void SetRenderersEnabled(GPUInstancerPrefab prefabInstance, bool enabled) { }

	public void UnregisterPrefabInstanceList(IEnumerable prefabInstanceList) { }

	public virtual void Update() { }

	public void UpdateInstanceDataArray(GPUInstancerRuntimeData runtimeData, List prefabList, bool isThreading = false) { }

	public void UpdateTransformDataForInstance(GPUInstancerPrefab prefabInstance) { }

	public void UpdateVariationData(GPUInstancerPrefab prefabInstance, string bufferName, T value) { }

	public PrefabVariationData UpdateVariationsFromArray(GPUInstancerPrefabPrototype prototype, string bufferName, T[] variationArray, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0) { }

}

