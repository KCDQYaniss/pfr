//Type is in global namespace

public class IconCreatorGraphicsSettings
{
	[CompilerGenerated]
	private struct <Prepare>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private YieldAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestMipZero>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IconCreatorGraphicsSettings <>4__this; //Field offset: 0x20
		public GameObject obj; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestMipZeroFast>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IconCreatorGraphicsSettings <>4__this; //Field offset: 0x20
		public GameObject obj; //Field offset: 0x28
		private int <waitTime>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x34

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ResetRequestedMip>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject obj; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct T2DInfo
	{
		public Texture2D tex2d; //Field offset: 0x0
		public int requestsCount; //Field offset: 0x8
		public bool loggedError; //Field offset: 0xC

	}

	private static float _mipBudget; //Field offset: 0x0
	private static int _requests; //Field offset: 0x4
	private static readonly List _textures2d; //Field offset: 0x8
	private static readonly List _materials; //Field offset: 0x10
	private static readonly List _names; //Field offset: 0x18
	private static readonly List _uniqueNames; //Field offset: 0x20

	private static IconCreatorGraphicsSettings() { }

	public IconCreatorGraphicsSettings() { }

	[AsyncStateMachine(typeof(<Prepare>d__7))]
	public Task Prepare() { }

	[AsyncStateMachine(typeof(<RequestMipZero>d__10))]
	public Task RequestMipZero(GameObject obj) { }

	[AsyncStateMachine(typeof(<RequestMipZeroFast>d__9))]
	public Task RequestMipZeroFast(GameObject obj) { }

	private void RequestMipZeroStart(GameObject obj) { }

	[AsyncStateMachine(typeof(<ResetRequestedMip>d__12))]
	public Task ResetRequestedMip(GameObject obj) { }

	public void Restore() { }

}

