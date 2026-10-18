namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ConfiguredTaskAwaitable`1
{
	[IsReadOnly]
	internal struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly Task m_task; //Field offset: 0x0
		private readonly bool m_continueOnCapturedContext; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 96
		}

		internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext) { }

		public bool get_IsCompleted() { }

		[StackTraceHidden]
		public TResult GetResult() { }

		public override void OnCompleted(Action continuation) { }

		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter; //Field offset: 0x0

	internal ConfiguredTaskAwaitable`1(Task task, bool continueOnCapturedContext) { }

	public ConfiguredTaskAwaiter GetAwaiter() { }

}

