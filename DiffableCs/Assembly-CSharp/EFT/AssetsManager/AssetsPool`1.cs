namespace EFT.AssetsManager;

public class AssetsPool`1 : AbstractAssetsPool
{
	[CompilerGenerated]
	private struct <Create>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public IEasyAssets easyAssets; //Field offset: 0x0
		public ResourceKey resourceKey; //Field offset: 0x0
		public Transform parentTransform; //Field offset: 0x0
		public ResourceTypeInfo resourceType; //Field offset: 0x0
		public AssemblyType assemblyType; //Field offset: 0x0
		public TaskCompletionSource completionSource; //Field offset: 0x0
		public int poolSize; //Field offset: 0x0
		public YieldDelegate yield; //Field offset: 0x0
		public CancellationToken ct; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected readonly IEasyAssets EasyAssets; //Field offset: 0x0
	protected string _poolShortName; //Field offset: 0x0

	protected virtual string PoolFullName
	{
		 get { } //Length: 47
	}

	public virtual string PoolShortName
	{
		 get { } //Length: 259
	}

	protected AssetsPool`1(IEasyAssets easyAssets, ResourceKey resourceKey, Transform parentTransform, ResourceTypeInfo resourceType, AssemblyType assemblyType) { }

	[AsyncStateMachine(typeof(<Create>d__2))]
	public static Task Create(IEasyAssets easyAssets, ResourceKey resourceKey, int poolSize, Transform parentTransform, ResourceTypeInfo resourceType, AssemblyType assemblyType, CancellationToken ct, TaskCompletionSource completionSource, YieldDelegate yield) { }

	protected virtual string get_PoolFullName() { }

	public virtual string get_PoolShortName() { }

	protected virtual GameObject GetOriginalGameObject(Transform parent) { }

}

