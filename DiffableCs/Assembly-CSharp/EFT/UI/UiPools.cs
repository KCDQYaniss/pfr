namespace EFT.UI;

public sealed class UiPools : MonoBehaviourSingleton
{
	[CompilerGenerated]
	private struct <Init>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UiPools <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UiPools <>4__this; //Field offset: 0x20
		public YieldDelegate yield; //Field offset: 0x28
		private PoolDescriptor[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private PoolDescriptor <descriptor>5__4; //Field offset: 0x40
		private string <key>5__5; //Field offset: 0x50
		private ResourceRequest <loadingOperation>5__6; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[IsReadOnly]
	private struct PoolDescriptor
	{
		public readonly string Path; //Field offset: 0x0
		public readonly int InitialCount; //Field offset: 0x8

		public PoolDescriptor(string layoutName, int initialCount) { }

	}

	private readonly PoolDescriptor[] _poolDescriptors; //Field offset: 0x20
	private Dictionary _pools; //Field offset: 0x28

	public UiPools() { }

	[CanBeNull]
	public T GetGameObject(string path) { }

	[AsyncStateMachine(typeof(<Init>d__3))]
	public Task Init() { }

	[AsyncStateMachine(typeof(<Init>d__4))]
	private Task Init(YieldDelegate yield) { }

	public virtual void OnDestroy() { }

}

