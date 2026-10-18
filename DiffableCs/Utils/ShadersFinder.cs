//Type is in global namespace

public static class ShadersFinder
{
	[CompilerGenerated]
	private struct <InitShadersDictionary>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private string[] <>7__wrap1; //Field offset: 0x20
		private int <>7__wrap2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly Dictionary SHADERS; //Field offset: 0x0
	private static bool _isInited; //Field offset: 0x8

	private static ShadersFinder() { }

	public static Shader Find(string name) { }

	[AsyncStateMachine(typeof(<InitShadersDictionary>d__3))]
	public static Task InitShadersDictionary() { }

}

