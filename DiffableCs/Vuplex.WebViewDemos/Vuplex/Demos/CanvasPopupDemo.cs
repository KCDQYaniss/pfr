namespace Vuplex.Demos;

internal class CanvasPopupDemo : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		private struct <<Start>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public PopupRequestedEventArgs eventArgs; //Field offset: 0x28
			public <>c__DisplayClass0_0 <>4__this; //Field offset: 0x30
			private <>c__DisplayClass0_1 <>8__1; //Field offset: 0x38
			private TaskAwaiter <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public CanvasWebViewPrefab mainWebViewPrefab; //Field offset: 0x10
		public GameObject canvas; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		[AsyncStateMachine(typeof(<<Start>b__0>d))]
		internal void <Start>b__0(object webView, PopupRequestedEventArgs eventArgs) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_1
	{
		public CanvasWebViewPrefab popupPrefab; //Field offset: 0x10

		public <>c__DisplayClass0_1() { }

		internal void <Start>b__1(object popupWebView, EventArgs closeEventArgs) { }

	}

	[CompilerGenerated]
	private struct <Start>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private <>c__DisplayClass0_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string NOT_SUPPORTED_HTML = "
            <body>
                <style>
                    body {
                        font-family: sans-serif;
                        display: flex;
                        justify-content: center;
                        align-items: center;
                        line-height: 1.25;
                    }
                    div {
                        max-width: 80%;
                    }
                    li {
                        margin: 10px 0;
                    }
                </style>
                <div>
                    <p>
                        Sorry, but this 3D WebView package doesn't support yet the <a href='https://developer.vuplex.com/webview/IWithPopups'>IWithPopups</a> interface. Current packages that support popups:
                    </p>
                    <ul>
                        <li>
                            <a href='https://developer.vuplex.com/webview/StandaloneWebView'>3D WebView for Windows and macOS</a>
                        </li>
                        <li>
                            <a href='https://developer.vuplex.com/webview/AndroidWebView'>3D WebView for Android</a>
                        </li>
                        <li>
                            <a href='https://developer.vuplex.com/webview/AndroidGeckoWebView'>3D WebView for Android with Gecko Engine</a>
                        </li>
                    </ul>
                </div>
            </body>
        "; //Field offset: 0x0

	public CanvasPopupDemo() { }

	[AsyncStateMachine(typeof(<Start>d__0))]
	private void Start() { }

}

