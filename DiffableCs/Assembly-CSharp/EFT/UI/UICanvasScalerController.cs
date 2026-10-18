namespace EFT.UI;

public static class UICanvasScalerController
{
	[CompilerGenerated]
	private struct <ResolutionChangedHandler>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private YieldAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunResolutionObserver>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private YieldAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int REFERENCE_RESOLUTION_X = 1920; //Field offset: 0x0
	private const int REFERENCE_RESOLUTION_Y = 1080; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnResolutionChanged; //Field offset: 0x0
	private static int _currentScreenWidth; //Field offset: 0x8
	private static int _currentScreenHeight; //Field offset: 0xC
	private static float _scaleFactor; //Field offset: 0x10
	private static readonly HashSet _canvasScalers; //Field offset: 0x18
	private static bool _running; //Field offset: 0x20

	public static event Action OnResolutionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 335
		[CompilerGenerated]
		 remove { } //Length: 335
	}

	private static float ReferenceScaleFactor
	{
		private get { } //Length: 255
	}

	private static UICanvasScalerController() { }

	[CompilerGenerated]
	public static void add_OnResolutionChanged(Action value) { }

	private static void ChangeCanvasScalerRestriction(CanvasScaler scaler) { }

	private static float get_ReferenceScaleFactor() { }

	public static void Register(CanvasScaler scaler) { }

	[CompilerGenerated]
	public static void remove_OnResolutionChanged(Action value) { }

	[AsyncStateMachine(typeof(<ResolutionChangedHandler>d__15))]
	private static Task ResolutionChangedHandler() { }

	[AsyncStateMachine(typeof(<RunResolutionObserver>d__12))]
	private static Task RunResolutionObserver() { }

	public static Vector2 ScaledPosition(Vector2 position) { }

	public static void Start() { }

	public static void Stop() { }

	public static void Unregister(CanvasScaler scaler) { }

}

