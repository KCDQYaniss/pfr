namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ConfiguredValueTaskAwaitable`1
{
	[IsReadOnly]
	internal struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly ValueTask _value; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 54
		}

		internal ConfiguredValueTaskAwaiter(ValueTask value) { }

		public bool get_IsCompleted() { }

		[StackTraceHidden]
		public TResult GetResult() { }

		public override void OnCompleted(Action continuation) { }

		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly ValueTask _value; //Field offset: 0x0

	internal ConfiguredValueTaskAwaitable`1(ValueTask value) { }

	public ConfiguredValueTaskAwaiter GetAwaiter() { }

}

