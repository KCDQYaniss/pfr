namespace EFT.Utilities;

public abstract class BinMetricCollector : IMetricsCollector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__2_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__2_0(uint value) { }

		internal uint <.ctor>b__2_1(uint key) { }

	}

	private readonly uint[] _keys; //Field offset: 0x10
	protected ulong[] _values; //Field offset: 0x18
	[CompilerGenerated]
	private Timing[] <Timings>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Stopped>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <Paused>k__BackingField; //Field offset: 0x29

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public bool Paused
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private override bool Stopped
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Timing[] Timings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected BinMetricCollector(uint[] keys = null) { }

	private static int BinarySearchBinIndex(uint[] keys, uint value) { }

	public abstract string get_Name() { }

	[CompilerGenerated]
	public bool get_Paused() { }

	[CompilerGenerated]
	public override bool get_Stopped() { }

	[CompilerGenerated]
	public Timing[] get_Timings() { }

	protected abstract uint GetCurrentValue() { }

	protected override Timing[] GetTimings() { }

	protected void IncrementBin(uint value) { }

	public override void LateUpdate() { }

	[CompilerGenerated]
	public void set_Paused(bool value) { }

	[CompilerGenerated]
	private void set_Stopped(bool value) { }

	[CompilerGenerated]
	private void set_Timings(Timing[] value) { }

	public override void Start() { }

	public override void Stop() { }

}

