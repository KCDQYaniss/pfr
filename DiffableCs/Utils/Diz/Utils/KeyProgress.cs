namespace Diz.Utils;

public class KeyProgress
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__4_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__4_0(string x) { }

		internal float <.ctor>b__4_1(string x) { }

	}

	private readonly Dictionary _dict; //Field offset: 0x10
	private readonly IProgress _progress; //Field offset: 0x18
	private readonly Stopwatch _stopwatch; //Field offset: 0x20
	private long _lastUpdateTime; //Field offset: 0x28

	public KeyProgress(IProgress progress, IEnumerable keys) { }

	public long GetTicksSinceUpdate() { }

	public TimeSpan GetTimeSinceUpdate() { }

	public void Report(string key, float value) { }

}

