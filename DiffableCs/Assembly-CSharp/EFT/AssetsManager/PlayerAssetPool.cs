namespace EFT.AssetsManager;

public sealed class PlayerAssetPool : AssetsPool
{
	[CompilerGenerated]
	private struct <Create>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEasyAssets easyAssets; //Field offset: 0x20
		public ResourceKey resourceKey; //Field offset: 0x28
		public Transform parentTransform; //Field offset: 0x30
		public AssemblyType assemblyType; //Field offset: 0x38
		public int poolSize; //Field offset: 0x3C
		public YieldDelegate yield; //Field offset: 0x40
		public CancellationToken ct; //Field offset: 0x48
		private PlayerAssetPool <pool>5__2; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	protected virtual string ContainerObjectName
	{
		 get { } //Length: 104
	}

	private PlayerAssetPool(IEasyAssets easyAssets, ResourceKey resourceKey, Transform parentTransform, AssemblyType assemblyType) { }

	[AsyncStateMachine(typeof(<Create>d__0))]
	public static Task Create(IEasyAssets easyAssets, ResourceKey resourceKey, int poolSize, Transform parentTransform, AssemblyType assemblyType, YieldDelegate yield, CancellationToken ct) { }

	protected virtual string get_ContainerObjectName() { }

}

