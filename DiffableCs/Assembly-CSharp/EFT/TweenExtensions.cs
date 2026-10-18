namespace EFT;

[Extension]
public static class TweenExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Tween self; //Field offset: 0x10
		public TaskCompletionSource source; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		internal void <GetAwaiter>g__Complete|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Tween tween; //Field offset: 0x10
		public TaskCompletionSource taskCompletionSource; //Field offset: 0x18

		public <>c__DisplayClass1_0() { }

		internal void <AsTask>b__0(object _) { }

		internal void <AsTask>b__1() { }

	}


	[Extension]
	public static Task AsTask(Tween tween, CancellationToken cancellationToken) { }

	[Extension]
	public static TaskAwaiter GetAwaiter(Tween self) { }

}

