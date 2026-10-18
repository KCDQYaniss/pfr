namespace System.Diagnostics;

[Nullable(0)]
[NullableContext(1)]
public sealed class ActivitySource : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__5_1; //Field offset: 0x8
		public static Action <>9__5_0; //Field offset: 0x10
		public static Action <>9__28_0; //Field offset: 0x18
		public static Action <>9__30_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__5_0(ActivityListener listener, object source) { }

		internal int <.ctor>b__5_1(KeyValuePair left, KeyValuePair right) { }

		internal void <DetachListener>b__28_0(ActivitySource source, object obj) { }

		internal void <NotifyActivityStop>b__30_0(ActivityListener listener, object obj) { }

	}

	private static readonly SynchronizedList s_activeSources; //Field offset: 0x0
	private static readonly SynchronizedList s_allListeners; //Field offset: 0x8
	private SynchronizedList _listeners; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly IEnumerable <Tags>k__BackingField; //Field offset: 0x28

	private static ActivitySource() { }

	public ActivitySource(string name) { }

	public ActivitySource(string name, string version = "", IEnumerable tags = null) { }

	internal void AddListener(ActivityListener listener) { }

	internal static void DetachListener(ActivityListener listener) { }

	public override void Dispose() { }

	internal void NotifyActivityStop(Activity activity) { }

}

