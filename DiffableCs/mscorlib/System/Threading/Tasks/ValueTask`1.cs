namespace System.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder`1))]
[IsReadOnly]
public struct ValueTask`1 : IEquatable
{
	private sealed class ValueTaskSourceAsTask : Task
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal void <.cctor>b__4_0(object state) { }

		}

		private static readonly Action s_completionAction; //Field offset: 0x0
		private IValueTaskSource _source; //Field offset: 0x0
		private readonly short _token; //Field offset: 0x0

		private static ValueTaskSourceAsTask() { }

		public ValueTaskSourceAsTask(IValueTaskSource source, short token) { }

	}

	private static Task s_canceledTask; //Field offset: 0x0
	internal readonly object _obj; //Field offset: 0x0
	internal readonly TResult _result; //Field offset: 0x0
	internal readonly short _token; //Field offset: 0x0
	internal readonly bool _continueOnCapturedContext; //Field offset: 0x0

	public bool IsCompleted
	{
		 get { } //Length: 252
	}

	public bool IsCompletedSuccessfully
	{
		 get { } //Length: 265
	}

	public TResult Result
	{
		 get { } //Length: 294
	}

	public ValueTask`1(TResult result) { }

	public ValueTask`1(Task task) { }

	public ValueTask`1(IValueTaskSource source, short token) { }

	private ValueTask`1(object obj, TResult result, short token, bool continueOnCapturedContext) { }

	public Task AsTask() { }

	public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ValueTask other) { }

	public bool get_IsCompleted() { }

	public bool get_IsCompletedSuccessfully() { }

	public TResult get_Result() { }

	public ValueTaskAwaiter GetAwaiter() { }

	public virtual int GetHashCode() { }

	private Task GetTaskForValueTaskSource(IValueTaskSource t) { }

	public virtual string ToString() { }

}

