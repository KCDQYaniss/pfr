namespace EFT.Communications;

internal sealed class LongPollingRequest : LongPollingRequestAbstract
{
	[CompilerGenerated]
	private sealed class <Request>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LongPollingRequest <>4__this; //Field offset: 0x20
		private Uri <uri>5__2; //Field offset: 0x28
		private UnityWebRequest <request>5__3; //Field offset: 0x30

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
		public <Request>d__10(int <>1__state) { }

		private void <>m__Finally1() { }

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

	private const int REQUEST_TIMEOUT = 900; //Field offset: 0x0
	private Coroutine _requestCoroutine; //Field offset: 0x38
	private UnityWebRequest _request; //Field offset: 0x40

	public virtual ENotificationTransportType TransportType
	{
		 get { } //Length: 3
	}

	protected virtual string TypeName
	{
		 get { } //Length: 49
	}

	internal LongPollingRequest(string uri = null, IReadOnlyDictionary uriParams = null, IReadOnlyDictionary requestHeaders = null) { }

	protected virtual void Connect() { }

	protected virtual void Disconnect() { }

	public virtual ENotificationTransportType get_TransportType() { }

	protected virtual string get_TypeName() { }

	[IteratorStateMachine(typeof(<Request>d__10))]
	private IEnumerator Request() { }

}

