namespace ZLogger;

[Nullable(0)]
[NullableContext(1)]
public sealed class LogScopeState
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2, 0, 0, 0, 0})]
		public static Action <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal void <Snapshot>b__12_0(object state, List props) { }

	}

	private const string DefaultScopeKeyName = "Scope"; //Field offset: 0x0
	private static readonly ConcurrentQueue cache; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 2})]
	private readonly List properties; //Field offset: 0x10
	private short version; //Field offset: 0x18
	private short snapshotVersion; //Field offset: 0x1A

	public bool IsEmpty
	{
		 get { } //Length: 69
	}

	[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1, 2})]
	public ReadOnlySpan Properties
	{
		 get { } //Length: 363
	}

	private static LogScopeState() { }

	public LogScopeState() { }

	private void Clear() { }

	internal static LogScopeState Create(IExternalScopeProvider scopeProvider) { }

	public bool get_IsEmpty() { }

	public ReadOnlySpan get_Properties() { }

	internal void Return() { }

	private void Snapshot(IExternalScopeProvider scopeProvider) { }

	private void ValidateVersion() { }

}

