namespace FilesChecker;

public sealed class ConsistencyController : IConsistencyController, IFilesChecker
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string buildId; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <PreloadAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <EnsureConsistency>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ConsistencyController <>4__this; //Field offset: 0x20
		public Action onProgress; //Field offset: 0x28
		public ConsistencyEnsuranceMode ordinaryFileEnsuranceMode; //Field offset: 0x30
		public ConsistencyEnsuranceMode criticalFileEnsuranceMode; //Field offset: 0x34
		public CancellationToken cancellationToken; //Field offset: 0x38
		private Stopwatch <stopwatch>5__2; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureConsistencySingle>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ConsistencyController <>4__this; //Field offset: 0x20
		public string path; //Field offset: 0x28
		public ConsistencyEnsuranceMode ordinaryFileEnsuranceMode; //Field offset: 0x30
		public ConsistencyEnsuranceMode criticalFileEnsuranceMode; //Field offset: 0x34
		public CancellationToken cancellationToken; //Field offset: 0x38
		private Stopwatch <stopwatch>5__2; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class CheckResult : ICheckResult
	{
		[CompilerGenerated]
		private TimeSpan <ElapsedTime>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Exception <Exception>k__BackingField; //Field offset: 0x18

		public private override TimeSpan ElapsedTime
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public private override Exception Exception
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public CheckResult() { }

		internal static ICheckResult Cancelled(TimeSpan elapsedTime, OperationCanceledException exception = null) { }

		internal static ICheckResult Failed(TimeSpan elapsedTime, Exception exception) { }

		[CompilerGenerated]
		public override TimeSpan get_ElapsedTime() { }

		[CompilerGenerated]
		public override Exception get_Exception() { }

		[CompilerGenerated]
		private void set_ElapsedTime(TimeSpan value) { }

		[CompilerGenerated]
		private void set_Exception(Exception value) { }

		internal static ICheckResult Succeed(TimeSpan elapsedTime) { }

	}

	private static readonly Dictionary _fileConsistencyMetadatas; //Field offset: 0x0
	private static bool IsInitialized; //Field offset: 0x8
	private static Task InitTask; //Field offset: 0x10
	private static readonly object LoadLock; //Field offset: 0x18
	private static readonly SemaphoreSlim SameTimeLoad; //Field offset: 0x20
	private readonly FileManager _fileManager; //Field offset: 0x10
	private readonly ByteArrayPool _byteArrayPool; //Field offset: 0x18
	private readonly FilesCheckerLogger _logger; //Field offset: 0x20
	private readonly string _buildId; //Field offset: 0x28

	private static ConsistencyController() { }

	public ConsistencyController(string buildId) { }

	private int CalculateChecksum(Stream stream, CancellationToken cancellationToken) { }

	private void EnsureAvailability(FileConsistencyMetadata fileConsistencyMetadata) { }

	private void EnsureChecksum(FileConsistencyMetadata fileConsistencyMetadata, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<EnsureConsistency>d__13))]
	public override Task EnsureConsistency(ConsistencyEnsuranceMode ordinaryFileEnsuranceMode = 3, ConsistencyEnsuranceMode criticalFileEnsuranceMode = 7, Action onProgress = null, CancellationToken cancellationToken = null) { }

	public override void EnsureConsistency(FileConsistencyMetadata fileConsistencyMetadata, ConsistencyEnsuranceMode ensuranceMode, CancellationToken cancellationToken = null) { }

	[AsyncStateMachine(typeof(<EnsureConsistencySingle>d__12))]
	public override Task EnsureConsistencySingle(string path, ConsistencyEnsuranceMode ordinaryFileEnsuranceMode = 3, ConsistencyEnsuranceMode criticalFileEnsuranceMode = 7, CancellationToken cancellationToken = null) { }

	private void EnsureSize(FileConsistencyMetadata fileConsistencyMetadata) { }

	public static Task PreloadAsync(string buildId) { }

	private ConsistencyEnsuranceMode ResolveConsistencyEnsuranceMode(ConsistencyEnsuranceMode ordinaryFileEnsuranceMode, ConsistencyEnsuranceMode criticalFileEnsuranceMode, FileConsistencyMetadata fileConsistencyMetadata) { }

	private void TryFillConsistencyMetadatas() { }

}

