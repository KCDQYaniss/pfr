namespace EFT.Utilities;

public abstract class MetricsCollector : IMetricsCollector
{
	private readonly List _metricsCollectors; //Field offset: 0x10
	private readonly List _binMetricsCollectors; //Field offset: 0x18
	private readonly IRaidCounter _raidCounter; //Field offset: 0x20
	private float _startTime; //Field offset: 0x28
	private float _timeSpan; //Field offset: 0x2C
	[CompilerGenerated]
	private FrameBinMetricCollector <FrameBinMetricCollector>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private MemoryMetricCollector <MemoryMetricCollector>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Metrics <Metrics>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <Stopped>k__BackingField; //Field offset: 0x48

	public FrameBinMetricCollector FrameBinMetricCollector
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MemoryMetricCollector MemoryMetricCollector
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private Metrics Metrics
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override bool Stopped
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected MetricsCollector(IRaidCounter raidCounter) { }

	[CompilerGenerated]
	public FrameBinMetricCollector get_FrameBinMetricCollector() { }

	[CompilerGenerated]
	public MemoryMetricCollector get_MemoryMetricCollector() { }

	[CompilerGenerated]
	public Metrics get_Metrics() { }

	[CompilerGenerated]
	public override bool get_Stopped() { }

	public override void LateUpdate() { }

	protected void Register(IMetricsCollector metricsCollector) { }

	[CompilerGenerated]
	protected void set_FrameBinMetricCollector(FrameBinMetricCollector value) { }

	[CompilerGenerated]
	protected void set_MemoryMetricCollector(MemoryMetricCollector value) { }

	[CompilerGenerated]
	private void set_Metrics(Metrics value) { }

	[CompilerGenerated]
	private void set_Stopped(bool value) { }

	public override void Start() { }

	public override void Stop() { }

}

