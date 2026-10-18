namespace EFT.AssetsManager;

public abstract class AbstractAssetsPool`1 : IAssetPool, IDisposable
{
	[CompilerGenerated]
	private struct <AddRequiredComponents>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AbstractAssetsPool <>4__this; //Field offset: 0x0
		public JobYield yield; //Field offset: 0x0
		public GameObject gameObject; //Field offset: 0x0
		private ComponentConfig[] <>7__wrap1; //Field offset: 0x0
		private int <>7__wrap2; //Field offset: 0x0
		private ComponentConfig <componentConfig>5__4; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreatePoolObject>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public JobYield jobYield; //Field offset: 0x0
		public AbstractAssetsPool <>4__this; //Field offset: 0x0
		private Token <>7__wrap1; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreatePoolObjectBody>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public JobYield jobYield; //Field offset: 0x0
		public AbstractAssetsPool <>4__this; //Field offset: 0x0
		private TAssetPoolObject <poolObject>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExpandPool>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		public AbstractAssetsPool <>4__this; //Field offset: 0x0
		public int objectsCount; //Field offset: 0x0
		public YieldDelegate yield; //Field offset: 0x0
		public string reason; //Field offset: 0x0
		private bool <firstIteration>5__2; //Field offset: 0x0
		private object <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitAndFillPoolsAsync>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		public AbstractAssetsPool <>4__this; //Field offset: 0x0
		public YieldDelegate yield; //Field offset: 0x0
		public int objectsCount; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunInitialStage>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AbstractAssetsPool <>4__this; //Field offset: 0x0
		public JobYield jobYield; //Field offset: 0x0
		private Token <>7__wrap1; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunInitialStageBody>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public JobYield jobYield; //Field offset: 0x0
		public AbstractAssetsPool <>4__this; //Field offset: 0x0
		private GameObject <roleModelGameObject>5__2; //Field offset: 0x0
		private TAssetPoolObject <roleModelAssetPoolObject>5__3; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly Vector3 UNSEEN_PLACE; //Field offset: 0x0
	private int _forcedRequestsCount; //Field offset: 0x0
	private bool _isExpandPoolInProgress; //Field offset: 0x0
	protected JobYield _createPoolObjectJobImmediate; //Field offset: 0x0
	protected JobYield _createPoolObjectJob; //Field offset: 0x0
	protected JobYield _initialStageJob; //Field offset: 0x0
	private bool _initialized; //Field offset: 0x0
	[CompilerGenerated]
	private PoolContainerObject <ParentObject>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <TotalCreatedObjectsCount>k__BackingField; //Field offset: 0x0
	private GameObject _inactiveGameObject; //Field offset: 0x0
	protected int QueuedExpandCount; //Field offset: 0x0
	[CompilerGenerated]
	private bool <DontDestroy>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsWillBeDestroyedByParent>k__BackingField; //Field offset: 0x0
	protected TAssetPoolObject RoleModelAssetPoolObject; //Field offset: 0x0
	protected GameObject RoleModelGameObject; //Field offset: 0x0
	protected Stack ObjectsPool; //Field offset: 0x0
	protected AssemblyType AssemblyType; //Field offset: 0x0
	[CompilerGenerated]
	private ResourceTypeInfo <ResourceType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ResourceKey <ResourceKey>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsDisposed>k__BackingField; //Field offset: 0x0
	protected Transform ParentTransform; //Field offset: 0x0

	protected override string ContainerObjectName
	{
		 get { } //Length: 20
	}

	public override int CurrentPoolSize
	{
		 get { } //Length: 26
	}

	public bool DontDestroy
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override int FuturePoolSize
	{
		 get { } //Length: 29
	}

	private GameObject InactiveGameObject
	{
		private get { } //Length: 646
	}

	public override bool IsDisposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private bool IsGameObjectActiveInPool
	{
		private get { } //Length: 612
	}

	public override bool IsWillBeDestroyedByParent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private override PoolContainerObject ParentObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected abstract string PoolFullName
	{
		 get { } //Length: 0
	}

	public abstract string PoolShortName
	{
		 get { } //Length: 0
	}

	public override ResourceKey ResourceKey
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override ResourceTypeInfo ResourceType
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override int TotalCreatedObjectsCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static AbstractAssetsPool`1() { }

	protected AbstractAssetsPool`1(Transform parentTransform, ResourceTypeInfo resourceType, AssemblyType assemblyType) { }

	[AsyncStateMachine(typeof(<AddRequiredComponents>d__57))]
	private Task AddRequiredComponents(GameObject gameObject, JobYield yield) { }

	private void CommonDispose() { }

	[AsyncStateMachine(typeof(<CreatePoolObject>d__64))]
	private Task CreatePoolObject(JobYield jobYield) { }

	[AsyncStateMachine(typeof(<CreatePoolObjectBody>d__65))]
	private Task CreatePoolObjectBody(JobYield jobYield) { }

	public override void Dispose() { }

	private override void EFT.AssetsManager.IAssetPool.Push(AssetPoolObject poolObject) { }

	private void EnsureInitialStageIsCompleted() { }

	[AsyncStateMachine(typeof(<ExpandPool>d__61))]
	public override Task ExpandPool(int objectsCount, YieldDelegate yield, CancellationToken cancellationToken = null, string reason = "") { }

	protected override string get_ContainerObjectName() { }

	public override int get_CurrentPoolSize() { }

	[CompilerGenerated]
	public bool get_DontDestroy() { }

	public override int get_FuturePoolSize() { }

	private GameObject get_InactiveGameObject() { }

	[CompilerGenerated]
	public override bool get_IsDisposed() { }

	private bool get_IsGameObjectActiveInPool() { }

	[CompilerGenerated]
	public override bool get_IsWillBeDestroyedByParent() { }

	[CompilerGenerated]
	public override PoolContainerObject get_ParentObject() { }

	protected abstract string get_PoolFullName() { }

	public abstract string get_PoolShortName() { }

	[CompilerGenerated]
	public override ResourceKey get_ResourceKey() { }

	[CompilerGenerated]
	public override ResourceTypeInfo get_ResourceType() { }

	[CompilerGenerated]
	public override int get_TotalCreatedObjectsCount() { }

	protected abstract GameObject GetOriginalGameObject(Transform parent) { }

	[AsyncStateMachine(typeof(<InitAndFillPoolsAsync>d__62))]
	protected Task InitAndFillPoolsAsync(int objectsCount, Transform parentTransform, YieldDelegate yield, CancellationToken cancellationToken) { }

	public override GameObject PopOrCreate(bool poolShouldNotBeEmpty = false) { }

	protected void Push(TAssetPoolObject poolObject) { }

	public override void QuickDispose() { }

	public override void ReturnPoolObjects() { }

	[AsyncStateMachine(typeof(<RunInitialStage>d__55))]
	private Task RunInitialStage(JobYield jobYield) { }

	[AsyncStateMachine(typeof(<RunInitialStageBody>d__56))]
	private Task RunInitialStageBody(JobYield jobYield) { }

	[CompilerGenerated]
	protected void set_DontDestroy(bool value) { }

	[CompilerGenerated]
	protected void set_IsDisposed(bool value) { }

	[CompilerGenerated]
	protected void set_IsWillBeDestroyedByParent(bool value) { }

	[CompilerGenerated]
	private void set_ParentObject(PoolContainerObject value) { }

	[CompilerGenerated]
	protected void set_ResourceKey(ResourceKey value) { }

	[CompilerGenerated]
	private void set_ResourceType(ResourceTypeInfo value) { }

	[CompilerGenerated]
	private void set_TotalCreatedObjectsCount(int value) { }

	public virtual string ToString() { }

}

