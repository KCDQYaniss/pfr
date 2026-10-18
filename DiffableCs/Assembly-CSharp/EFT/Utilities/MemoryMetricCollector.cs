namespace EFT.Utilities;

public sealed class MemoryMetricCollector : IMetricsCollector
{
	private readonly Nullable _memoryMeasureInterval; //Field offset: 0x10
	private float _memoryMeasureTime; //Field offset: 0x18
	private List _memoryList; //Field offset: 0x20
	[CompilerGenerated]
	private ulong[] <Memory>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <Stopped>k__BackingField; //Field offset: 0x30

	public private ulong[] Memory
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

	public MemoryMetricCollector(Nullable memoryMeasureInterval = null, float minimalMemoryMeasureInterval = 30) { }

	[CompilerGenerated]
	public ulong[] get_Memory() { }

	[CompilerGenerated]
	public override bool get_Stopped() { }

	public override void LateUpdate() { }

	[CompilerGenerated]
	private void set_Memory(ulong[] value) { }

	[CompilerGenerated]
	private void set_Stopped(bool value) { }

	public override void Start() { }

	public override void Stop() { }

}

