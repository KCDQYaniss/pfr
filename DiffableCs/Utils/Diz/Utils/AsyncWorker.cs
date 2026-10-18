namespace Diz.Utils;

public sealed class AsyncWorker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0`1
	{
		public Func function; //Field offset: 0x0
		public TaskCompletionSource completionSource; //Field offset: 0x0

		public <>c__DisplayClass10_0`1() { }

		internal Action <RunOnBackgroundThread>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_1`1
	{
		public TResult result; //Field offset: 0x0
		public <>c__DisplayClass10_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass10_1`1() { }

		internal void <RunOnBackgroundThread>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_2`1
	{
		public Exception e; //Field offset: 0x0
		public <>c__DisplayClass10_0 CS$<>8__locals2; //Field offset: 0x0

		public <>c__DisplayClass10_2`1() { }

		internal void <RunOnBackgroundThread>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Action function; //Field offset: 0x10
		public TaskCompletionSource completionSource; //Field offset: 0x18
		public Action <>9__1; //Field offset: 0x20

		public <>c__DisplayClass9_0() { }

		internal Action <RunOnBackgroundThread>b__0() { }

		internal void <RunOnBackgroundThread>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_1
	{
		public Exception e; //Field offset: 0x10
		public <>c__DisplayClass9_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass9_1() { }

		internal void <RunOnBackgroundThread>b__2() { }

	}

	[CompilerGenerated]
	private static readonly TaskWorker <Worker>k__BackingField; //Field offset: 0x0

	private static TaskWorker Worker
	{
		[CompilerGenerated]
		private get { } //Length: 83
	}

	private static AsyncWorker() { }

	public AsyncWorker() { }

	public static bool CheckIsMainThread() { }

	private void FixedUpdate() { }

	[CompilerGenerated]
	private static TaskWorker get_Worker() { }

	public static bool IsStopped() { }

	private void OnDestroy() { }

	public static void RunInMainTread(Action action) { }

	public static Task RunOnBackgroundThread(Action function) { }

	public static Task RunOnBackgroundThread(Func function) { }

	private void Start() { }

	private void Update() { }

}

