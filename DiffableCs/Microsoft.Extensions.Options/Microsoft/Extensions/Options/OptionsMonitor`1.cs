namespace Microsoft.Extensions.Options;

[Nullable(0)]
[NullableContext(1)]
public class OptionsMonitor`1 : IOptionsMonitor, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TOptions <Get>b__10_0(string name, IOptionsFactory factory) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public IOptionsFactory localFactory; //Field offset: 0x0
		public string localName; //Field offset: 0x0

		public <>c__DisplayClass10_0() { }

		internal TOptions <Get>b__1() { }

	}

	[NullableContext(0)]
	public sealed class ChangeTrackerDisposable : IDisposable
	{
		private readonly Action _listener; //Field offset: 0x0
		private readonly OptionsMonitor _monitor; //Field offset: 0x0

		[NullableContext(1)]
		public ChangeTrackerDisposable(OptionsMonitor monitor, Action listener) { }

		public override void Dispose() { }

		[NullableContext(1)]
		public void OnChange(TOptions options, string name) { }

	}

	private readonly IOptionsMonitorCache _cache; //Field offset: 0x0
	private readonly IOptionsFactory _factory; //Field offset: 0x0
	private readonly List _registrations; //Field offset: 0x0
	[CompilerGenerated]
	private Action _onChange; //Field offset: 0x0

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	internal event Action _onChange
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	public override TOptions CurrentValue
	{
		 get { } //Length: 111
	}

	public OptionsMonitor`1(IOptionsFactory factory, IEnumerable sources, IOptionsMonitorCache cache) { }

	[CompilerGenerated]
	private void <.ctor>g__RegisterSource|6_0(IOptionsChangeTokenSource source) { }

	[CompilerGenerated]
	internal void add__onChange(Action value) { }

	public override void Dispose() { }

	public override TOptions Get(string name) { }

	public override TOptions get_CurrentValue() { }

	private void InvokeChanged(string name) { }

	public override IDisposable OnChange(Action listener) { }

	[CompilerGenerated]
	internal void remove__onChange(Action value) { }

}

