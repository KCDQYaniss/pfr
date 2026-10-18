namespace System.Threading.Channels;

internal class AsyncOperation`1 : AsyncOperation, IValueTaskSource, IValueTaskSource
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__11_0; //Field offset: 0x0
		public static SendOrPostCallback <>9__29_0; //Field offset: 0x0
		public static SendOrPostCallback <>9__35_0; //Field offset: 0x0
		public static Action <>9__35_1; //Field offset: 0x0
		public static ContextCallback <>9__36_0; //Field offset: 0x0
		public static WaitCallback <>9__37_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__11_0(object s) { }

		internal void <OnCompleted>b__29_0(object s) { }

		internal void <SetCompletionAndInvokeContinuation>b__36_0(object s) { }

		internal void <SignalCompletion>b__35_0(object s) { }

		internal void <SignalCompletion>b__35_1(object s) { }

		internal void <UnsafeQueueSetCompletionAndInvokeContinuation>b__37_0(object s) { }

	}

	private readonly CancellationTokenRegistration _registration; //Field offset: 0x0
	private readonly bool _pooled; //Field offset: 0x0
	private readonly bool _runContinuationsAsynchronously; //Field offset: 0x0
	private int _completionReserved; //Field offset: 0x0
	private TResult _result; //Field offset: 0x0
	private ExceptionDispatchInfo _error; //Field offset: 0x0
	private Action _continuation; //Field offset: 0x0
	private object _continuationState; //Field offset: 0x0
	private object _schedulingContext; //Field offset: 0x0
	private ExecutionContext _executionContext; //Field offset: 0x0
	private short _currentId; //Field offset: 0x0
	[CompilerGenerated]
	private AsyncOperation <Next>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly CancellationToken <CancellationToken>k__BackingField; //Field offset: 0x0

	public CancellationToken CancellationToken
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal bool IsCompleted
	{
		internal get { } //Length: 97
	}

	public AsyncOperation Next
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ValueTask ValueTask
	{
		 get { } //Length: 111
	}

	public ValueTask ValueTaskOfT
	{
		 get { } //Length: 117
	}

	public AsyncOperation`1(bool runContinuationsAsynchronously, CancellationToken cancellationToken = null, bool pooled = false) { }

	[CompilerGenerated]
	public CancellationToken get_CancellationToken() { }

	internal bool get_IsCompleted() { }

	[CompilerGenerated]
	public AsyncOperation get_Next() { }

	public ValueTask get_ValueTask() { }

	public ValueTask get_ValueTaskOfT() { }

	public override TResult GetResult(short token) { }

	public override ValueTaskSourceStatus GetStatus(short token) { }

	public override void OnCompleted(Action continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

	private static void QueueUserWorkItem(Action action, object state) { }

	[CompilerGenerated]
	public void set_Next(AsyncOperation value) { }

	private void SetCompletionAndInvokeContinuation() { }

	private void SignalCompletion() { }

	private override void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token) { }

	public bool TryOwnAndReset() { }

	private bool TryReserveCompletionIfCancelable() { }

	public bool TrySetCanceled(CancellationToken cancellationToken = null) { }

	public bool TrySetException(Exception exception) { }

	public bool TrySetResult(TResult item) { }

	public bool UnregisterCancellation() { }

	private void UnsafeQueueSetCompletionAndInvokeContinuation() { }

	private static void UnsafeQueueUserWorkItem(Action action, object state) { }

	private static CancellationTokenRegistration UnsafeRegister(CancellationToken cancellationToken, Action action, object state) { }

}

