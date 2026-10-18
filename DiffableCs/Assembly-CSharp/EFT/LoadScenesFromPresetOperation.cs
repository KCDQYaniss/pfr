namespace EFT;

public sealed class LoadScenesFromPresetOperation : Operation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <LoadPresetAsync>b__17_0(ScenesPreset child) { }

	}

	[CompilerGenerated]
	private struct <DirectLoadCoroutine>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LoadScenesFromPresetOperation <>4__this; //Field offset: 0x20
		public IList scenes; //Field offset: 0x28
		public IProgress progress; //Field offset: 0x30
		private int <i>5__2; //Field offset: 0x38
		private OperationAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPresetAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ScenesPreset preset; //Field offset: 0x20
		public LoadScenesFromPresetOperation <>4__this; //Field offset: 0x28
		private int <asyncUploadTimeSlice>5__2; //Field offset: 0x30
		private int <asyncUploadBufferSize>5__3; //Field offset: 0x34
		private float <time>5__4; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private Enumerator <>7__wrap4; //Field offset: 0x48
		private LoadSceneOperation <operation>5__6; //Field offset: 0x60
		private OperationAwaiter <>u__2; //Field offset: 0x68
		private IEnumerator <>7__wrap6; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPresetFromConfigAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LoadScenesFromPresetOperation <>4__this; //Field offset: 0x20
		public ScenePresetLoadConfig preset; //Field offset: 0x28
		private OperationAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParallelLoadCoroutine>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IList scenes; //Field offset: 0x20
		public LoadScenesFromPresetOperation <>4__this; //Field offset: 0x28
		public IProgress progress; //Field offset: 0x30
		private int <i>5__2; //Field offset: 0x38
		private OperationAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ScenesLoadCoroutine>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IList scenes; //Field offset: 0x20
		public LoadScenesFromPresetOperation <>4__this; //Field offset: 0x28
		public IProgress progress; //Field offset: 0x30
		private OperationAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private bool <IsCanceled>k__BackingField; //Field offset: 0x38
	private IAssetsManager _assetsManager; //Field offset: 0x40
	private bool _loadFirstAsSingle; //Field offset: 0x48
	private bool _loadParallel; //Field offset: 0x49
	private bool _allowSceneActivation; //Field offset: 0x4A
	private CancellationToken _cancellationToken; //Field offset: 0x50
	private IProgress _progress; //Field offset: 0x58
	public readonly List _loadSceneOperations; //Field offset: 0x60
	public readonly List _subPresetsOperations; //Field offset: 0x68
	private float _scenesLoaded; //Field offset: 0x70
	private int _totalScenesToLoad; //Field offset: 0x74

	public private bool IsCanceled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public LoadScenesFromPresetOperation() { }

	[CompilerGenerated]
	private float <LoadPresetFromConfigAsync>b__16_0(float x) { }

	[AsyncStateMachine(typeof(<DirectLoadCoroutine>d__20))]
	private Task DirectLoadCoroutine(IList scenes, IProgress progress = null) { }

	internal static LoadScenesFromPresetOperation Execute(ScenePresetLoadConfig preset, IAssetsManager assetsManager, bool loadFirstAsSingle, bool loadInParallelMode, bool allowSceneActivation, CancellationToken cancellationToken = null, IProgress progress = null) { }

	internal static LoadScenesFromPresetOperation Execute(ScenesPreset preset, IAssetsManager assetsManager, bool loadFirstAsSingle, bool loadInParallelMode, bool allowSceneActivation, CancellationToken cancellationToken = null, IProgress progress = null) { }

	[CompilerGenerated]
	public bool get_IsCanceled() { }

	private string GetLoadError() { }

	[AsyncStateMachine(typeof(<LoadPresetAsync>d__17))]
	private Task LoadPresetAsync(ScenesPreset preset) { }

	[AsyncStateMachine(typeof(<LoadPresetFromConfigAsync>d__16))]
	private Task LoadPresetFromConfigAsync(ScenePresetLoadConfig preset) { }

	[AsyncStateMachine(typeof(<ParallelLoadCoroutine>d__19))]
	private Task ParallelLoadCoroutine(IList scenes, IProgress progress = null) { }

	[AsyncStateMachine(typeof(<ScenesLoadCoroutine>d__18))]
	private Task ScenesLoadCoroutine(IList scenes, IProgress progress = null) { }

	[CompilerGenerated]
	private void set_IsCanceled(bool value) { }

	private void SetCancelled() { }

	private void SetFailed(string error) { }

}

