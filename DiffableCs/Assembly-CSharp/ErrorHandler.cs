//Type is in global namespace

public class ErrorHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public MonoBehaviour sender; //Field offset: 0x10
		public IEnumerator enumerator; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <HandleError>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <Pause>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public ErrorHandler <>4__this; //Field offset: 0x28
		public Action callback; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Pause>d__10(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static string DirectoryPath; //Field offset: 0x0
	private static string ErrorCodeMessage; //Field offset: 0x8
	private static string PauseWarning; //Field offset: 0x10
	private static string CloseApplicationError; //Field offset: 0x18
	private static ErrorHandler _instance; //Field offset: 0x20
	private List _errorLogs; //Field offset: 0x10

	internal static ErrorHandler Instance
	{
		internal get { } //Length: 411
	}

	private static ErrorHandler() { }

	public ErrorHandler() { }

	private void CloseApplication() { }

	internal static ErrorHandler get_Instance() { }

	internal void HandleError(MonoBehaviour sender, ErrorCode code = 0, string message = null, IEnumerator enumerator = null) { }

	[IteratorStateMachine(typeof(<Pause>d__10))]
	private IEnumerator Pause(float time, Action callback) { }

	private void WriteToFile() { }

}

