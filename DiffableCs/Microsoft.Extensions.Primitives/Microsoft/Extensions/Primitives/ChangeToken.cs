namespace Microsoft.Extensions.Primitives;

[Nullable(0)]
[NullableContext(1)]
public static class ChangeToken
{
	private sealed class ChangeTokenRegistration`1 : IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action <>9__7_0; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal void <RegisterChangeTokenCallback>b__7_0(object s) { }

		}

		private sealed class NoopDisposable : IDisposable
		{

			public NoopDisposable() { }

			public override void Dispose() { }

		}

		private static readonly NoopDisposable _disposedSentinel; //Field offset: 0x0
		private readonly Func _changeTokenProducer; //Field offset: 0x0
		private readonly Action _changeTokenConsumer; //Field offset: 0x0
		private readonly TState _state; //Field offset: 0x0
		private IDisposable _disposable; //Field offset: 0x0

		private static ChangeTokenRegistration`1() { }

		public ChangeTokenRegistration`1(Func changeTokenProducer, Action changeTokenConsumer, TState state) { }

		public override void Dispose() { }

		private void OnChangeTokenFired() { }

		private void RegisterChangeTokenCallback(IChangeToken token) { }

		private void SetDisposable(IDisposable disposable) { }

	}


	public static IDisposable OnChange(Func changeTokenProducer, Action changeTokenConsumer, TState state) { }

}

