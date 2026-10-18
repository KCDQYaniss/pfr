namespace EFT.CameraControl;

public class ReflexController : IDisposable
{
	[CompilerGenerated]
	private struct <<OnOffReflexIfCan>g__Toggle|11_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Reflex reflex; //Field offset: 0x20
		private bool <boost>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x29
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public int i; //Field offset: 0x10
		public ReflexController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal bool <RefreshReflexCmdBuffers>b__1(Tuple x) { }

	}

	[CompilerGenerated]
	private sealed class <InitNvidiaReflex>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ENvidiaReflexMode nvidiaReflexMode; //Field offset: 0x20
		public ReflexController <>4__this; //Field offset: 0x28

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
		public <InitNvidiaReflex>d__15(int <>1__state) { }

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

	private static bool _isReflexDLLError; //Field offset: 0x0
	private readonly List _camerasWithReflex; //Field offset: 0x10
	private readonly List _activeCamerasBuffer; //Field offset: 0x18

	private Camera MainCamera
	{
		private get { } //Length: 84
	}

	private Camera OpticCamera
	{
		private get { } //Length: 93
	}

	public ReflexController() { }

	[AsyncStateMachine(typeof(<<OnOffReflexIfCan>g__Toggle|11_0>d))]
	[CompilerGenerated]
	internal static Task <OnOffReflexIfCan>g__Toggle|11_0(Reflex reflex) { }

	[CompilerGenerated]
	private bool <RefreshReflexCmdBuffers>b__13_0(Tuple x) { }

	private void CreateReflex(Camera cam, ENvidiaReflexMode nvidiaReflexMode) { }

	public override void Dispose() { }

	public void DoReflexTriggerFlash() { }

	private Camera get_MainCamera() { }

	private Camera get_OpticCamera() { }

	[IteratorStateMachine(typeof(<InitNvidiaReflex>d__15))]
	public IEnumerator InitNvidiaReflex(ENvidiaReflexMode nvidiaReflexMode) { }

	public static bool IsAutomaticReflexAnalyzerSupported() { }

	public static bool IsReflexAvailable() { }

	public static bool IsReflexAvailable(out NvReflex_Status reflexStatus) { }

	public void OnOffReflexIfCan() { }

	public void RefreshReflexCmdBuffers() { }

	public void SetNvidiaReflexModeInstant(ENvidiaReflexMode nvidiaReflexMode) { }

	private static void UpdateCamReflexState(Reflex reflex, bool isFirstCamera, bool isLastCamera) { }

}

