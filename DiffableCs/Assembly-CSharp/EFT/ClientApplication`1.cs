namespace EFT;

[ScriptOrder(-800)]
public abstract class ClientApplication`1 : AbstractApplication
{
	[CompilerGenerated]
	private sealed class <CheckNVidiaReflexAvailability>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public ClientApplication <>4__this; //Field offset: 0x0

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
		public <CheckNVidiaReflexAvailability>d__16(int <>1__state) { }

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

	[CompilerGenerated]
	private struct <InitializeGUISounds>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientApplication <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartTask>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientApplication <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected IClientBackEnd ClientBackEnd; //Field offset: 0x0
	protected InputTree _inputTree; //Field offset: 0x0
	protected BundleLock BundleLock; //Field offset: 0x0
	private ConnectionDiagnostics _connectionDiagnostics; //Field offset: 0x0
	private PerfHelperWrapper _perfHelperWrapper; //Field offset: 0x0

	protected ILocalizationLoader LocalizationLoader
	{
		 get { } //Length: 76
	}

	protected virtual EUpdateQueue PlayerUpdateQueue
	{
		 get { } //Length: 3
	}

	protected T Session
	{
		 get { } //Length: 74
	}

	protected ClientApplication`1() { }

	public virtual void Awake() { }

	[IteratorStateMachine(typeof(<CheckNVidiaReflexAvailability>d__16))]
	protected IEnumerator CheckNVidiaReflexAvailability() { }

	protected virtual LogConfiguration CreateLogConfiguration() { }

	protected override void DestroyApplication() { }

	protected ILocalizationLoader get_LocalizationLoader() { }

	protected virtual EUpdateQueue get_PlayerUpdateQueue() { }

	protected T get_Session() { }

	public T GetClientBackEndSession() { }

	protected override void Init(IAssetsManager assetsManager, InputTree inputTree) { }

	private void InitializeAudioListenerManager() { }

	[AsyncStateMachine(typeof(<InitializeGUISounds>d__23))]
	private Task InitializeGUISounds() { }

	protected override void LateUpdate() { }

	public void OnApplicationFocus(bool hasFocus) { }

	public virtual void OnDestroy() { }

	private void Start() { }

	[AsyncStateMachine(typeof(<StartTask>d__14))]
	protected override Task StartTask() { }

}

