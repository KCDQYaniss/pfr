namespace Vuplex.Demos;

internal class CanvasWorldSpaceDemo : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static EventHandler <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Start>b__1_0(object sender, UrlChangedEventArgs eventArgs) { }

	}

	[CompilerGenerated]
	private struct <Start>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CanvasWorldSpaceDemo <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private CanvasWebViewPrefab canvasWebViewPrefab; //Field offset: 0x20

	public CanvasWorldSpaceDemo() { }

	[AsyncStateMachine(typeof(<Start>d__1))]
	private void Start() { }

}

