namespace EFT.AssetsManager;

public class PremadeAssetsPool`1 : AbstractAssetsPool
{
	[CompilerGenerated]
	private struct <Create>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public TAssetPoolObject originalObject; //Field offset: 0x0
		public Transform parentTransform; //Field offset: 0x0
		public TaskCompletionSource completionSource; //Field offset: 0x0
		public int poolSize; //Field offset: 0x0
		public YieldDelegate yield; //Field offset: 0x0
		public CancellationToken ct; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected TAssetPoolObject OriginalObject; //Field offset: 0x0

	protected virtual string PoolFullName
	{
		 get { } //Length: 419
	}

	public virtual string PoolShortName
	{
		 get { } //Length: 97
	}

	protected PremadeAssetsPool`1(TAssetPoolObject originalObject, Transform parentTransform) { }

	[AsyncStateMachine(typeof(<Create>d__1))]
	public static Task Create(TAssetPoolObject originalObject, int poolSize, Transform parentTransform, TaskCompletionSource completionSource, YieldDelegate yield, CancellationToken ct) { }

	protected virtual string get_PoolFullName() { }

	public virtual string get_PoolShortName() { }

	protected virtual GameObject GetOriginalGameObject(Transform parent) { }

}

