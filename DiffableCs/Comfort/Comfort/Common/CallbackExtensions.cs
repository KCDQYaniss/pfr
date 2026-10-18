namespace Comfort.Common;

[Extension]
public static class CallbackExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0`2
	{
		public Callback callback; //Field offset: 0x0

		public <>c__DisplayClass0_0`2() { }

		internal void <Cast>b__0(Result result) { }

	}


	[Extension]
	public static Callback Cast(Callback callback) { }

	[Extension]
	public static void Fail(Callback callback, string error) { }

	[Extension]
	public static void Fail(Callback callback, string error, int errorCode) { }

	[Extension]
	public static void Invoke(Callback callback, Exception sourceError) { }

	[Extension]
	public static void Invoke(Callback callback, Result sourceResult) { }

	[Extension]
	public static void Invoke(Callback callback, Result sourceResult) { }

	[Extension]
	public static void Succeed(Callback callback) { }

}

